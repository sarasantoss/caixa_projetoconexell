namespace caixa
{
    partial class PainelProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelProdutos));
            dtProdutos = new DataGridView();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            txtCod = new TextBox();
            txtName = new TextBox();
            lblCod = new Label();
            lblName = new Label();
            bindingSource1 = new BindingSource(components);
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dtProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dtProdutos
            // 
            dtProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtProdutos.BackgroundColor = SystemColors.Control;
            dtProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProdutos.Location = new Point(44, 100);
            dtProdutos.Name = "dtProdutos";
            dtProdutos.ReadOnly = true;
            dtProdutos.RowHeadersWidth = 51;
            dtProdutos.RowTemplate.Height = 29;
            dtProdutos.Size = new Size(1333, 570);
            dtProdutos.TabIndex = 0;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.ForeColor = SystemColors.ButtonHighlight;
            btnAlterar.Location = new Point(1214, 687);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(151, 44);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = Color.Black;
            btnLocalizar.BackgroundImage = Properties.Resources.images;
            btnLocalizar.BackgroundImageLayout = ImageLayout.Center;
            btnLocalizar.Cursor = Cursors.Hand;
            btnLocalizar.FlatAppearance.BorderSize = 3;
            btnLocalizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLocalizar.FlatStyle = FlatStyle.Flat;
            btnLocalizar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocalizar.ForeColor = SystemColors.Control;
            btnLocalizar.Location = new Point(391, 50);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(50, 34);
            btnLocalizar.TabIndex = 3;
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(44, 50);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(94, 34);
            txtCod.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(144, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 34);
            txtName.TabIndex = 5;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCod.ForeColor = SystemColors.ControlLightLight;
            lblCod.Location = new Point(44, 27);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(43, 20);
            lblCod.TabIndex = 6;
            lblCod.Text = "COD";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(144, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 20);
            lblName.TabIndex = 7;
            lblName.Text = "PRODUTO";
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
            btnInicio.Location = new Point(44, 676);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(73, 70);
            btnInicio.TabIndex = 17;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // PainelProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1411, 760);
            Controls.Add(btnInicio);
            Controls.Add(lblName);
            Controls.Add(lblCod);
            Controls.Add(txtName);
            Controls.Add(txtCod);
            Controls.Add(btnLocalizar);
            Controls.Add(btnAlterar);
            Controls.Add(dtProdutos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PainelProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += PainelProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dtProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtProdutos;
        private Button btnAlterar;
        private Button btnLocalizar;
        private TextBox txtCod;
        private TextBox txtName;
        private Label lblCod;
        private Label lblName;
        private BindingSource bindingSource1;
        private Button btnInicio;
    }
}