using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Linq.Expressions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.CodeDom;
using System.Windows.Forms.Design;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace caixa
{
    public partial class painelVendas : Form
    {

        private string queryActDate = "SELECT dataehora AS DATA, valor AS VALOR, formapag AS PAGAMENTO  FROM vendas WHERE DATE_FORMAT(dataehora, '%Y-%m-%d') = CURDATE();";
        private string querySum = "SELECT SUM(valor) FROM vendas WHERE DATE_FORMAT(dataehora, '%Y-%m-%d') = CURDATE();";
        public painelVendas()
        {
            InitializeComponent();
            data1.Value = DateTime.Today;
            data2.Value = DateTime.Now;
        }



        public void Call()
        {
            this.button(queryActDate, querySum);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            index OutroForm = new index();
            this.Visible = false;
            OutroForm.ShowDialog();
        }

        private void button(string sqlQuery, string sqlQuerySum)
        {
            try
            {
                // Conexão com o BD
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco))
                {
                    MySqlConexaoBanco.Open();


                    // Cria um novo adaptador de dados baseado no comando especificado.
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, MySqlConexaoBanco))
                    {
                        // Preenche uma nova tabela de dados e a vincula ao BindingSource.
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bindingSource1.DataSource = table;
                        dtVendas.DataSource = bindingSource1;

                        // Redimensiona as colunas para se ajustarem ao conteúdo
                        dtVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                        this.CallFill(sqlQuerySum);


                    }

                    FlowLayoutPanel panel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Top,
                        AutoSize = true
                    };
                }
            }
            catch (Exception ex)
            {
                // Exibe o erro real que ocorreu
                MessageBox.Show("Erro ao acessar os dados do banco: " + ex.Message);
            }

        }

        public MySqlDataReader FillTotal(string sqlQuerySum)
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(conexaobd.conexaoBanco);
                MySqlConexaoBanco.Open();


                MySqlCommand ComandoSQl = MySqlConexaoBanco.CreateCommand();
                ComandoSQl.CommandText = sqlQuerySum;

                MySqlDataReader reader = ComandoSQl.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void CallFill(string sqlQuerySum)
        {
            string total;
            MySqlDataReader reader = this.FillTotal(sqlQuerySum);

            try
            {
                if (reader != null)
                {
                    if (reader.HasRows)
                    {

                        reader.Read();

                        total = reader.GetString(0);
                        lblTotal.Text = "R$ " + total;
                    }

                }
            }
            catch
            {
                lblTotal.Text = "R$ 00,00";
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int day1, mounth1, year1, day2, mounth2, year2;
            string queryPagAndDate, querySum;

            DateTime selectedDate = data1.Value;
            day1 = selectedDate.Day;
            mounth1 = selectedDate.Month;
            year1 = selectedDate.Year;

            DateTime selectedDate2 = data2.Value;
            day2 = selectedDate2.Day;
            mounth2 = selectedDate2.Month;
            year2 = selectedDate2.Year;

            if (formaPag.Text == "" || formaPag.Text == "TODAS")
            {
                queryPagAndDate = $"SELECT dataehora AS DATA, valor AS VALOR, formapag AS PAGAMENTO FROM vendas WHERE dataehora  BETWEEN '{year1}-{mounth1}-{day1} 00:00:00' AND '{year2}-{mounth2}-{day2} 23:59:59' AND formapag  IN('DINHEIRO','CRÉDITO','DÉBITO','PIX');";
                querySum = $"SELECT SUM(valor) FROM vendas WHERE dataehora  BETWEEN '{year1}-{mounth1}-{day1} 00:00:00' AND '{year2}-{mounth2}-{day2} 23:59:59' AND formapag = 'DINHEIRO' OR 'CRÉDITO' OR 'DÉBITO' OR 'PIX';";
            }
            else
            {

                queryPagAndDate = $"SELECT dataehora AS DATA, valor AS VALOR, formapag AS PAGAMENTO FROM vendas WHERE dataehora  BETWEEN '{year1}-{mounth1}-{day1} 00:00:00' AND '{year2}-{mounth2}-{day2} 23:59:59' AND formapag = '{formaPag.Text}';";
                querySum = $"SELECT SUM(valor) FROM vendas WHERE dataehora  BETWEEN '{year1}-{mounth1}-{day1} 00:00:00' AND '{year2}-{mounth2}-{day2} 23:59:59' AND formapag = '{formaPag.Text}';";
            }



            this.button(queryPagAndDate, querySum);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string data = DateTime.Today.ToString();
            if (dtVendas.Columns.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "relatorio_" + data + ".pdf";

                bool fError = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);

                        }
                        catch (Exception ex)
                        {
                            fError = true;
                            MessageBox.Show("Não foi possível salvar o arquivo " + ex.Message);
                        }
                    }
                    if (!fError)
                    {
                        try
                        {
                            PdfPTable pdf = new PdfPTable(dtVendas.Columns.Count);
                            pdf.DefaultCell.Padding = 3;
                            pdf.WidthPercentage = 100;
                            pdf.HorizontalAlignment = Element.ALIGN_LEFT;



                            foreach (DataGridViewColumn column in dtVendas.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                                pdf.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtVendas.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellFill = cell.Value?.ToString() ?? "";
                                    pdf.AddCell(cellFill);
                                }
                            }

                            using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            {

                                string date1 = data1.Text;
                                string date2 = data2.Text;
                                string total = lblTotal.Text;
                                Document pdfDoc = new Document(PageSize.A4, 20f, 30f, 30f, 20f);
                                PdfWriter.GetInstance(pdfDoc, stream);

                                // iTextSharp.text.Font fonteNegrito = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                                BaseColor corCinza = BaseColor.GRAY;
                                Phrase titulo = new Phrase($"Relatório de Vendas de {date1} à {date2}", FontFactory.GetFont(FontFactory.HELVETICA, 14, corCinza));
                                Phrase valorFinal = new Phrase($"Total Recebido: R${total}", FontFactory.GetFont(FontFactory.HELVETICA, 14));

                                pdfDoc.Open();
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(pdf);
                                pdfDoc.Add(valorFinal);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Documento salvo com sucesso!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao exportar documento. " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Falha ao exportar arquivo.", "Info");
            }
        }
    }

}
