using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa.Produto
{
    internal class Product
    {
        private long id_produto;
        private long quantidade;

        public Product(int id_produto, int quantidade)
        {
            this.id_produto = id_produto;
            this.quantidade = quantidade;
        }


        public long getId()
        {
            return id_produto;
        }


        public long getQuantidade()
        {
            return quantidade;
        }
    }
}
