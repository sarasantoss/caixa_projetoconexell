namespace caixa
{
    partial class desconto
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
            label1 = new Label();
            label2 = new Label();
            txtValor = new TextBox();
            txtPerc = new TextBox();
            btnAplicar = new Button();
            txtValorF = new TextBox();
            lblValorF = new Label();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(68, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "VALOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(68, 125);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 1;
            label2.Text = "PERCENTUAL";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(195, 64);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(160, 26);
            txtValor.TabIndex = 2;
            // 
            // txtPerc
            // 
            txtPerc.Location = new Point(195, 125);
            txtPerc.Name = "txtPerc";
            txtPerc.Size = new Size(160, 26);
            txtPerc.TabIndex = 3;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(278, 340);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 29);
            btnAplicar.TabIndex = 4;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // txtValorF
            // 
            txtValorF.Location = new Point(69, 280);
            txtValorF.Name = "txtValorF";
            txtValorF.Size = new Size(160, 26);
            txtValorF.TabIndex = 5;
            // 
            // lblValorF
            // 
            lblValorF.AutoSize = true;
            lblValorF.ForeColor = SystemColors.ButtonHighlight;
            lblValorF.Location = new Point(69, 243);
            lblValorF.Name = "lblValorF";
            lblValorF.Size = new Size(101, 18);
            lblValorF.TabIndex = 6;
            lblValorF.Text = "VALOR FINAL";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Black;
            btnPesquisar.BackgroundImage = Properties.Resources.images;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.Location = new Point(195, 181);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 42);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "+";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // desconto
            // 
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(421, 404);
            Controls.Add(btnPesquisar);
            Controls.Add(lblValorF);
            Controls.Add(txtValorF);
            Controls.Add(btnAplicar);
            Controls.Add(txtPerc);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Roboto Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "desconto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Desconto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private TextBox txtPerc;
        private Button btnAplicar;
        private TextBox txtValorF;
        private Label lblValorF;
        private Button btnPesquisar;
    }
}