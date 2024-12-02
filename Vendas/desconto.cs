using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    public partial class desconto : Form
    {
        decimal valor, valorF;

        public desconto(decimal valor)
        {
            InitializeComponent();
            this.setValor(valor);
            this.setValorF(valor);

        }

        public void setValor(decimal Valor)
        {
            this.valor = Valor;
        }


        public decimal getValor()
        {
            return this.valor;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.setValorF(this.getValor());
            MessageBox.Show($"O valor da venda foi alterado para {this.getValor()}");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            decimal valorF = this.getValor(), valor = this.getValor();


            if (txtValor.Text == "" && txtPerc.Text != "")
            {
                decimal Percentual = Convert.ToDecimal(txtPerc.Text);

                valorF = valor - (Percentual / 100 * valor);

                txtValorF.Text = valorF.ToString();

            }
            if (txtValor.Text != "" && txtPerc.Text == "")
            {
                decimal valorR = Convert.ToDecimal(txtValor.Text);

                valorF = valor - valorR;

                txtValorF.Text = valorF.ToString();
            }
            else
            {
                MessageBox.Show("Preencha algum valor!");
            }

            this.setValor(valorF);
        }

        public decimal getValorF()
        {
            return this.valorF;
        }

        public void setValorF(decimal valor)
        {
            this.valorF = valor;
        }
    }

}
