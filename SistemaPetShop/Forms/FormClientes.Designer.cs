namespace SistemaPetShop.Forms
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtEnderecoCli = new System.Windows.Forms.TextBox();
            this.txtTelefoneCli = new System.Windows.Forms.TextBox();
            this.txtCpfCli = new System.Windows.Forms.TextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.lblHeaderCli = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlMarcador = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblViewCli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.imgEmail = new System.Windows.Forms.PictureBox();
            this.imgBairro = new System.Windows.Forms.PictureBox();
            this.imgEndereco = new System.Windows.Forms.PictureBox();
            this.imgTelefone = new System.Windows.Forms.PictureBox();
            this.imgCpf = new System.Windows.Forms.PictureBox();
            this.imgCli = new System.Windows.Forms.PictureBox();
            this.pnlSBuscar = new System.Windows.Forms.Panel();
            this.pnlSAlterar = new System.Windows.Forms.Panel();
            this.pnlSRemover = new System.Windows.Forms.Panel();
            this.pnlSLimpar = new System.Windows.Forms.Panel();
            this.pnlSConfirmar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCli)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.BackColor = System.Drawing.Color.White;
            this.txtNomeCli.Location = new System.Drawing.Point(85, 96);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.PlaceholderText = "Nome";
            this.txtNomeCli.Size = new System.Drawing.Size(200, 23);
            this.txtNomeCli.TabIndex = 0;
            // 
            // txtEnderecoCli
            // 
            this.txtEnderecoCli.BackColor = System.Drawing.Color.White;
            this.txtEnderecoCli.Location = new System.Drawing.Point(85, 216);
            this.txtEnderecoCli.Name = "txtEnderecoCli";
            this.txtEnderecoCli.PlaceholderText = "Endereço";
            this.txtEnderecoCli.Size = new System.Drawing.Size(200, 23);
            this.txtEnderecoCli.TabIndex = 7;
            // 
            // txtTelefoneCli
            // 
            this.txtTelefoneCli.BackColor = System.Drawing.Color.White;
            this.txtTelefoneCli.Location = new System.Drawing.Point(85, 176);
            this.txtTelefoneCli.Name = "txtTelefoneCli";
            this.txtTelefoneCli.PlaceholderText = "Telefone";
            this.txtTelefoneCli.Size = new System.Drawing.Size(200, 23);
            this.txtTelefoneCli.TabIndex = 8;
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.BackColor = System.Drawing.Color.White;
            this.txtCpfCli.Location = new System.Drawing.Point(85, 136);
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.PlaceholderText = "CPF";
            this.txtCpfCli.Size = new System.Drawing.Size(200, 23);
            this.txtCpfCli.TabIndex = 9;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.BackColor = System.Drawing.Color.White;
            this.txtEmailCli.Location = new System.Drawing.Point(85, 296);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.PlaceholderText = "E-mail";
            this.txtEmailCli.Size = new System.Drawing.Size(200, 23);
            this.txtEmailCli.TabIndex = 21;
            // 
            // lblHeaderCli
            // 
            this.lblHeaderCli.AutoSize = true;
            this.lblHeaderCli.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderCli.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderCli.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderCli.Location = new System.Drawing.Point(22, 26);
            this.lblHeaderCli.Name = "lblHeaderCli";
            this.lblHeaderCli.Size = new System.Drawing.Size(174, 23);
            this.lblHeaderCli.TabIndex = 1;
            this.lblHeaderCli.Text = "Cadastrar Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(47, 367);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 40);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(690, 367);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgClientes
            // 
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(375, 140);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.Size = new System.Drawing.Size(413, 221);
            this.dgClientes.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 367);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 40);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnAlterar.Location = new System.Drawing.Point(586, 367);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 40);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlMarcador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador.Location = new System.Drawing.Point(22, 52);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(280, 5);
            this.pnlMarcador.TabIndex = 10;
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
            this.btnRemover.Location = new System.Drawing.Point(482, 367);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 40);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // lblMsgError
            // 
            this.lblMsgError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(22, 427);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 25;
            this.lblMsgError.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(85, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Bairro";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 27;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(375, 111);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBusca.Size = new System.Drawing.Size(218, 23);
            this.txtBusca.TabIndex = 14;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
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
            this.lblViewCli.Size = new System.Drawing.Size(205, 23);
            this.lblViewCli.TabIndex = 23;
            this.lblViewCli.Text = "Clientes Registrados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(375, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 5);
            this.panel1.TabIndex = 22;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlClientes.Controls.Add(this.imgEmail);
            this.pnlClientes.Controls.Add(this.imgBairro);
            this.pnlClientes.Controls.Add(this.imgEndereco);
            this.pnlClientes.Controls.Add(this.imgTelefone);
            this.pnlClientes.Controls.Add(this.imgCpf);
            this.pnlClientes.Controls.Add(this.imgCli);
            this.pnlClientes.Controls.Add(this.pnlSBuscar);
            this.pnlClientes.Controls.Add(this.pnlSAlterar);
            this.pnlClientes.Controls.Add(this.pnlSRemover);
            this.pnlClientes.Controls.Add(this.pnlSLimpar);
            this.pnlClientes.Controls.Add(this.pnlSConfirmar);
            this.pnlClientes.Controls.Add(this.txtNomeCli);
            this.pnlClientes.Controls.Add(this.txtCpfCli);
            this.pnlClientes.Controls.Add(this.txtEmailCli);
            this.pnlClientes.Controls.Add(this.txtTelefoneCli);
            this.pnlClientes.Controls.Add(this.txtEnderecoCli);
            this.pnlClientes.Controls.Add(this.panel1);
            this.pnlClientes.Controls.Add(this.lblViewCli);
            this.pnlClientes.Controls.Add(this.txtBusca);
            this.pnlClientes.Controls.Add(this.textBox1);
            this.pnlClientes.Controls.Add(this.label1);
            this.pnlClientes.Controls.Add(this.lblMsgError);
            this.pnlClientes.Controls.Add(this.btnRemover);
            this.pnlClientes.Controls.Add(this.pnlMarcador);
            this.pnlClientes.Controls.Add(this.btnAlterar);
            this.pnlClientes.Controls.Add(this.btnConfirmar);
            this.pnlClientes.Controls.Add(this.dgClientes);
            this.pnlClientes.Controls.Add(this.btnBuscar);
            this.pnlClientes.Controls.Add(this.btnLimpar);
            this.pnlClientes.Controls.Add(this.lblHeaderCli);
            this.pnlClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(800, 451);
            this.pnlClientes.TabIndex = 26;
            // 
            // imgEmail
            // 
            this.imgEmail.Image = ((System.Drawing.Image)(resources.GetObject("imgEmail.Image")));
            this.imgEmail.Location = new System.Drawing.Point(47, 287);
            this.imgEmail.Name = "imgEmail";
            this.imgEmail.Size = new System.Drawing.Size(32, 32);
            this.imgEmail.TabIndex = 38;
            this.imgEmail.TabStop = false;
            // 
            // imgBairro
            // 
            this.imgBairro.Image = ((System.Drawing.Image)(resources.GetObject("imgBairro.Image")));
            this.imgBairro.Location = new System.Drawing.Point(47, 247);
            this.imgBairro.Name = "imgBairro";
            this.imgBairro.Size = new System.Drawing.Size(32, 32);
            this.imgBairro.TabIndex = 37;
            this.imgBairro.TabStop = false;
            // 
            // imgEndereco
            // 
            this.imgEndereco.Image = ((System.Drawing.Image)(resources.GetObject("imgEndereco.Image")));
            this.imgEndereco.Location = new System.Drawing.Point(47, 207);
            this.imgEndereco.Name = "imgEndereco";
            this.imgEndereco.Size = new System.Drawing.Size(32, 32);
            this.imgEndereco.TabIndex = 36;
            this.imgEndereco.TabStop = false;
            // 
            // imgTelefone
            // 
            this.imgTelefone.Image = ((System.Drawing.Image)(resources.GetObject("imgTelefone.Image")));
            this.imgTelefone.Location = new System.Drawing.Point(47, 167);
            this.imgTelefone.Name = "imgTelefone";
            this.imgTelefone.Size = new System.Drawing.Size(32, 32);
            this.imgTelefone.TabIndex = 35;
            this.imgTelefone.TabStop = false;
            // 
            // imgCpf
            // 
            this.imgCpf.Image = ((System.Drawing.Image)(resources.GetObject("imgCpf.Image")));
            this.imgCpf.Location = new System.Drawing.Point(47, 127);
            this.imgCpf.Name = "imgCpf";
            this.imgCpf.Size = new System.Drawing.Size(32, 32);
            this.imgCpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCpf.TabIndex = 34;
            this.imgCpf.TabStop = false;
            // 
            // imgCli
            // 
            this.imgCli.Image = ((System.Drawing.Image)(resources.GetObject("imgCli.Image")));
            this.imgCli.Location = new System.Drawing.Point(47, 87);
            this.imgCli.Name = "imgCli";
            this.imgCli.Size = new System.Drawing.Size(32, 32);
            this.imgCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCli.TabIndex = 33;
            this.imgCli.TabStop = false;
            // 
            // pnlSBuscar
            // 
            this.pnlSBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSBuscar.Location = new System.Drawing.Point(690, 413);
            this.pnlSBuscar.Name = "pnlSBuscar";
            this.pnlSBuscar.Size = new System.Drawing.Size(98, 3);
            this.pnlSBuscar.TabIndex = 30;
            // 
            // pnlSAlterar
            // 
            this.pnlSAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSAlterar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSAlterar.Location = new System.Drawing.Point(586, 413);
            this.pnlSAlterar.Name = "pnlSAlterar";
            this.pnlSAlterar.Size = new System.Drawing.Size(98, 3);
            this.pnlSAlterar.TabIndex = 32;
            // 
            // pnlSRemover
            // 
            this.pnlSRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSRemover.Location = new System.Drawing.Point(482, 413);
            this.pnlSRemover.Name = "pnlSRemover";
            this.pnlSRemover.Size = new System.Drawing.Size(98, 3);
            this.pnlSRemover.TabIndex = 31;
            // 
            // pnlSLimpar
            // 
            this.pnlSLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlSLimpar.Location = new System.Drawing.Point(47, 413);
            this.pnlSLimpar.Name = "pnlSLimpar";
            this.pnlSLimpar.Size = new System.Drawing.Size(77, 3);
            this.pnlSLimpar.TabIndex = 30;
            // 
            // pnlSConfirmar
            // 
            this.pnlSConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSConfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlSConfirmar.Location = new System.Drawing.Point(190, 413);
            this.pnlSConfirmar.Name = "pnlSConfirmar";
            this.pnlSConfirmar.Size = new System.Drawing.Size(95, 3);
            this.pnlSConfirmar.TabIndex = 29;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.pnlClientes);
            this.Name = "FormClientes";
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtNomeCli;
        private TextBox txtEnderecoCli;
        private TextBox txtTelefoneCli;
        private TextBox txtCpfCli;
        private TextBox txtEmailCli;
        private Label lblHeaderCli;
        private Button btnLimpar;
        private Button btnBuscar;
        private DataGridView dgClientes;
        private Button btnConfirmar;
        private Button btnAlterar;
        private Panel pnlMarcador;
        private Button btnRemover;
        private Label lblMsgError;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtBusca;
        private Label lblViewCli;
        private Panel panel1;
        private Panel pnlClientes;
        private Panel pnlSBuscar;
        private Panel pnlSAlterar;
        private Panel pnlSRemover;
        private Panel pnlSLimpar;
        private Panel pnlSConfirmar;
        private PictureBox imgCpf;
        private PictureBox imgCli;
        private PictureBox imgEmail;
        private PictureBox imgBairro;
        private PictureBox imgEndereco;
        private PictureBox imgTelefone;
    }
}