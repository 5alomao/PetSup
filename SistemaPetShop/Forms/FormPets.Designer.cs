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
            this.txtDonoPet = new System.Windows.Forms.TextBox();
            this.txtRacaPet = new System.Windows.Forms.TextBox();
            this.txtPortePet = new System.Windows.Forms.TextBox();
            this.txtTipoPet = new System.Windows.Forms.TextBox();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.dgPets = new System.Windows.Forms.DataGridView();
            this.imgPet = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblViewCli = new System.Windows.Forms.Label();
            this.pnlMarcador = new System.Windows.Forms.Panel();
            this.lblHeaderPet = new System.Windows.Forms.Label();
            this.imgTipoPet = new System.Windows.Forms.PictureBox();
            this.imgRacaPet = new System.Windows.Forms.PictureBox();
            this.imgPortePet = new System.Windows.Forms.PictureBox();
            this.imgDono = new System.Windows.Forms.PictureBox();
            this.pnlSLimpar = new System.Windows.Forms.Panel();
            this.pnlSConfirmar = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSBuscar = new System.Windows.Forms.Panel();
            this.pnlSAlterar = new System.Windows.Forms.Panel();
            this.pnlSRemover = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacaPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortePet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDono)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonoPet
            // 
            this.txtDonoPet.Location = new System.Drawing.Point(85, 256);
            this.txtDonoPet.Name = "txtDonoPet";
            this.txtDonoPet.PlaceholderText = "Código do Dono";
            this.txtDonoPet.Size = new System.Drawing.Size(186, 23);
            this.txtDonoPet.TabIndex = 73;
            // 
            // txtRacaPet
            // 
            this.txtRacaPet.Location = new System.Drawing.Point(85, 176);
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.PlaceholderText = "Raça";
            this.txtRacaPet.Size = new System.Drawing.Size(186, 23);
            this.txtRacaPet.TabIndex = 71;
            // 
            // txtPortePet
            // 
            this.txtPortePet.Location = new System.Drawing.Point(85, 216);
            this.txtPortePet.Name = "txtPortePet";
            this.txtPortePet.PlaceholderText = "Porte";
            this.txtPortePet.Size = new System.Drawing.Size(186, 23);
            this.txtPortePet.TabIndex = 70;
            // 
            // txtTipoPet
            // 
            this.txtTipoPet.Location = new System.Drawing.Point(85, 136);
            this.txtTipoPet.Name = "txtTipoPet";
            this.txtTipoPet.PlaceholderText = "Tipo";
            this.txtTipoPet.Size = new System.Drawing.Size(186, 23);
            this.txtTipoPet.TabIndex = 69;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(85, 96);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PlaceholderText = "Nome";
            this.txtNomePet.Size = new System.Drawing.Size(186, 23);
            this.txtNomePet.TabIndex = 68;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(22, 479);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 62;
            this.lblMsgError.Text = "*";
            // 
            // dgPets
            // 
            this.dgPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPets.BackgroundColor = System.Drawing.Color.White;
            this.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPets.Location = new System.Drawing.Point(374, 140);
            this.dgPets.Name = "dgPets";
            this.dgPets.RowTemplate.Height = 25;
            this.dgPets.Size = new System.Drawing.Size(434, 273);
            this.dgPets.TabIndex = 60;
            // 
            // imgPet
            // 
            this.imgPet.BackColor = System.Drawing.Color.Transparent;
            this.imgPet.Image = ((System.Drawing.Image)(resources.GetObject("imgPet.Image")));
            this.imgPet.Location = new System.Drawing.Point(47, 87);
            this.imgPet.Name = "imgPet";
            this.imgPet.Size = new System.Drawing.Size(32, 32);
            this.imgPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPet.TabIndex = 74;
            this.imgPet.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Location = new System.Drawing.Point(375, 111);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBusca.Size = new System.Drawing.Size(218, 23);
            this.txtBusca.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(375, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 5);
            this.panel1.TabIndex = 78;
            // 
            // lblViewCli
            // 
            this.lblViewCli.AutoSize = true;
            this.lblViewCli.BackColor = System.Drawing.Color.Transparent;
            this.lblViewCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblViewCli.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewCli.ForeColor = System.Drawing.Color.Black;
            this.lblViewCli.Location = new System.Drawing.Point(375, 26);
            this.lblViewCli.Name = "lblViewCli";
            this.lblViewCli.Size = new System.Drawing.Size(168, 23);
            this.lblViewCli.TabIndex = 79;
            this.lblViewCli.Text = "Pets Registrados";
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.Maroon;
            this.pnlMarcador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador.Location = new System.Drawing.Point(22, 52);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(280, 5);
            this.pnlMarcador.TabIndex = 77;
            // 
            // lblHeaderPet
            // 
            this.lblHeaderPet.AutoSize = true;
            this.lblHeaderPet.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderPet.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderPet.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPet.Location = new System.Drawing.Point(22, 26);
            this.lblHeaderPet.Name = "lblHeaderPet";
            this.lblHeaderPet.Size = new System.Drawing.Size(137, 23);
            this.lblHeaderPet.TabIndex = 76;
            this.lblHeaderPet.Text = "Cadastrar Pet";
            // 
            // imgTipoPet
            // 
            this.imgTipoPet.Location = new System.Drawing.Point(47, 129);
            this.imgTipoPet.Name = "imgTipoPet";
            this.imgTipoPet.Size = new System.Drawing.Size(32, 32);
            this.imgTipoPet.TabIndex = 80;
            this.imgTipoPet.TabStop = false;
            // 
            // imgRacaPet
            // 
            this.imgRacaPet.Location = new System.Drawing.Point(47, 167);
            this.imgRacaPet.Name = "imgRacaPet";
            this.imgRacaPet.Size = new System.Drawing.Size(32, 32);
            this.imgRacaPet.TabIndex = 81;
            this.imgRacaPet.TabStop = false;
            // 
            // imgPortePet
            // 
            this.imgPortePet.Location = new System.Drawing.Point(47, 207);
            this.imgPortePet.Name = "imgPortePet";
            this.imgPortePet.Size = new System.Drawing.Size(32, 32);
            this.imgPortePet.TabIndex = 82;
            this.imgPortePet.TabStop = false;
            // 
            // imgDono
            // 
            this.imgDono.Location = new System.Drawing.Point(47, 247);
            this.imgDono.Name = "imgDono";
            this.imgDono.Size = new System.Drawing.Size(32, 32);
            this.imgDono.TabIndex = 83;
            this.imgDono.TabStop = false;
            // 
            // pnlSLimpar
            // 
            this.pnlSLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlSLimpar.Location = new System.Drawing.Point(47, 413);
            this.pnlSLimpar.Name = "pnlSLimpar";
            this.pnlSLimpar.Size = new System.Drawing.Size(77, 3);
            this.pnlSLimpar.TabIndex = 87;
            // 
            // pnlSConfirmar
            // 
            this.pnlSConfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlSConfirmar.Location = new System.Drawing.Point(190, 413);
            this.pnlSConfirmar.Name = "pnlSConfirmar";
            this.pnlSConfirmar.Size = new System.Drawing.Size(95, 3);
            this.pnlSConfirmar.TabIndex = 86;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 367);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 40);
            this.btnConfirmar.TabIndex = 85;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(47, 367);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 40);
            this.btnLimpar.TabIndex = 84;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.imgPet);
            this.panel2.Controls.Add(this.pnlSBuscar);
            this.panel2.Controls.Add(this.pnlSAlterar);
            this.panel2.Controls.Add(this.pnlSRemover);
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lblMsgError);
            this.panel2.Controls.Add(this.pnlSLimpar);
            this.panel2.Controls.Add(this.txtNomePet);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.pnlSConfirmar);
            this.panel2.Controls.Add(this.txtTipoPet);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.txtRacaPet);
            this.panel2.Controls.Add(this.txtPortePet);
            this.panel2.Controls.Add(this.txtBusca);
            this.panel2.Controls.Add(this.dgPets);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.imgDono);
            this.panel2.Controls.Add(this.lblViewCli);
            this.panel2.Controls.Add(this.txtDonoPet);
            this.panel2.Controls.Add(this.pnlMarcador);
            this.panel2.Controls.Add(this.imgPortePet);
            this.panel2.Controls.Add(this.lblHeaderPet);
            this.panel2.Controls.Add(this.imgRacaPet);
            this.panel2.Controls.Add(this.imgTipoPet);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 503);
            this.panel2.TabIndex = 88;
            // 
            // pnlSBuscar
            // 
            this.pnlSBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSBuscar.Location = new System.Drawing.Point(711, 465);
            this.pnlSBuscar.Name = "pnlSBuscar";
            this.pnlSBuscar.Size = new System.Drawing.Size(98, 3);
            this.pnlSBuscar.TabIndex = 91;
            // 
            // pnlSAlterar
            // 
            this.pnlSAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSAlterar.Location = new System.Drawing.Point(607, 465);
            this.pnlSAlterar.Name = "pnlSAlterar";
            this.pnlSAlterar.Size = new System.Drawing.Size(98, 3);
            this.pnlSAlterar.TabIndex = 93;
            // 
            // pnlSRemover
            // 
            this.pnlSRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSRemover.Location = new System.Drawing.Point(503, 465);
            this.pnlSRemover.Name = "pnlSRemover";
            this.pnlSRemover.Size = new System.Drawing.Size(98, 3);
            this.pnlSRemover.TabIndex = 92;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.AutoSize = true;
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.Black;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(503, 419);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 40);
            this.btnRemover.TabIndex = 89;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(607, 419);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 40);
            this.btnAlterar.TabIndex = 88;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(711, 419);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 90;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 503);
            this.Controls.Add(this.panel2);
            this.Name = "FormPets";
            this.Text = "PETS";
            this.Load += new System.EventHandler(this.FormPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacaPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortePet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDono)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtDonoPet;
        private TextBox txtRacaPet;
        private TextBox txtPortePet;
        private TextBox txtTipoPet;
        private TextBox txtNomePet;
        private Label lblMsgError;
        private DataGridView dgPets;
        private PictureBox imgPet;
        private TextBox txtBusca;
        private Panel panel1;
        private Label lblViewCli;
        private Panel pnlMarcador;
        private Label lblHeaderPet;
        private PictureBox imgTipoPet;
        private PictureBox imgRacaPet;
        private PictureBox imgPortePet;
        private PictureBox imgDono;
        private Panel pnlSLimpar;
        private Panel pnlSConfirmar;
        private Button btnConfirmar;
        private Button btnLimpar;
        private Panel panel2;
        private Panel pnlSBuscar;
        private Panel pnlSAlterar;
        private Panel pnlSRemover;
        private Button btnRemover;
        private Button btnAlterar;
        private Button btnBuscar;
    }
}