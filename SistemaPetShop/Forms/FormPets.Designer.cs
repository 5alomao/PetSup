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
            this.pnlMarcador2 = new System.Windows.Forms.Panel();
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
            this.pnlPets = new System.Windows.Forms.Panel();
            this.pnlSBuscar = new System.Windows.Forms.Panel();
            this.pnlSAlterar = new System.Windows.Forms.Panel();
            this.pnlSRemover = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlLinhaNome = new System.Windows.Forms.Panel();
            this.imgCorPet = new System.Windows.Forms.PictureBox();
            this.pnlLinhaTipo = new System.Windows.Forms.Panel();
            this.pnlLinhaCor = new System.Windows.Forms.Panel();
            this.pnlLinhaRaca = new System.Windows.Forms.Panel();
            this.pnlLinhaPorte = new System.Windows.Forms.Panel();
            this.pnlLinhaDono = new System.Windows.Forms.Panel();
            this.txtCorPet = new System.Windows.Forms.TextBox();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacaPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortePet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDono)).BeginInit();
            this.pnlPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCorPet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonoPet
            // 
            this.txtDonoPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonoPet.Location = new System.Drawing.Point(85, 363);
            this.txtDonoPet.Name = "txtDonoPet";
            this.txtDonoPet.PlaceholderText = "Código do Dono";
            this.txtDonoPet.Size = new System.Drawing.Size(200, 16);
            this.txtDonoPet.TabIndex = 73;
            // 
            // txtRacaPet
            // 
            this.txtRacaPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRacaPet.Location = new System.Drawing.Point(85, 263);
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.PlaceholderText = "Raça";
            this.txtRacaPet.Size = new System.Drawing.Size(200, 16);
            this.txtRacaPet.TabIndex = 71;
            // 
            // txtPortePet
            // 
            this.txtPortePet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPortePet.Location = new System.Drawing.Point(85, 313);
            this.txtPortePet.Name = "txtPortePet";
            this.txtPortePet.PlaceholderText = "Porte";
            this.txtPortePet.Size = new System.Drawing.Size(200, 16);
            this.txtPortePet.TabIndex = 70;
            // 
            // txtTipoPet
            // 
            this.txtTipoPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoPet.Location = new System.Drawing.Point(85, 163);
            this.txtTipoPet.Name = "txtTipoPet";
            this.txtTipoPet.PlaceholderText = "Tipo";
            this.txtTipoPet.Size = new System.Drawing.Size(200, 16);
            this.txtTipoPet.TabIndex = 69;
            // 
            // txtNomePet
            // 
            this.txtNomePet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePet.Location = new System.Drawing.Point(85, 113);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PlaceholderText = "Nome";
            this.txtNomePet.Size = new System.Drawing.Size(200, 16);
            this.txtNomePet.TabIndex = 68;
            // 
            // lblMsgError
            // 
            this.lblMsgError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(22, 657);
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
            this.dgPets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPets.Location = new System.Drawing.Point(375, 140);
            this.dgPets.Name = "dgPets";
            this.dgPets.RowTemplate.Height = 25;
            this.dgPets.Size = new System.Drawing.Size(797, 451);
            this.dgPets.TabIndex = 60;
            // 
            // imgPet
            // 
            this.imgPet.BackColor = System.Drawing.Color.Transparent;
            this.imgPet.Image = ((System.Drawing.Image)(resources.GetObject("imgPet.Image")));
            this.imgPet.Location = new System.Drawing.Point(47, 101);
            this.imgPet.Name = "imgPet";
            this.imgPet.Size = new System.Drawing.Size(32, 32);
            this.imgPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPet.TabIndex = 74;
            this.imgPet.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(375, 110);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBusca.Size = new System.Drawing.Size(218, 23);
            this.txtBusca.TabIndex = 75;
            // 
            // pnlMarcador2
            // 
            this.pnlMarcador2.BackColor = System.Drawing.Color.Maroon;
            this.pnlMarcador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMarcador2.Location = new System.Drawing.Point(375, 70);
            this.pnlMarcador2.Name = "pnlMarcador2";
            this.pnlMarcador2.Size = new System.Drawing.Size(413, 3);
            this.pnlMarcador2.TabIndex = 78;
            // 
            // lblViewCli
            // 
            this.lblViewCli.AutoSize = true;
            this.lblViewCli.BackColor = System.Drawing.Color.Transparent;
            this.lblViewCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblViewCli.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewCli.ForeColor = System.Drawing.Color.Black;
            this.lblViewCli.Location = new System.Drawing.Point(375, 44);
            this.lblViewCli.Name = "lblViewCli";
            this.lblViewCli.Size = new System.Drawing.Size(168, 23);
            this.lblViewCli.TabIndex = 79;
            this.lblViewCli.Text = "Pets Registrados";
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.Maroon;
            this.pnlMarcador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador.Location = new System.Drawing.Point(47, 70);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(238, 3);
            this.pnlMarcador.TabIndex = 77;
            // 
            // lblHeaderPet
            // 
            this.lblHeaderPet.AutoSize = true;
            this.lblHeaderPet.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderPet.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderPet.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPet.Location = new System.Drawing.Point(47, 44);
            this.lblHeaderPet.Name = "lblHeaderPet";
            this.lblHeaderPet.Size = new System.Drawing.Size(137, 23);
            this.lblHeaderPet.TabIndex = 76;
            this.lblHeaderPet.Text = "Cadastrar Pet";
            // 
            // imgTipoPet
            // 
            this.imgTipoPet.Image = ((System.Drawing.Image)(resources.GetObject("imgTipoPet.Image")));
            this.imgTipoPet.Location = new System.Drawing.Point(47, 151);
            this.imgTipoPet.Name = "imgTipoPet";
            this.imgTipoPet.Size = new System.Drawing.Size(32, 32);
            this.imgTipoPet.TabIndex = 80;
            this.imgTipoPet.TabStop = false;
            // 
            // imgRacaPet
            // 
            this.imgRacaPet.Image = ((System.Drawing.Image)(resources.GetObject("imgRacaPet.Image")));
            this.imgRacaPet.Location = new System.Drawing.Point(47, 251);
            this.imgRacaPet.Name = "imgRacaPet";
            this.imgRacaPet.Size = new System.Drawing.Size(32, 32);
            this.imgRacaPet.TabIndex = 81;
            this.imgRacaPet.TabStop = false;
            // 
            // imgPortePet
            // 
            this.imgPortePet.Image = ((System.Drawing.Image)(resources.GetObject("imgPortePet.Image")));
            this.imgPortePet.Location = new System.Drawing.Point(47, 301);
            this.imgPortePet.Name = "imgPortePet";
            this.imgPortePet.Size = new System.Drawing.Size(32, 32);
            this.imgPortePet.TabIndex = 82;
            this.imgPortePet.TabStop = false;
            // 
            // imgDono
            // 
            this.imgDono.Image = ((System.Drawing.Image)(resources.GetObject("imgDono.Image")));
            this.imgDono.Location = new System.Drawing.Point(47, 351);
            this.imgDono.Name = "imgDono";
            this.imgDono.Size = new System.Drawing.Size(32, 32);
            this.imgDono.TabIndex = 83;
            this.imgDono.TabStop = false;
            // 
            // pnlSLimpar
            // 
            this.pnlSLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlSLimpar.Location = new System.Drawing.Point(47, 465);
            this.pnlSLimpar.Name = "pnlSLimpar";
            this.pnlSLimpar.Size = new System.Drawing.Size(77, 3);
            this.pnlSLimpar.TabIndex = 87;
            // 
            // pnlSConfirmar
            // 
            this.pnlSConfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlSConfirmar.Location = new System.Drawing.Point(190, 465);
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
            this.btnConfirmar.Location = new System.Drawing.Point(190, 419);
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
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(47, 419);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 40);
            this.btnLimpar.TabIndex = 84;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnlPets
            // 
            this.pnlPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPets.BackColor = System.Drawing.Color.White;
            this.pnlPets.Controls.Add(this.btnConfirmaAlteracao);
            this.pnlPets.Controls.Add(this.txtCorPet);
            this.pnlPets.Controls.Add(this.pnlLinhaDono);
            this.pnlPets.Controls.Add(this.pnlLinhaPorte);
            this.pnlPets.Controls.Add(this.pnlLinhaRaca);
            this.pnlPets.Controls.Add(this.pnlLinhaCor);
            this.pnlPets.Controls.Add(this.pnlLinhaTipo);
            this.pnlPets.Controls.Add(this.imgCorPet);
            this.pnlPets.Controls.Add(this.pnlLinhaNome);
            this.pnlPets.Controls.Add(this.imgPet);
            this.pnlPets.Controls.Add(this.pnlSBuscar);
            this.pnlPets.Controls.Add(this.pnlSAlterar);
            this.pnlPets.Controls.Add(this.pnlSRemover);
            this.pnlPets.Controls.Add(this.btnRemover);
            this.pnlPets.Controls.Add(this.btnAlterar);
            this.pnlPets.Controls.Add(this.btnBuscar);
            this.pnlPets.Controls.Add(this.lblMsgError);
            this.pnlPets.Controls.Add(this.pnlSLimpar);
            this.pnlPets.Controls.Add(this.txtNomePet);
            this.pnlPets.Controls.Add(this.btnLimpar);
            this.pnlPets.Controls.Add(this.pnlSConfirmar);
            this.pnlPets.Controls.Add(this.txtTipoPet);
            this.pnlPets.Controls.Add(this.btnConfirmar);
            this.pnlPets.Controls.Add(this.txtRacaPet);
            this.pnlPets.Controls.Add(this.txtPortePet);
            this.pnlPets.Controls.Add(this.txtBusca);
            this.pnlPets.Controls.Add(this.dgPets);
            this.pnlPets.Controls.Add(this.pnlMarcador2);
            this.pnlPets.Controls.Add(this.imgDono);
            this.pnlPets.Controls.Add(this.lblViewCli);
            this.pnlPets.Controls.Add(this.txtDonoPet);
            this.pnlPets.Controls.Add(this.pnlMarcador);
            this.pnlPets.Controls.Add(this.imgPortePet);
            this.pnlPets.Controls.Add(this.lblHeaderPet);
            this.pnlPets.Controls.Add(this.imgRacaPet);
            this.pnlPets.Controls.Add(this.imgTipoPet);
            this.pnlPets.Location = new System.Drawing.Point(0, 0);
            this.pnlPets.Name = "pnlPets";
            this.pnlPets.Size = new System.Drawing.Size(1184, 681);
            this.pnlPets.TabIndex = 88;
            // 
            // pnlSBuscar
            // 
            this.pnlSBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSBuscar.Location = new System.Drawing.Point(1074, 643);
            this.pnlSBuscar.Name = "pnlSBuscar";
            this.pnlSBuscar.Size = new System.Drawing.Size(98, 3);
            this.pnlSBuscar.TabIndex = 91;
            // 
            // pnlSAlterar
            // 
            this.pnlSAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSAlterar.Location = new System.Drawing.Point(970, 643);
            this.pnlSAlterar.Name = "pnlSAlterar";
            this.pnlSAlterar.Size = new System.Drawing.Size(98, 3);
            this.pnlSAlterar.TabIndex = 93;
            // 
            // pnlSRemover
            // 
            this.pnlSRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSRemover.Location = new System.Drawing.Point(866, 643);
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
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(866, 597);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 40);
            this.btnRemover.TabIndex = 89;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(970, 597);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 40);
            this.btnAlterar.TabIndex = 88;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1074, 597);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 90;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pnlLinhaNome
            // 
            this.pnlLinhaNome.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaNome.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaNome.Location = new System.Drawing.Point(85, 131);
            this.pnlLinhaNome.Name = "pnlLinhaNome";
            this.pnlLinhaNome.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaNome.TabIndex = 94;
            // 
            // imgCorPet
            // 
            this.imgCorPet.Image = ((System.Drawing.Image)(resources.GetObject("imgCorPet.Image")));
            this.imgCorPet.Location = new System.Drawing.Point(47, 201);
            this.imgCorPet.Name = "imgCorPet";
            this.imgCorPet.Size = new System.Drawing.Size(32, 32);
            this.imgCorPet.TabIndex = 95;
            this.imgCorPet.TabStop = false;
            // 
            // pnlLinhaTipo
            // 
            this.pnlLinhaTipo.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaTipo.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaTipo.Location = new System.Drawing.Point(85, 181);
            this.pnlLinhaTipo.Name = "pnlLinhaTipo";
            this.pnlLinhaTipo.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaTipo.TabIndex = 96;
            // 
            // pnlLinhaCor
            // 
            this.pnlLinhaCor.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaCor.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaCor.Location = new System.Drawing.Point(85, 231);
            this.pnlLinhaCor.Name = "pnlLinhaCor";
            this.pnlLinhaCor.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaCor.TabIndex = 97;
            // 
            // pnlLinhaRaca
            // 
            this.pnlLinhaRaca.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaRaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaRaca.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaRaca.Location = new System.Drawing.Point(85, 281);
            this.pnlLinhaRaca.Name = "pnlLinhaRaca";
            this.pnlLinhaRaca.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaRaca.TabIndex = 98;
            // 
            // pnlLinhaPorte
            // 
            this.pnlLinhaPorte.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaPorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaPorte.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaPorte.Location = new System.Drawing.Point(85, 331);
            this.pnlLinhaPorte.Name = "pnlLinhaPorte";
            this.pnlLinhaPorte.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaPorte.TabIndex = 99;
            // 
            // pnlLinhaDono
            // 
            this.pnlLinhaDono.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaDono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaDono.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaDono.Location = new System.Drawing.Point(85, 381);
            this.pnlLinhaDono.Name = "pnlLinhaDono";
            this.pnlLinhaDono.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaDono.TabIndex = 100;
            // 
            // txtCorPet
            // 
            this.txtCorPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorPet.Location = new System.Drawing.Point(85, 213);
            this.txtCorPet.Name = "txtCorPet";
            this.txtCorPet.PlaceholderText = "Cor";
            this.txtCorPet.Size = new System.Drawing.Size(200, 16);
            this.txtCorPet.TabIndex = 101;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.AutoSize = true;
            this.btnConfirmaAlteracao.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnConfirmaAlteracao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.White;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(190, 419);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(95, 40);
            this.btnConfirmaAlteracao.TabIndex = 102;
            this.btnConfirmaAlteracao.Text = "Concluir";
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = false;
            this.btnConfirmaAlteracao.Visible = false;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlPets);
            this.Name = "FormPets";
            this.Text = "PETS";
            this.Load += new System.EventHandler(this.FormPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipoPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacaPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortePet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDono)).EndInit();
            this.pnlPets.ResumeLayout(false);
            this.pnlPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCorPet)).EndInit();
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
        private Panel pnlMarcador2;
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
        private Panel pnlPets;
        private Panel pnlSBuscar;
        private Panel pnlSAlterar;
        private Panel pnlSRemover;
        private Button btnRemover;
        private Button btnAlterar;
        private Button btnBuscar;
        private Panel pnlLinhaNome;
        private PictureBox imgCorPet;
        private Panel pnlLinhaDono;
        private Panel pnlLinhaPorte;
        private Panel pnlLinhaRaca;
        private Panel pnlLinhaCor;
        private Panel pnlLinhaTipo;
        private TextBox txtCorPet;
        private Button btnConfirmaAlteracao;
    }
}