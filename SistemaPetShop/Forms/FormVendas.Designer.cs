namespace SistemaPetShop.Forms
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.pnlCadVendas = new System.Windows.Forms.Panel();
            this.txtDataHoraVenda = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblProdVenda = new System.Windows.Forms.Label();
            this.lblDataHoraVenda = new System.Windows.Forms.Label();
            this.lblCodCliVenda = new System.Windows.Forms.Label();
            this.pnlHeaderVendas = new System.Windows.Forms.Panel();
            this.imgCadVendas = new System.Windows.Forms.PictureBox();
            this.lblCadVendas = new System.Windows.Forms.Label();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.pnlViewVendas = new System.Windows.Forms.Panel();
            this.imgMarcador = new System.Windows.Forms.PictureBox();
            this.imgBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.pnlCadVendas.SuspendLayout();
            this.pnlHeaderVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadVendas)).BeginInit();
            this.pnlViewVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadVendas
            // 
            this.pnlCadVendas.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlCadVendas.Controls.Add(this.txtDataHoraVenda);
            this.pnlCadVendas.Controls.Add(this.btnConfirmar);
            this.pnlCadVendas.Controls.Add(this.btnCancelar);
            this.pnlCadVendas.Controls.Add(this.txtCodProd);
            this.pnlCadVendas.Controls.Add(this.txtCodCli);
            this.pnlCadVendas.Controls.Add(this.lblProdVenda);
            this.pnlCadVendas.Controls.Add(this.lblDataHoraVenda);
            this.pnlCadVendas.Controls.Add(this.lblCodCliVenda);
            this.pnlCadVendas.Controls.Add(this.pnlHeaderVendas);
            this.pnlCadVendas.Controls.Add(this.pnlDivisao);
            this.pnlCadVendas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadVendas.Location = new System.Drawing.Point(0, 0);
            this.pnlCadVendas.Name = "pnlCadVendas";
            this.pnlCadVendas.Size = new System.Drawing.Size(346, 450);
            this.pnlCadVendas.TabIndex = 0;
            // 
            // txtDataHoraVenda
            // 
            this.txtDataHoraVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataHoraVenda.Location = new System.Drawing.Point(117, 192);
            this.txtDataHoraVenda.Name = "txtDataHoraVenda";
            this.txtDataHoraVenda.PlaceholderText = "Data e Hora";
            this.txtDataHoraVenda.Size = new System.Drawing.Size(198, 23);
            this.txtDataHoraVenda.TabIndex = 59;
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
            this.btnConfirmar.TabIndex = 57;
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
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProd.Location = new System.Drawing.Point(117, 162);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.PlaceholderText = "Código do Produto";
            this.txtCodProd.Size = new System.Drawing.Size(198, 23);
            this.txtCodProd.TabIndex = 53;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCli.Location = new System.Drawing.Point(117, 132);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.PlaceholderText = "Código do Cliente";
            this.txtCodCli.Size = new System.Drawing.Size(198, 23);
            this.txtCodCli.TabIndex = 52;
            // 
            // lblProdVenda
            // 
            this.lblProdVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdVenda.AutoSize = true;
            this.lblProdVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdVenda.Location = new System.Drawing.Point(10, 162);
            this.lblProdVenda.Name = "lblProdVenda";
            this.lblProdVenda.Size = new System.Drawing.Size(74, 21);
            this.lblProdVenda.TabIndex = 51;
            this.lblProdVenda.Text = "Produto:";
            // 
            // lblDataHoraVenda
            // 
            this.lblDataHoraVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataHoraVenda.AutoSize = true;
            this.lblDataHoraVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataHoraVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataHoraVenda.Location = new System.Drawing.Point(10, 192);
            this.lblDataHoraVenda.Name = "lblDataHoraVenda";
            this.lblDataHoraVenda.Size = new System.Drawing.Size(86, 21);
            this.lblDataHoraVenda.TabIndex = 50;
            this.lblDataHoraVenda.Text = "Data/Hora";
            // 
            // lblCodCliVenda
            // 
            this.lblCodCliVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodCliVenda.AutoSize = true;
            this.lblCodCliVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodCliVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodCliVenda.Location = new System.Drawing.Point(10, 132);
            this.lblCodCliVenda.Name = "lblCodCliVenda";
            this.lblCodCliVenda.Size = new System.Drawing.Size(65, 21);
            this.lblCodCliVenda.TabIndex = 48;
            this.lblCodCliVenda.Text = "Cliente:";
            // 
            // pnlHeaderVendas
            // 
            this.pnlHeaderVendas.Controls.Add(this.imgCadVendas);
            this.pnlHeaderVendas.Controls.Add(this.lblCadVendas);
            this.pnlHeaderVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderVendas.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderVendas.Name = "pnlHeaderVendas";
            this.pnlHeaderVendas.Size = new System.Drawing.Size(341, 100);
            this.pnlHeaderVendas.TabIndex = 0;
            // 
            // imgCadVendas
            // 
            this.imgCadVendas.Image = ((System.Drawing.Image)(resources.GetObject("imgCadVendas.Image")));
            this.imgCadVendas.Location = new System.Drawing.Point(247, 23);
            this.imgCadVendas.Name = "imgCadVendas";
            this.imgCadVendas.Size = new System.Drawing.Size(64, 64);
            this.imgCadVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCadVendas.TabIndex = 5;
            this.imgCadVendas.TabStop = false;
            // 
            // lblCadVendas
            // 
            this.lblCadVendas.AutoSize = true;
            this.lblCadVendas.BackColor = System.Drawing.Color.Transparent;
            this.lblCadVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadVendas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadVendas.Location = new System.Drawing.Point(26, 23);
            this.lblCadVendas.Name = "lblCadVendas";
            this.lblCadVendas.Size = new System.Drawing.Size(158, 25);
            this.lblCadVendas.TabIndex = 4;
            this.lblCadVendas.Text = "Registrar Venda:";
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDivisao.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(5, 450);
            this.pnlDivisao.TabIndex = 1;
            // 
            // pnlViewVendas
            // 
            this.pnlViewVendas.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlViewVendas.Controls.Add(this.imgMarcador);
            this.pnlViewVendas.Controls.Add(this.imgBusca);
            this.pnlViewVendas.Controls.Add(this.txtBusca);
            this.pnlViewVendas.Controls.Add(this.lblMsgError);
            this.pnlViewVendas.Controls.Add(this.btnRemover);
            this.pnlViewVendas.Controls.Add(this.btnAlterar);
            this.pnlViewVendas.Controls.Add(this.dgVendas);
            this.pnlViewVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewVendas.Location = new System.Drawing.Point(346, 0);
            this.pnlViewVendas.Name = "pnlViewVendas";
            this.pnlViewVendas.Size = new System.Drawing.Size(454, 450);
            this.pnlViewVendas.TabIndex = 1;
            // 
            // imgMarcador
            // 
            this.imgMarcador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMarcador.Image = ((System.Drawing.Image)(resources.GetObject("imgMarcador.Image")));
            this.imgMarcador.Location = new System.Drawing.Point(399, 23);
            this.imgMarcador.Name = "imgMarcador";
            this.imgMarcador.Size = new System.Drawing.Size(32, 32);
            this.imgMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMarcador.TabIndex = 60;
            this.imgMarcador.TabStop = false;
            // 
            // imgBusca
            // 
            this.imgBusca.Image = ((System.Drawing.Image)(resources.GetObject("imgBusca.Image")));
            this.imgBusca.Location = new System.Drawing.Point(14, 62);
            this.imgBusca.Name = "imgBusca";
            this.imgBusca.Size = new System.Drawing.Size(32, 32);
            this.imgBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBusca.TabIndex = 62;
            this.imgBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(52, 71);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 61;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(14, 23);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 59;
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
            this.btnRemover.TabIndex = 54;
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
            this.btnAlterar.TabIndex = 58;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // dgVendas
            // 
            this.dgVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Location = new System.Drawing.Point(14, 106);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.RowTemplate.Height = 25;
            this.dgVendas.Size = new System.Drawing.Size(417, 270);
            this.dgVendas.TabIndex = 56;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewVendas);
            this.Controls.Add(this.pnlCadVendas);
            this.Name = "FormVendas";
            this.Text = "VENDAS";
            this.pnlCadVendas.ResumeLayout(false);
            this.pnlCadVendas.PerformLayout();
            this.pnlHeaderVendas.ResumeLayout(false);
            this.pnlHeaderVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadVendas)).EndInit();
            this.pnlViewVendas.ResumeLayout(false);
            this.pnlViewVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCadVendas;
        private Panel pnlHeaderVendas;
        private Panel pnlDivisao;
        private TextBox txtDataHoraVenda;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtCodProd;
        private TextBox txtCodCli;
        private Label lblProdVenda;
        private Label lblDataHoraVenda;
        private Label lblCodCliVenda;
        private PictureBox imgCadVendas;
        private Label lblCadVendas;
        private Panel pnlViewVendas;
        private Label lblMsgError;
        private Button btnRemover;
        private Button btnAlterar;
        private DataGridView dgVendas;
        private PictureBox imgMarcador;
        private PictureBox imgBusca;
        private TextBox txtBusca;
    }
}