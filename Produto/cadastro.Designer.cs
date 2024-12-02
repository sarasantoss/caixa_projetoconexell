namespace caixa
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            label1 = new Label();
            lblCod = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCad = new Button();
            txtCod = new TextBox();
            txtProd = new TextBox();
            txtPreco = new TextBox();
            btnInicio = new Button();
            lblEstoque = new Label();
            txtEstoque = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(514, 33);
            label1.Name = "label1";
            label1.Size = new Size(381, 44);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = Color.White;
            lblCod.Location = new Point(79, 138);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(358, 41);
            lblCod.TabIndex = 1;
            lblCod.Text = "CÓDIGO DO PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 241);
            label2.Name = "label2";
            label2.Size = new Size(174, 41);
            label2.TabIndex = 2;
            label2.Text = "PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(79, 342);
            label3.Name = "label3";
            label3.Size = new Size(126, 41);
            label3.TabIndex = 3;
            label3.Text = "PREÇO";
            // 
            // btnCad
            // 
            btnCad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCad.AutoSize = true;
            btnCad.BackColor = SystemColors.InactiveCaptionText;
            btnCad.Cursor = Cursors.Hand;
            btnCad.FlatAppearance.BorderSize = 2;
            btnCad.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnCad.FlatStyle = FlatStyle.Flat;
            btnCad.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnCad.ForeColor = Color.White;
            btnCad.Location = new Point(1103, 640);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(239, 74);
            btnCad.TabIndex = 4;
            btnCad.Text = "CADASTRAR";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCod.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtCod.Location = new Point(915, 151);
            txtCod.Name = "txtCod";
            txtCod.RightToLeft = RightToLeft.No;
            txtCod.Size = new Size(427, 47);
            txtCod.TabIndex = 5;
            txtCod.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProd
            // 
            txtProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtProd.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtProd.Location = new Point(915, 241);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(427, 47);
            txtProd.TabIndex = 1;
            txtProd.Text = " ";
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPreco.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtPreco.Location = new Point(915, 342);
            txtPreco.Name = "txtPreco";
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.Size = new Size(427, 47);
            txtPreco.TabIndex = 2;
            txtPreco.TextAlign = HorizontalAlignment.Right;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInicio.BackColor = Color.Black;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 2;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImeMode = ImeMode.NoControl;
            btnInicio.Location = new Point(79, 645);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(73, 70);
            btnInicio.TabIndex = 5;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstoque.Location = new Point(79, 433);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(167, 41);
            lblEstoque.TabIndex = 19;
            lblEstoque.Text = "ESTOQUE";
            lblEstoque.Click += label4_Click;
            // 
            // txtEstoque
            // 
            txtEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEstoque.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtEstoque.Location = new Point(915, 433);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.RightToLeft = RightToLeft.No;
            txtEstoque.Size = new Size(427, 47);
            txtEstoque.TabIndex = 3;
            txtEstoque.TextAlign = HorizontalAlignment.Right;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(1411, 760);
            Controls.Add(txtEstoque);
            Controls.Add(lblEstoque);
            Controls.Add(btnInicio);
            Controls.Add(txtPreco);
            Controls.Add(txtProd);
            Controls.Add(txtCod);
            Controls.Add(btnCad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCod);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cadastro";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCod;
        private Label label2;
        private Label label3;
        private Button btnCad;
        private TextBox txtCod;
        private TextBox txtProd;
        private TextBox txtPreco;
        private Button btnInicio;
        private Label lblEstoque;
        private TextBox txtEstoque;
    }
}