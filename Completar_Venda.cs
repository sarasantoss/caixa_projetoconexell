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
    internal class Completar_Venda
    {
        public bool InserirVendaProduto(List<Produto> lista, long id_venda)
        {
            try
            {
                MySqlConnection conexaoMySQL = new MySqlConnection(conexaobd.conexaoBanco);
                conexaoMySQL.Open();

                string insert;
                for (int i = 0; i < lista.Count; i++)
                { 
                    insert = $"insert into venda_produto(id_venda, id_produto, quantidade) values({id_venda},{lista[i].getId()},{lista[i].getQuantidade()})";

                    MySqlCommand comandoSQL = conexaoMySQL.CreateCommand();
                    comandoSQL.CommandText = insert;

                    comandoSQL.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
    }
}
