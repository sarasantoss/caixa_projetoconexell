using Google.Protobuf.Reflection;
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
    public partial class AlterarProduto : Form
    {
        public AlterarProduto(string codigo)
        {
            InitializeComponent();
            this.Request(codigo);

        }

        public void Request(string codigo)
        {
            try
            {


                string codigoR = $"SELECT codigo FROM produtos WHERE codigo = {codigo}";
                txtCod.Text = (this.GetDataReader(codigoR));

                string produtoR = $"SELECT produto FROM produtos WHERE codigo = {codigo}";
                txtProd.Text = (this.GetDataReader(produtoR));

                string precoR = $"SELECT preco FROM produtos WHERE codigo = {codigo}";
                string preco = this.GetDataReader(precoR).Replace(',', '.');
                txtPreco.Text = preco;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetDataReader(string select)
        {
            string result = string.Empty;
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco);
                MySqlConexaoBanco.Open();

                MySqlCommand ComandoSQl = MySqlConexaoBanco.CreateCommand();
                ComandoSQl.CommandText = select;

                MySqlDataReader reader = ComandoSQl.ExecuteReader();

                if (reader.Read())
                {
                    result = reader.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("falha na conexão com o banco" + ex.Message);

            }

            return result;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConexao = new MySqlConnection(conexaobd.conexaoBanco);
                mySqlConexao.Open();

                MySqlCommand ComandoSQl = mySqlConexao.CreateCommand();
                ComandoSQl.CommandText = $"UPDATE produtos SET produto = '{txtProd.Text}', preco = {txtPreco.Text} WHERE codigo = {txtCod.Text}";

                ComandoSQl.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {

        }
    }

}
