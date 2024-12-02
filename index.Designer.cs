namespace caixa
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            btnCadastro = new Button();
            btnNewVenda = new Button();
            btnProdutos = new Button();
            btnVendas = new Button();
            pictureBox1 = new PictureBox();
            lblVerso = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Anchor = AnchorStyles.Bottom;
            btnCadastro.BackColor = SystemColors.ControlText;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.FlatAppearance.BorderColor = Color.White;
            btnCadastro.FlatAppearance.BorderSize = 3;
            btnCadastro.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastro.Location = new Point(580, 438);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(255, 73);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "CADASTRAR";
            btnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnNewVenda
            // 
            btnNewVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewVenda.BackColor = Color.Yellow;
            btnNewVenda.Cursor = Cursors.Hand;
            btnNewVenda.FlatStyle = FlatStyle.Popup;
            btnNewVenda.Font = new Font("Roboto Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewVenda.ForeColor = SystemColors.ActiveCaptionText;
            btnNewVenda.Location = new Point(418, 541);
            btnNewVenda.Name = "btnNewVenda";
            btnNewVenda.Size = new Size(574, 79);
            btnNewVenda.TabIndex = 2;
            btnNewVenda.Text = "NOVA VENDA";
            btnNewVenda.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNewVenda.UseVisualStyleBackColor = false;
            btnNewVenda.Click += btnNewVenda_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdutos.BackColor = SystemColors.ActiveCaptionText;
            btnProdutos.BackgroundImageLayout = ImageLayout.None;
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnProdutos.FlatAppearance.BorderSize = 3;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnProdutos.ForeColor = SystemColors.ButtonHighlight;
            btnProdutos.Location = new Point(911, 437);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(255, 73);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "PRODUTOS";
            btnProdutos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVendas.BackColor = SystemColors.ActiveCaptionText;
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnVendas.FlatAppearance.BorderSize = 3;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Roboto Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = SystemColors.ButtonFace;
            btnVendas.Location = new Point(241, 437);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(255, 73);
            btnVendas.TabIndex = 4;
            btnVendas.Text = "VENDAS";
            btnVendas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.logocon;
            pictureBox1.Location = new Point(453, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 302);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblVerso
            // 
            lblVerso.Anchor = AnchorStyles.Bottom;
            lblVerso.AutoSize = true;
            lblVerso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerso.ForeColor = Color.White;
            lblVerso.Location = new Point(536, 643);
            lblVerso.Name = "lblVerso";
            lblVerso.Size = new Size(339, 28);
            lblVerso.TabIndex = 6;
            lblVerso.Text = "\"...fazei tudo para glória de Deus.\"";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(645, 671);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 7;
            label1.Text = "I Cor 10:31 c";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1411, 760);
            Controls.Add(label1);
            Controls.Add(lblVerso);
            Controls.Add(pictureBox1);
            Controls.Add(btnVendas);
            Controls.Add(btnProdutos);
            Controls.Add(btnNewVenda);
            Controls.Add(btnCadastro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina Inicial";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastro;
        private Button btnNewVenda;
        private Button btnProdutos;
        private Button btnVendas;
        private PictureBox pictureBox1;
        private Label lblVerso;
        private Label label1;
    }
}