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
    internal class InserirVenda
    {
       
        private string pagamento;
        private string valor;

       
        public string Valor { get {  return valor; } set {  valor = value; } }
        public string Pagamento { get { return pagamento; } set { pagamento = value; } }


        public bool Inserir(List<Produto> lista) {
            try
            {
                MySqlConnection conexaoMySQL = new MySqlConnection(conexaobd.conexaoBanco);
                conexaoMySQL.Open();

                string insert = $"insert into vendas (valor, formapag) values ('{valor}','{pagamento}')";

                MySqlCommand comandoSQL = conexaoMySQL.CreateCommand();
                comandoSQL.CommandText = insert;

                comandoSQL.ExecuteNonQuery();

                string lastIdQuery = "SELECT LAST_INSERT_ID() FROM vendas;";
                MySqlCommand lastIdCommand = new MySqlCommand(lastIdQuery, conexaoMySQL);
                long lastId = Convert.ToInt64(lastIdCommand.ExecuteScalar());

                Debug.WriteLine(lista[0].getQuantidade());
                
                Completar_Venda completar_Venda = new Completar_Venda();

                if (!completar_Venda.InserirVendaProduto(lista, lastId)) {
                    throw new Exception("Inserção da venda falhou.");
                    
                }
                    return true;
                
               

            }catch (Exception ex)
            {
                MessageBox.Show("O banco de dados não está ativo." + ex.Message);
                return false;

            }
        }


        


    }

}
