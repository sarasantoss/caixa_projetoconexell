namespace caixa
{
    partial class painelVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(painelVendas));
            label1 = new Label();
            dtVendas = new DataGridView();
            label5 = new Label();
            lblTotal = new Label();
            btnInicio = new Button();
            btnConsultar = new Button();
            bindingSource1 = new BindingSource(components);
            lblData = new Label();
            label2 = new Label();
            formaPag = new ComboBox();
            data1 = new DateTimePicker();
            data2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dtVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(531, 25);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 0;
            label1.Text = "HISTÓRICO DE VENDAS";
            // 
            // dtVendas
            // 
            dtVendas.AllowUserToOrderColumns = true;
            dtVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtVendas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtVendas.BackgroundColor = SystemColors.ButtonHighlight;
            dtVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVendas.GridColor = SystemColors.ControlText;
            dtVendas.Location = new Point(24, 244);
            dtVendas.Name = "dtVendas";
            dtVendas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dtVendas.RowTemplate.Height = 29;
            dtVendas.Size = new Size(1359, 445);
            dtVendas.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(1187, 25);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 6;
            label5.Text = "Total de Entradas";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1237, 62);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 28);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "R$ 00,00";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Black;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 2;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImeMode = ImeMode.NoControl;
            btnInicio.Location = new Point(12, 11);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(73, 70);
            btnInicio.TabIndex = 16;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Black;
            btnConsultar.BackgroundImage = Properties.Resources.images1;
            btnConsultar.BackgroundImageLayout = ImageLayout.Center;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.ImeMode = ImeMode.NoControl;
            btnConsultar.Location = new Point(647, 183);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(73, 40);
            btnConsultar.TabIndex = 17;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(16, 147);
            lblData.Name = "lblData";
            lblData.Size = new Size(162, 28);
            lblData.TabIndex = 18;
            lblData.Text = "Data da Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(386, 147);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 19;
            label2.Text = "Pagamento";
            // 
            // formaPag
            // 
            formaPag.FormattingEnabled = true;
            formaPag.Items.AddRange(new object[] { "TODAS", "DINHEIRO", "CRÉDITO", "DÉBITO", "PIX" });
            formaPag.Location = new Point(386, 187);
            formaPag.Name = "formaPag";
            formaPag.Size = new Size(236, 28);
            formaPag.TabIndex = 20;
            // 
            // data1
            // 
            data1.Format = DateTimePickerFormat.Short;
            data1.Location = new Point(58, 188);
            data1.Name = "data1";
            data1.Size = new Size(125, 27);
            data1.TabIndex = 21;
            data1.Value = new DateTime(2024, 4, 30, 0, 0, 0, 0);
            // 
            // data2
            // 
            data2.Format = DateTimePickerFormat.Short;
            data2.Location = new Point(224, 189);
            data2.Name = "data2";
            data2.Size = new Size(125, 27);
            data2.TabIndex = 22;
            data2.Value = new DateTime(2024, 6, 18, 22, 24, 52, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 188);
            label3.Name = "label3";
            label3.Size = new Size(40, 28);
            label3.TabIndex = 23;
            label3.Text = "De";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(189, 188);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 24;
            label4.Text = "à";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.BackColor = Color.Black;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.Yellow;
            btnExport.ImeMode = ImeMode.NoControl;
            btnExport.Location = new Point(1235, 709);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(146, 39);
            btnExport.TabIndex = 25;
            btnExport.Text = "EXPORTAR";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // painelVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1411, 760);
            Controls.Add(btnExport);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(data2);
            Controls.Add(data1);
            Controls.Add(formaPag);
            Controls.Add(label2);
            Controls.Add(lblData);
            Controls.Add(btnConsultar);
            Controls.Add(btnInicio);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(dtVendas);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "painelVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)dtVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dtVendas;
        private Label label5;
        private Label lblTotal;
        private Button btnInicio;
        private Button btnConsultar;
        private BindingSource bindingSource1;
        private Label lblData;
        private Label label2;
        private ComboBox formaPag;
        private DateTimePicker data1;
        private DateTimePicker data2;
        private Label label3;
        private Label label4;
        private SaveFileDialog saveFileDialog1;
        private Button btnExport;
    }
}