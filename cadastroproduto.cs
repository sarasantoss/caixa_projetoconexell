using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa
{
    internal class cadastroproduto
    {
       
        private string produto;
        private int codigo;
        private string preco;
        private int estoque;

       

        public string Produto 
        {
            get { return produto; }
            set { produto = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public bool CadastrarProduto()
        {
            try
            {
                MySqlConnection mysqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco);
                mysqlConexaoBanco.Open();

                string insert = $"insert into produtos (codigo,produto,preco,estoque) values ('{codigo}', '{produto}', '{preco}','{estoque}') ";

                MySqlCommand ComandoSql = mysqlConexaoBanco.CreateCommand();
                ComandoSql.CommandText = insert;

                ComandoSql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("O cadastro do produto falhou" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader SelecionarProduto()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco);
                MySqlConexaoBanco.Open();

                string select = $"select produto, preco from produtos where produto like '%{produto}%' ";

                MySqlCommand ComandoSQl = MySqlConexaoBanco.CreateCommand();
                ComandoSQl.CommandText = select;

                MySqlDataReader reader = ComandoSQl.ExecuteReader();
        
                return reader;
                

            }catch(Exception ex)
            {
                MessageBox.Show($"Erro no código SQL - {ex.Message} ");
                return null;
            }
        }

        public MySqlDataReader SelecionarProdutoCod()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco);
                MySqlConexaoBanco.Open();

                string select = $"select produto, preco from produtos where codigo = '{Codigo}' ";

                MySqlCommand ComandoSQl = MySqlConexaoBanco.CreateCommand();
                ComandoSQl.CommandText = select;

                MySqlDataReader reader = ComandoSQl.ExecuteReader();

                return reader;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no código SQL - {ex.Message} ");
                return null;
            }
        }
    }
}
