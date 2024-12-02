using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa
{
    static class conexaobd
    {
        private const string servidor = "45.226.79.1";
        private const string porta = "7010";
        private const string bancoDados = "conexell";
        private const string usuario = "sara";
        private const string senha = "sara2004";

        static public string conexaoBanco = $"server={servidor};port={porta};user id={usuario};database={bancoDados};password={senha}";

    }
}
