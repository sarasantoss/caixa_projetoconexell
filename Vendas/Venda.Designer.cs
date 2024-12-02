namespace caixa
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            lblCod = new Label();
            txtPro = new TextBox();
            btnAdicionar = new Button();
            listaVenda = new ListView();
            txtQuant = new TextBox();
            label1 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            txtValRec = new TextBox();
            lbl4 = new Label();
            lblTroco = new Label();
            btnFinalizar = new Button();
            btnFinal = new Button();
            lbl3 = new Label();
            boxPag = new ComboBox();
            lblTotal = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtCodPro = new TextBox();
            btnDesc = new Button();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // lblCod
            // 
            resources.ApplyResources(lblCod, "lblCod");
            lblCod.FlatStyle = FlatStyle.Flat;
            lblCod.Name = "lblCod";
            // 
            // txtPro
            // 
            resources.ApplyResources(txtPro, "txtPro");
            txtPro.BackColor = Color.MintCream;
            txtPro.BorderStyle = BorderStyle.None;
            txtPro.Cursor = Cursors.IBeam;
            txtPro.Name = "txtPro";
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(btnAdicionar, "btnAdicionar");
            btnAdicionar.BackColor = Color.Black;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderColor = Color.White;
            btnAdicionar.FlatAppearance.BorderSize = 2;
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaVenda
            // 
            resources.ApplyResources(listaVenda, "listaVenda");
            listaVenda.BackColor = SystemColors.ControlLightLight;
            listaVenda.FullRowSelect = true;
            listaVenda.Items.AddRange(new ListViewItem[] { (ListViewItem)resources.GetObject("listaVenda.Items") });
            listaVenda.Name = "listaVenda";
            listaVenda.UseCompatibleStateImageBehavior = false;
            listaVenda.View = View.List;
            // 
            // txtQuant
            // 
            resources.ApplyResources(txtQuant, "txtQuant");
            txtQuant.BackColor = Color.MintCream;
            txtQuant.BorderStyle = BorderStyle.None;
            txtQuant.Cursor = Cursors.IBeam;
            txtQuant.Name = "txtQuant";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Name = "label1";
            // 
            // lbl1
            // 
            resources.ApplyResources(lbl1, "lbl1");
            lbl1.Name = "lbl1";
            // 
            // lbl2
            // 
            resources.ApplyResources(lbl2, "lbl2");
            lbl2.Name = "lbl2";
            // 
            // txtValRec
            // 
            resources.ApplyResources(txtValRec, "txtValRec");
            txtValRec.BackColor = Color.MintCream;
            txtValRec.BorderStyle = BorderStyle.None;
            txtValRec.Cursor = Cursors.IBeam;
            txtValRec.Name = "txtValRec";
            // 
            // lbl4
            // 
            resources.ApplyResources(lbl4, "lbl4");
            lbl4.Name = "lbl4";
            // 
            // lblTroco
            // 
            resources.ApplyResources(lblTroco, "lblTroco");
            lblTroco.Name = "lblTroco";
            // 
            // btnFinalizar
            // 
            resources.ApplyResources(btnFinalizar, "btnFinalizar");
            btnFinalizar.BackColor = SystemColors.MenuText;
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 3;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.YellowGreen;
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnFinal
            // 
            resources.ApplyResources(btnFinal, "btnFinal");
            btnFinal.BackColor = Color.Firebrick;
            btnFinal.Cursor = Cursors.Hand;
            btnFinal.FlatAppearance.BorderSize = 2;
            btnFinal.ForeColor = Color.Transparent;
            btnFinal.Name = "btnFinal";
            btnFinal.UseVisualStyleBackColor = false;
            btnFinal.Click += btnFinal_Click;
            // 
            // lbl3
            // 
            resources.ApplyResources(lbl3, "lbl3");
            lbl3.Name = "lbl3";
            // 
            // boxPag
            // 
            resources.ApplyResources(boxPag, "boxPag");
            boxPag.FormattingEnabled = true;
            boxPag.Items.AddRange(new object[] { resources.GetString("boxPag.Items"), resources.GetString("boxPag.Items1"), resources.GetString("boxPag.Items2"), resources.GetString("boxPag.Items3") });
            boxPag.Name = "boxPag";
            // 
            // lblTotal
            // 
            resources.ApplyResources(lblTotal, "lblTotal");
            lblTotal.Name = "lblTotal";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonShadow;
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.FlatStyle = FlatStyle.Flat;
            label2.Name = "label2";
            // 
            // txtCodPro
            // 
            resources.ApplyResources(txtCodPro, "txtCodPro");
            txtCodPro.BackColor = Color.MintCream;
            txtCodPro.BorderStyle = BorderStyle.None;
            txtCodPro.Cursor = Cursors.IBeam;
            txtCodPro.Name = "txtCodPro";
            // 
            // btnDesc
            // 
            resources.ApplyResources(btnDesc, "btnDesc");
            btnDesc.BackColor = SystemColors.ScrollBar;
            btnDesc.Cursor = Cursors.Hand;
            btnDesc.FlatAppearance.BorderColor = Color.Black;
            btnDesc.FlatAppearance.BorderSize = 3;
            btnDesc.FlatAppearance.MouseDownBackColor = Color.YellowGreen;
            btnDesc.ForeColor = Color.Black;
            btnDesc.Name = "btnDesc";
            btnDesc.UseVisualStyleBackColor = false;
            btnDesc.Click += btnDesc_Click;
            // 
            // btnInicio
            // 
            resources.ApplyResources(btnInicio, "btnInicio");
            btnInicio.BackColor = Color.Black;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 2;
            btnInicio.ForeColor = SystemColors.ButtonHighlight;
            btnInicio.Name = "btnInicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // Venda
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(btnDesc);
            Controls.Add(txtCodPro);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTotal);
            Controls.Add(boxPag);
            Controls.Add(lbl3);
            Controls.Add(btnInicio);
            Controls.Add(btnFinal);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTroco);
            Controls.Add(lbl4);
            Controls.Add(txtValRec);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Controls.Add(txtQuant);
            Controls.Add(listaVenda);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPro);
            Controls.Add(lblCod);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCod;
        private TextBox txtPro;
        private Button btnAdicionar;
        private ListView listaVenda;
        private TextBox txtQuant;
        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtValRec;
        private Label lbl4;
        private Label lblTroco;
        private Button btnFinalizar;
        private Button btnFinal;
        private Label lblTotal;
        private Label lbl3;
        private ComboBox boxPag;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtCodPro;
        private Button btnDesc;
        private Button btnInicio;
    }
}