using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    public partial class Venda : Form
    {
        List<Produto> listaProdutos = new List<Produto>();
        public string getValor()
        {
            return lblTotal.Text;
        }

        public decimal totalCompra = 0;

        public Venda()
        {
            InitializeComponent();

        }


        private void btnAdicionar_Click(object sender, EventArgs e)

        {
            string itemAdicionado;

            try
            {

                if (!txtPro.Text.Equals("")) //caso seja preenchido apenaso nome do produto
                {

                    cadastroproduto MostrarProduto = new cadastroproduto();
                    MostrarProduto.Produto = txtPro.Text;

                    MySqlDataReader reader = MostrarProduto.SelecionarProduto();
                    decimal precoProd;

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {

                            reader.Read();

                            precoProd = Convert.ToDecimal(txtQuant.Text) * Convert.ToDecimal(reader["preco"]);
                            itemAdicionado = $"{reader["produto"]}              R${reader["preco"]}              x{txtQuant.Text}u             R${precoProd}";
                            listaVenda.Items.Add(itemAdicionado, 1);

                            listaProdutos.Add(new Produto(Convert.ToInt32(txtQuant.Text), Convert.ToInt32(txtQuant.Text)));
                           
                            totalCompra += precoProd;
                            lblTotal.Text = totalCompra.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Produto não localizado!");
                            txtPro.Clear();
                            txtQuant.Clear();
                        }

                    }



                }
                else if (!txtCodPro.Text.Equals("")) // caso seja preenchido apenas o codigo do produto
                {

                    cadastroproduto MostrarProduto = new();
                    MostrarProduto.Codigo = Convert.ToInt32(txtCodPro.Text);

                    MySqlDataReader reader = MostrarProduto.SelecionarProdutoCod();
                    decimal precoProd;

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {

                            reader.Read();

                            precoProd = Convert.ToDecimal(txtQuant.Text) * Convert.ToDecimal(reader["preco"]);
                            itemAdicionado = $"{reader["produto"]}              R${reader["preco"]}              x{txtQuant.Text}u             R${precoProd}";
                            listaVenda.Items.Add(itemAdicionado, 1);

                            listaProdutos.Add(new Produto(Convert.ToInt32(txtCodPro.Text), Convert.ToInt32(txtQuant.Text)));

                            totalCompra += precoProd;
                            lblTotal.Text = "R$ " + totalCompra.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Produto não localizado!");
                            txtPro.Clear();
                            txtQuant.Clear();
                        }
                    }
                }
                txtPro.Clear();
                txtCodPro.Clear();
                txtQuant.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Preencha os campos adequadamente! " + ex.Message);
                txtPro.Clear();
            }



        }



        private void btnFinal_Click(object sender, EventArgs e)
        {
            string valor = totalCompra.ToString().Replace(',', '.');

            Debug.WriteLine(valor);

            try
            {
                if (!lblTotal.Text.Equals(" ") && !boxPag.Text.Equals(" "))
                {

                    InserirVenda NovaVenda = new InserirVenda();
                    NovaVenda.Pagamento = boxPag.Text;
                    NovaVenda.Valor = valor;

                    if (NovaVenda.Inserir(listaProdutos))
                    {
                        MessageBox.Show("Venda Finalizada");

                        lblTotal.Text = "R$ 00,00";
                        lblTroco.Text = "R$ 00,00";
                        boxPag.Text = " ";
                        txtValRec.Clear();
                        listaVenda.Items.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                }

            }
            catch
            {
                MessageBox.Show("Erro ao registrar venda.");
            }


        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal troco;
                troco = Convert.ToDecimal(txtValRec.Text) - totalCompra;
                lblTroco.Text = "R$" + troco.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos corretamente");
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            index OutroForm = new index();
            this.Visible = false;
            OutroForm.ShowDialog();
        }



        private void btnDesc_Click(object sender, EventArgs e)
        {


            desconto desc = new desconto(totalCompra);
            desc.ShowDialog();
            this.lblTotal.Text = "R$ " + (desc.getValorF()).ToString();
            totalCompra = Convert.ToDecimal(desc.getValorF());
        }


    }
}
