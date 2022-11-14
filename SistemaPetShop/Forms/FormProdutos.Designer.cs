namespace SistemaPetShop.Forms
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.pnlCadProd = new System.Windows.Forms.Panel();
            this.cbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPVendaProd = new System.Windows.Forms.TextBox();
            this.lblPVendaProd = new System.Windows.Forms.Label();
            this.txtPCustoProd = new System.Windows.Forms.TextBox();
            this.txtMarcaProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.lblPCustoProd = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.pnlHeaderProd = new System.Windows.Forms.Panel();
            this.imgCadProd = new System.Windows.Forms.PictureBox();
            this.lblCadProd = new System.Windows.Forms.Label();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.pnlViewProd = new System.Windows.Forms.Panel();
            this.imgMarcador = new System.Windows.Forms.PictureBox();
            this.imgBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.pnlCadProd.SuspendLayout();
            this.pnlHeaderProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadProd)).BeginInit();
            this.pnlViewProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadProd
            // 
            this.pnlCadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlCadProd.Controls.Add(this.cbCategoriaProd);
            this.pnlCadProd.Controls.Add(this.btnConfirmar);
            this.pnlCadProd.Controls.Add(this.btnCancelar);
            this.pnlCadProd.Controls.Add(this.txtPVendaProd);
            this.pnlCadProd.Controls.Add(this.lblPVendaProd);
            this.pnlCadProd.Controls.Add(this.txtPCustoProd);
            this.pnlCadProd.Controls.Add(this.txtMarcaProd);
            this.pnlCadProd.Controls.Add(this.txtNomeProd);
            this.pnlCadProd.Controls.Add(this.lblMarcaProd);
            this.pnlCadProd.Controls.Add(this.lblCategoriaProd);
            this.pnlCadProd.Controls.Add(this.lblPCustoProd);
            this.pnlCadProd.Controls.Add(this.lblNomeProd);
            this.pnlCadProd.Controls.Add(this.pnlHeaderProd);
            this.pnlCadProd.Controls.Add(this.pnlDivisao);
            this.pnlCadProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadProd.Location = new System.Drawing.Point(0, 0);
            this.pnlCadProd.Name = "pnlCadProd";
            this.pnlCadProd.Size = new System.Drawing.Size(346, 450);
            this.pnlCadProd.TabIndex = 0;
            // 
            // cbCategoriaProd
            // 
            this.cbCategoriaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoriaProd.FormattingEnabled = true;
            this.cbCategoriaProd.Location = new System.Drawing.Point(117, 192);
            this.cbCategoriaProd.Name = "cbCategoriaProd";
            this.cbCategoriaProd.Size = new System.Drawing.Size(198, 23);
            this.cbCategoriaProd.TabIndex = 47;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(209, 385);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 40);
            this.btnConfirmar.TabIndex = 45;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(109, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 40);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtPVendaProd
            // 
            this.txtPVendaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPVendaProd.Location = new System.Drawing.Point(117, 252);
            this.txtPVendaProd.Name = "txtPVendaProd";
            this.txtPVendaProd.PlaceholderText = "Preço de Venda";
            this.txtPVendaProd.Size = new System.Drawing.Size(198, 23);
            this.txtPVendaProd.TabIndex = 44;
            // 
            // lblPVendaProd
            // 
            this.lblPVendaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPVendaProd.AutoSize = true;
            this.lblPVendaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPVendaProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPVendaProd.Location = new System.Drawing.Point(10, 252);
            this.lblPVendaProd.Name = "lblPVendaProd";
            this.lblPVendaProd.Size = new System.Drawing.Size(82, 21);
            this.lblPVendaProd.TabIndex = 43;
            this.lblPVendaProd.Text = "Venda R$:";
            // 
            // txtPCustoProd
            // 
            this.txtPCustoProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPCustoProd.Location = new System.Drawing.Point(117, 222);
            this.txtPCustoProd.Name = "txtPCustoProd";
            this.txtPCustoProd.PlaceholderText = "Preço de Custo";
            this.txtPCustoProd.Size = new System.Drawing.Size(198, 23);
            this.txtPCustoProd.TabIndex = 41;
            // 
            // txtMarcaProd
            // 
            this.txtMarcaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarcaProd.Location = new System.Drawing.Point(117, 162);
            this.txtMarcaProd.Name = "txtMarcaProd";
            this.txtMarcaProd.PlaceholderText = "Marca";
            this.txtMarcaProd.Size = new System.Drawing.Size(198, 23);
            this.txtMarcaProd.TabIndex = 40;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProd.Location = new System.Drawing.Point(117, 132);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.PlaceholderText = "Nome";
            this.txtNomeProd.Size = new System.Drawing.Size(198, 23);
            this.txtNomeProd.TabIndex = 39;
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarcaProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaProd.Location = new System.Drawing.Point(10, 162);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(59, 21);
            this.lblMarcaProd.TabIndex = 38;
            this.lblMarcaProd.Text = "Marca:";
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoriaProd.Location = new System.Drawing.Point(10, 192);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(85, 21);
            this.lblCategoriaProd.TabIndex = 37;
            this.lblCategoriaProd.Text = "Categoria:";
            // 
            // lblPCustoProd
            // 
            this.lblPCustoProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPCustoProd.AutoSize = true;
            this.lblPCustoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPCustoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPCustoProd.Location = new System.Drawing.Point(10, 222);
            this.lblPCustoProd.Name = "lblPCustoProd";
            this.lblPCustoProd.Size = new System.Drawing.Size(79, 21);
            this.lblPCustoProd.TabIndex = 36;
            this.lblPCustoProd.Text = "Custo R$:";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProd.Location = new System.Drawing.Point(10, 132);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(59, 21);
            this.lblNomeProd.TabIndex = 35;
            this.lblNomeProd.Text = "Nome:";
            // 
            // pnlHeaderProd
            // 
            this.pnlHeaderProd.Controls.Add(this.imgCadProd);
            this.pnlHeaderProd.Controls.Add(this.lblCadProd);
            this.pnlHeaderProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderProd.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderProd.Name = "pnlHeaderProd";
            this.pnlHeaderProd.Size = new System.Drawing.Size(341, 100);
            this.pnlHeaderProd.TabIndex = 0;
            // 
            // imgCadProd
            // 
            this.imgCadProd.Image = ((System.Drawing.Image)(resources.GetObject("imgCadProd.Image")));
            this.imgCadProd.Location = new System.Drawing.Point(247, 23);
            this.imgCadProd.Name = "imgCadProd";
            this.imgCadProd.Size = new System.Drawing.Size(64, 64);
            this.imgCadProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCadProd.TabIndex = 3;
            this.imgCadProd.TabStop = false;
            // 
            // lblCadProd
            // 
            this.lblCadProd.AutoSize = true;
            this.lblCadProd.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadProd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadProd.Location = new System.Drawing.Point(26, 23);
            this.lblCadProd.Name = "lblCadProd";
            this.lblCadProd.Size = new System.Drawing.Size(182, 25);
            this.lblCadProd.TabIndex = 2;
            this.lblCadProd.Text = "Cadastrar Produto:";
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlDivisao.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(5, 450);
            this.pnlDivisao.TabIndex = 48;
            // 
            // pnlViewProd
            // 
            this.pnlViewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlViewProd.Controls.Add(this.imgMarcador);
            this.pnlViewProd.Controls.Add(this.imgBusca);
            this.pnlViewProd.Controls.Add(this.txtBusca);
            this.pnlViewProd.Controls.Add(this.lblMsgError);
            this.pnlViewProd.Controls.Add(this.btnRemover);
            this.pnlViewProd.Controls.Add(this.btnAlterar);
            this.pnlViewProd.Controls.Add(this.dgProdutos);
            this.pnlViewProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewProd.Location = new System.Drawing.Point(346, 0);
            this.pnlViewProd.Name = "pnlViewProd";
            this.pnlViewProd.Size = new System.Drawing.Size(454, 450);
            this.pnlViewProd.TabIndex = 1;
            // 
            // imgMarcador
            // 
            this.imgMarcador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMarcador.Image = ((System.Drawing.Image)(resources.GetObject("imgMarcador.Image")));
            this.imgMarcador.Location = new System.Drawing.Point(399, 23);
            this.imgMarcador.Name = "imgMarcador";
            this.imgMarcador.Size = new System.Drawing.Size(32, 32);
            this.imgMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMarcador.TabIndex = 50;
            this.imgMarcador.TabStop = false;
            // 
            // imgBusca
            // 
            this.imgBusca.Image = ((System.Drawing.Image)(resources.GetObject("imgBusca.Image")));
            this.imgBusca.Location = new System.Drawing.Point(14, 62);
            this.imgBusca.Name = "imgBusca";
            this.imgBusca.Size = new System.Drawing.Size(32, 32);
            this.imgBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBusca.TabIndex = 55;
            this.imgBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(52, 71);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 54;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(14, 23);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 53;
            this.lblMsgError.Text = "*";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(311, 385);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 40);
            this.btnRemover.TabIndex = 48;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BackColor = System.Drawing.Color.Teal;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(203, 385);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 40);
            this.btnAlterar.TabIndex = 52;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // dgProdutos
            // 
            this.dgProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(14, 106);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.RowTemplate.Height = 25;
            this.dgProdutos.Size = new System.Drawing.Size(417, 270);
            this.dgProdutos.TabIndex = 50;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewProd);
            this.Controls.Add(this.pnlCadProd);
            this.Name = "FormProdutos";
            this.Text = "PRODUTOS";
            this.pnlCadProd.ResumeLayout(false);
            this.pnlCadProd.PerformLayout();
            this.pnlHeaderProd.ResumeLayout(false);
            this.pnlHeaderProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadProd)).EndInit();
            this.pnlViewProd.ResumeLayout(false);
            this.pnlViewProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCadProd;
        private Panel pnlHeaderProd;
        private Panel pnlViewProd;
        private PictureBox imgCadProd;
        private Label lblCadProd;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtPVendaProd;
        private Label lblPVendaProd;
        private TextBox txtPCustoProd;
        private TextBox txtMarcaProd;
        private TextBox txtNomeProd;
        private Label lblMarcaProd;
        private Label lblCategoriaProd;
        private Label lblPCustoProd;
        private Label lblNomeProd;
        private ComboBox cbCategoriaProd;
        private Label lblMsgError;
        private Button btnRemover;
        private Button btnAlterar;
        private DataGridView dgProdutos;
        private Panel pnlDivisao;
        private PictureBox imgBusca;
        private TextBox txtBusca;
        private PictureBox imgMarcador;
    }
}