namespace caixa
{
    partial class AlterarProduto
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
            btnSubmit = new Button();
            txtCod = new TextBox();
            txtProd = new TextBox();
            txtPreco = new TextBox();
            lblCod = new Label();
            lblProd = new Label();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(196, 162);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 33);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "ALTERAR";
            btnSubmit.TextAlign = ContentAlignment.TopCenter;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(36, 90);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(74, 28);
            txtCod.TabIndex = 1;
            // 
            // txtProd
            // 
            txtProd.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtProd.Location = new Point(128, 90);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(215, 28);
            txtProd.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPreco.Location = new Point(358, 90);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 28);
            txtPreco.TabIndex = 1;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCod.ForeColor = SystemColors.ButtonHighlight;
            lblCod.Location = new Point(36, 57);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(40, 20);
            lblCod.TabIndex = 2;
            lblCod.Text = "Cod";
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProd.ForeColor = SystemColors.ButtonHighlight;
            lblProd.Location = new Point(128, 57);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(72, 20);
            lblProd.TabIndex = 3;
            lblProd.Text = "Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.ForeColor = SystemColors.ButtonHighlight;
            lblPreco.Location = new Point(358, 57);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(54, 20);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // AlterarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(527, 258);
            Controls.Add(lblPreco);
            Controls.Add(lblProd);
            Controls.Add(lblCod);
            Controls.Add(txtPreco);
            Controls.Add(txtProd);
            Controls.Add(txtCod);
            Controls.Add(btnSubmit);
            Name = "AlterarProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ALTERAÇÃO DE PRODUTO";
            Load += AlterarProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtCod;
        private TextBox txtProd;
        private TextBox txtPreco;
        private Label lblCod;
        private Label lblProd;
        private Label lblPreco;
    }
}