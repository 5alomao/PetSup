namespace SistemaPetShop.Forms
{
    partial class FormPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPets));
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDonoPet = new System.Windows.Forms.TextBox();
            this.lblDono = new System.Windows.Forms.Label();
            this.txtRacaPet = new System.Windows.Forms.TextBox();
            this.txtPortePet = new System.Windows.Forms.TextBox();
            this.txtTipoPet = new System.Windows.Forms.TextBox();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.lblTipoPet = new System.Windows.Forms.Label();
            this.lblRacaPet = new System.Windows.Forms.Label();
            this.lblPortePet = new System.Windows.Forms.Label();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.pnlHeaderPets = new System.Windows.Forms.Panel();
            this.imgCadPet = new System.Windows.Forms.PictureBox();
            this.lblCadPet = new System.Windows.Forms.Label();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.pnlViewPets = new System.Windows.Forms.Panel();
            this.imgMarcador = new System.Windows.Forms.PictureBox();
            this.imgBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgPets = new System.Windows.Forms.DataGridView();
            this.pnlFundo.SuspendLayout();
            this.pnlHeaderPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadPet)).BeginInit();
            this.pnlViewPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.LightCoral;
            this.pnlFundo.Controls.Add(this.btnConfirmar);
            this.pnlFundo.Controls.Add(this.btnCancelar);
            this.pnlFundo.Controls.Add(this.txtDonoPet);
            this.pnlFundo.Controls.Add(this.lblDono);
            this.pnlFundo.Controls.Add(this.txtRacaPet);
            this.pnlFundo.Controls.Add(this.txtPortePet);
            this.pnlFundo.Controls.Add(this.txtTipoPet);
            this.pnlFundo.Controls.Add(this.txtNomePet);
            this.pnlFundo.Controls.Add(this.lblTipoPet);
            this.pnlFundo.Controls.Add(this.lblRacaPet);
            this.pnlFundo.Controls.Add(this.lblPortePet);
            this.pnlFundo.Controls.Add(this.lblNomePet);
            this.pnlFundo.Controls.Add(this.pnlHeaderPets);
            this.pnlFundo.Controls.Add(this.pnlDivisao);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(346, 450);
            this.pnlFundo.TabIndex = 0;
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
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtDonoPet
            // 
            this.txtDonoPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonoPet.Location = new System.Drawing.Point(117, 252);
            this.txtDonoPet.Name = "txtDonoPet";
            this.txtDonoPet.PlaceholderText = "Código do Dono";
            this.txtDonoPet.Size = new System.Drawing.Size(198, 23);
            this.txtDonoPet.TabIndex = 11;
            // 
            // lblDono
            // 
            this.lblDono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDono.AutoSize = true;
            this.lblDono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDono.Location = new System.Drawing.Point(10, 252);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(54, 21);
            this.lblDono.TabIndex = 10;
            this.lblDono.Text = "Dono:";
            // 
            // txtRacaPet
            // 
            this.txtRacaPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRacaPet.Location = new System.Drawing.Point(117, 192);
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.PlaceholderText = "Raça";
            this.txtRacaPet.Size = new System.Drawing.Size(198, 23);
            this.txtRacaPet.TabIndex = 9;
            // 
            // txtPortePet
            // 
            this.txtPortePet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPortePet.Location = new System.Drawing.Point(117, 222);
            this.txtPortePet.Name = "txtPortePet";
            this.txtPortePet.PlaceholderText = "Porte";
            this.txtPortePet.Size = new System.Drawing.Size(198, 23);
            this.txtPortePet.TabIndex = 8;
            // 
            // txtTipoPet
            // 
            this.txtTipoPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoPet.Location = new System.Drawing.Point(117, 162);
            this.txtTipoPet.Name = "txtTipoPet";
            this.txtTipoPet.PlaceholderText = "Tipo";
            this.txtTipoPet.Size = new System.Drawing.Size(198, 23);
            this.txtTipoPet.TabIndex = 7;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePet.Location = new System.Drawing.Point(117, 132);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PlaceholderText = "Nome";
            this.txtNomePet.Size = new System.Drawing.Size(198, 23);
            this.txtNomePet.TabIndex = 6;
            // 
            // lblTipoPet
            // 
            this.lblTipoPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoPet.AutoSize = true;
            this.lblTipoPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoPet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoPet.Location = new System.Drawing.Point(10, 162);
            this.lblTipoPet.Name = "lblTipoPet";
            this.lblTipoPet.Size = new System.Drawing.Size(47, 21);
            this.lblTipoPet.TabIndex = 5;
            this.lblTipoPet.Text = "Tipo:";
            // 
            // lblRacaPet
            // 
            this.lblRacaPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRacaPet.AutoSize = true;
            this.lblRacaPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRacaPet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRacaPet.Location = new System.Drawing.Point(10, 192);
            this.lblRacaPet.Name = "lblRacaPet";
            this.lblRacaPet.Size = new System.Drawing.Size(48, 21);
            this.lblRacaPet.TabIndex = 4;
            this.lblRacaPet.Text = "Raça:";
            // 
            // lblPortePet
            // 
            this.lblPortePet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortePet.AutoSize = true;
            this.lblPortePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPortePet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPortePet.Location = new System.Drawing.Point(10, 222);
            this.lblPortePet.Name = "lblPortePet";
            this.lblPortePet.Size = new System.Drawing.Size(53, 21);
            this.lblPortePet.TabIndex = 3;
            this.lblPortePet.Text = "Porte:";
            // 
            // lblNomePet
            // 
            this.lblNomePet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomePet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomePet.Location = new System.Drawing.Point(10, 132);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(59, 21);
            this.lblNomePet.TabIndex = 2;
            this.lblNomePet.Text = "Nome:";
            // 
            // pnlHeaderPets
            // 
            this.pnlHeaderPets.Controls.Add(this.imgCadPet);
            this.pnlHeaderPets.Controls.Add(this.lblCadPet);
            this.pnlHeaderPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPets.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPets.Name = "pnlHeaderPets";
            this.pnlHeaderPets.Size = new System.Drawing.Size(341, 100);
            this.pnlHeaderPets.TabIndex = 0;
            // 
            // imgCadPet
            // 
            this.imgCadPet.Image = ((System.Drawing.Image)(resources.GetObject("imgCadPet.Image")));
            this.imgCadPet.Location = new System.Drawing.Point(247, 23);
            this.imgCadPet.Name = "imgCadPet";
            this.imgCadPet.Size = new System.Drawing.Size(64, 64);
            this.imgCadPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCadPet.TabIndex = 1;
            this.imgCadPet.TabStop = false;
            // 
            // lblCadPet
            // 
            this.lblCadPet.AutoSize = true;
            this.lblCadPet.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadPet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadPet.Location = new System.Drawing.Point(26, 23);
            this.lblCadPet.Name = "lblCadPet";
            this.lblCadPet.Size = new System.Drawing.Size(135, 25);
            this.lblCadPet.TabIndex = 0;
            this.lblCadPet.Text = "Cadastrar Pet:";
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.BackColor = System.Drawing.Color.Maroon;
            this.pnlDivisao.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(5, 450);
            this.pnlDivisao.TabIndex = 1;
            // 
            // pnlViewPets
            // 
            this.pnlViewPets.BackColor = System.Drawing.Color.LightCoral;
            this.pnlViewPets.Controls.Add(this.imgMarcador);
            this.pnlViewPets.Controls.Add(this.imgBusca);
            this.pnlViewPets.Controls.Add(this.txtBusca);
            this.pnlViewPets.Controls.Add(this.lblMsgError);
            this.pnlViewPets.Controls.Add(this.btnRemover);
            this.pnlViewPets.Controls.Add(this.btnAlterar);
            this.pnlViewPets.Controls.Add(this.dgPets);
            this.pnlViewPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewPets.Location = new System.Drawing.Point(346, 0);
            this.pnlViewPets.Name = "pnlViewPets";
            this.pnlViewPets.Size = new System.Drawing.Size(454, 450);
            this.pnlViewPets.TabIndex = 1;
            // 
            // imgMarcador
            // 
            this.imgMarcador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMarcador.Image = ((System.Drawing.Image)(resources.GetObject("imgMarcador.Image")));
            this.imgMarcador.Location = new System.Drawing.Point(399, 23);
            this.imgMarcador.Name = "imgMarcador";
            this.imgMarcador.Size = new System.Drawing.Size(32, 32);
            this.imgMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMarcador.TabIndex = 49;
            this.imgMarcador.TabStop = false;
            // 
            // imgBusca
            // 
            this.imgBusca.Image = ((System.Drawing.Image)(resources.GetObject("imgBusca.Image")));
            this.imgBusca.Location = new System.Drawing.Point(14, 62);
            this.imgBusca.Name = "imgBusca";
            this.imgBusca.Size = new System.Drawing.Size(32, 32);
            this.imgBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBusca.TabIndex = 48;
            this.imgBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(52, 71);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 45;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(14, 23);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 47;
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
            this.btnRemover.TabIndex = 42;
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
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // dgPets
            // 
            this.dgPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPets.BackgroundColor = System.Drawing.Color.White;
            this.dgPets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPets.Location = new System.Drawing.Point(14, 106);
            this.dgPets.Name = "dgPets";
            this.dgPets.RowTemplate.Height = 25;
            this.dgPets.Size = new System.Drawing.Size(417, 270);
            this.dgPets.TabIndex = 44;
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewPets);
            this.Controls.Add(this.pnlFundo);
            this.Name = "FormPets";
            this.Text = "PETS";
            this.Load += new System.EventHandler(this.FormPets_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.pnlHeaderPets.ResumeLayout(false);
            this.pnlHeaderPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadPet)).EndInit();
            this.pnlViewPets.ResumeLayout(false);
            this.pnlViewPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlFundo;
        private Panel pnlHeaderPets;
        private Panel pnlDivisao;
        private Panel pnlViewPets;
        private Label lblCadPet;
        private Label lblNomePet;
        private Label lblTipoPet;
        private Label lblRacaPet;
        private Label lblPortePet;
        private TextBox txtRacaPet;
        private TextBox txtPortePet;
        private TextBox txtTipoPet;
        private TextBox txtNomePet;
        private Label lblDono;
        private TextBox txtDonoPet;
        private Button btnConfirmar;
        private Button btnCancelar;
        private PictureBox imgCadPet;
        private TextBox txtBusca;
        private Label lblMsgError;
        private Button btnRemover;
        private Button btnAlterar;
        private DataGridView dgPets;
        private PictureBox imgBusca;
        private PictureBox imgMarcador;
    }
}