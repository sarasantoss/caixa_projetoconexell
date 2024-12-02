using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa
{
    internal class Consulta
    {
        public MySqlDataReader Consultar(string comando) {

            MySqlConnection mySqlConexao = new MySqlConnection(conexaobd.conexaoBanco);
            mySqlConexao.Open();

            MySqlCommand ComandoSQl = mySqlConexao.CreateCommand();
            ComandoSQl.CommandText = comando;

            MySqlDataReader reader = ComandoSQl.ExecuteReader();

            return reader;
        }

        
    }
}
