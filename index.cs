using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    public partial class index : Form
    {

        public index()
        {
            InitializeComponent();
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {


            Cadastro newWindow = new Cadastro();
            this.Visible = false;
            newWindow.ShowDialog();


        }

        private void btnNewVenda_Click(object sender, EventArgs e)
        {

            Venda newWindow = new Venda();
            this.Visible = false;
            newWindow.ShowDialog();

        }


        private void btnVendas_Click(object sender, EventArgs e)
        {
            painelVendas newWindow = new painelVendas();
            this.Visible = false;
            newWindow.Call();
            newWindow.ShowDialog();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            PainelProdutos newWindow = new PainelProdutos();
            this.Visible = false;
            newWindow.Call();
            newWindow.ShowDialog();
        }


    }
}