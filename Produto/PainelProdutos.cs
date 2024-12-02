using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    public partial class PainelProdutos : Form
    {
        public PainelProdutos()
        {
            InitializeComponent();

        }

        public void Call()
        {
            string sqlQuery = "SELECT codigo AS CODIGO, produto AS PRODUTO, preco AS PRECO, estoque AS ESTOQUE FROM produtos;";
            this.SearchData(sqlQuery);
        }

        private void SearchData(string sqlQuery)
        {
            try
            {
                using (MySqlConnection MysqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco))
                {

                    MysqlConexaoBanco.Open();

                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, MysqlConexaoBanco))
                    {

                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bindingSource1.DataSource = table;
                        dtProdutos.DataSource = bindingSource1;

                        // Ajustar o tamanho das colunas automaticamente ao conteúdo


                        this.Fill(sqlQuery);
                        dtProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    FlowLayoutPanel panel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Top,
                        AutoSize = true

                    };


                }
            }
            catch (Exception ex)
            {
                // Exibe o erro real que ocorreu
                MessageBox.Show("Erro ao acessar os dados do banco: " + ex.Message);
            }
        }

        public MySqlDataReader Fill(string ComandoSql)
        {
            try
            {
                MySqlConnection mySqlConexao = new MySqlConnection(conexaobd.conexaoBanco);
                mySqlConexao.Open();

                MySqlCommand ComandoSQl = mySqlConexao.CreateCommand();
                ComandoSQl.CommandText = ComandoSql;

                MySqlDataReader reader = ComandoSQl.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            string sqlQuery, prod = txtName.Text, cod = txtCod.Text;
            try
            {
                if (txtCod.Text.Equals("") && !txtName.Text.Equals(""))
                {
                    sqlQuery = $"SELECT codigo AS CODIGO, produto AS PRODUTO, preco AS PRECO FROM produtos WHERE produto = {prod}";
                    this.SearchData(sqlQuery);
                }
                else if (txtName.Text.Equals("") && !txtCod.Text.Equals(""))
                {
                    sqlQuery = $"SELECT codigo AS CODIGO, produto AS PRODUTO, preco AS PRECO FROM produtos WHERE codigo = {cod}";
                    this.SearchData(sqlQuery);
                }


            }
            catch 
            {
                MessageBox.Show("Preencha os campos de pesquisa corretamente");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                string cell = dtProdutos.CurrentCell.Value.ToString();
                AlterarProduto PopUp = new AlterarProduto(cell);
                PopUp.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pergunta = "Tem certeza que deseja excluir este produto?";
            string caption = "Excluindo produto";
            var resposta = MessageBox.Show(pergunta, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            string codigo = dtProdutos.CurrentCell.Value.ToString();

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection mySqlConexao = new MySqlConnection(conexaobd.conexaoBanco);
                    mySqlConexao.Open();

                    MySqlCommand ComandoSQl = mySqlConexao.CreateCommand();
                    ComandoSQl.CommandText = $"DELETE FROM produtos WHERE codigo = {codigo}";


                    ComandoSQl.ExecuteNonQuery();

                    MessageBox.Show("Produto deletado com sucesso!");
                    this.Call();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar produto " + ex.Message);
                }

            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            index OutroForm = new index();
            this.Visible = false;
            OutroForm.ShowDialog();
        }

        private void PainelProdutos_Load(object sender, EventArgs e)
        {

        }
    }


}