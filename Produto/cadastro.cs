using MySqlX.XDevAPI.Common;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace caixa
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();

            this.PreencherCod();
        }


        public void PreencherCod()
        {
            try
            {
                string sql = "SELECT COUNT(codigo) FROM produtos";
                Consulta con = new Consulta();
                MySqlDataReader result = con.Consultar(sql);
                result.Read();

                int valor = Convert.ToInt32(result["COUNT(codigo)"]);


                txtCod.Text = (valor + 1).ToString();

            }
            catch (Exception ex)
            {
                txtCod.Text = "";
                MessageBox.Show("Erro ao acessar o banco de dados:" + ex.Message);
            }
        }


        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCod.Text.Equals("") && !txtPreco.Text.Equals("") && !txtProd.Text.Equals(""))
                {

                    cadastroproduto cadastrar = new cadastroproduto();
                    cadastrar.Produto = txtProd.Text;
                    cadastrar.Preco = txtPreco.Text.Replace(',', '.');
                    cadastrar.Codigo = Convert.ToInt32(txtCod.Text);
                    cadastrar.Estoque = Convert.ToInt32(txtEstoque.Text);

                    if (cadastrar.CadastrarProduto())
                    {
                        MessageBox.Show($"O produto {txtProd.Text} foi cadastrado com sucesso!");

                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o produto");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
                txtProd.Clear();
                txtPreco.Clear();
                txtEstoque.Clear();
                this.PreencherCod();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: " + ex.Message);
                txtCod.Clear();
                txtProd.Clear();
                txtPreco.Clear();



            }
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            index OutroForm = new index();
            this.Visible = false;
            OutroForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}