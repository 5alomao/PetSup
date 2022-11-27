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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlMarcador = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblViewCli = new System.Windows.Forms.Label();
            this.pnlMarcador2 = new System.Windows.Forms.Panel();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.pnlLinhaBairro = new System.Windows.Forms.Panel();
            this.pnlLinhaEndereco = new System.Windows.Forms.Panel();
            this.pnlLinhaEmail = new System.Windows.Forms.Panel();
            this.pnlLinhaTelefone = new System.Windows.Forms.Panel();
            this.pnlLinhaCpf = new System.Windows.Forms.Panel();
            this.pnlLinhaNome = new System.Windows.Forms.Panel();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.imgEmail = new System.Windows.Forms.PictureBox();
            this.imgBairro = new System.Windows.Forms.PictureBox();
            this.imgEndereco = new System.Windows.Forms.PictureBox();
            this.imgTelefone = new System.Windows.Forms.PictureBox();
            this.imgCpf = new System.Windows.Forms.PictureBox();
            this.imgCli = new System.Windows.Forms.PictureBox();
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
            this.txtNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCli.Location = new System.Drawing.Point(85, 113);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.PlaceholderText = "Nome";
            this.txtNomeCli.Size = new System.Drawing.Size(200, 16);
            this.txtNomeCli.TabIndex = 0;
            // 
            // txtEnderecoCli
            // 
            this.txtEnderecoCli.BackColor = System.Drawing.Color.White;
            this.txtEnderecoCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnderecoCli.Location = new System.Drawing.Point(85, 313);
            this.txtEnderecoCli.Name = "txtEnderecoCli";
            this.txtEnderecoCli.PlaceholderText = "Endereço";
            this.txtEnderecoCli.Size = new System.Drawing.Size(200, 16);
            this.txtEnderecoCli.TabIndex = 7;
            // 
            // txtTelefoneCli
            // 
            this.txtTelefoneCli.BackColor = System.Drawing.Color.White;
            this.txtTelefoneCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefoneCli.Location = new System.Drawing.Point(85, 213);
            this.txtTelefoneCli.Name = "txtTelefoneCli";
            this.txtTelefoneCli.PlaceholderText = "Telefone";
            this.txtTelefoneCli.Size = new System.Drawing.Size(200, 16);
            this.txtTelefoneCli.TabIndex = 8;
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.BackColor = System.Drawing.Color.White;
            this.txtCpfCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfCli.Location = new System.Drawing.Point(85, 163);
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.PlaceholderText = "CPF";
            this.txtCpfCli.Size = new System.Drawing.Size(200, 16);
            this.txtCpfCli.TabIndex = 9;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.BackColor = System.Drawing.Color.White;
            this.txtEmailCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailCli.Location = new System.Drawing.Point(85, 263);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.PlaceholderText = "E-mail";
            this.txtEmailCli.Size = new System.Drawing.Size(200, 16);
            this.txtEmailCli.TabIndex = 21;
            // 
            // lblHeaderCli
            // 
            this.lblHeaderCli.AutoSize = true;
            this.lblHeaderCli.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderCli.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderCli.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderCli.Location = new System.Drawing.Point(47, 44);
            this.lblHeaderCli.Name = "lblHeaderCli";
            this.lblHeaderCli.Size = new System.Drawing.Size(198, 23);
            this.lblHeaderCli.TabIndex = 1;
            this.lblHeaderCli.Text = "Cadastrar Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(47, 419);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 40);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(375, 140);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.Size = new System.Drawing.Size(587, 332);
            this.dgClientes.TabIndex = 12;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 419);
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
            this.btnAlterar.BackColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(864, 478);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 40);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.Black;
            this.pnlMarcador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador.Location = new System.Drawing.Point(47, 70);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(238, 3);
            this.pnlMarcador.TabIndex = 10;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.AutoSize = true;
            this.btnRemover.BackColor = System.Drawing.Color.Black;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(760, 478);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 40);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblMsgError
            // 
            this.lblMsgError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(22, 538);
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
            // txtBairroCli
            // 
            this.txtBairroCli.BackColor = System.Drawing.Color.White;
            this.txtBairroCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairroCli.Location = new System.Drawing.Point(85, 363);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.PlaceholderText = "Bairro";
            this.txtBairroCli.Size = new System.Drawing.Size(200, 16);
            this.txtBairroCli.TabIndex = 27;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(375, 110);
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
            this.lblViewCli.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewCli.ForeColor = System.Drawing.Color.Black;
            this.lblViewCli.Location = new System.Drawing.Point(375, 44);
            this.lblViewCli.Name = "lblViewCli";
            this.lblViewCli.Size = new System.Drawing.Size(232, 23);
            this.lblViewCli.TabIndex = 23;
            this.lblViewCli.Text = "Clientes Registrados";
            // 
            // pnlMarcador2
            // 
            this.pnlMarcador2.BackColor = System.Drawing.Color.Black;
            this.pnlMarcador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcador2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMarcador2.Location = new System.Drawing.Point(375, 70);
            this.pnlMarcador2.Name = "pnlMarcador2";
            this.pnlMarcador2.Size = new System.Drawing.Size(434, 3);
            this.pnlMarcador2.TabIndex = 22;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientes.BackColor = System.Drawing.Color.White;
            this.pnlClientes.Controls.Add(this.pnlLinhaBairro);
            this.pnlClientes.Controls.Add(this.pnlLinhaEndereco);
            this.pnlClientes.Controls.Add(this.pnlLinhaEmail);
            this.pnlClientes.Controls.Add(this.pnlLinhaTelefone);
            this.pnlClientes.Controls.Add(this.pnlLinhaCpf);
            this.pnlClientes.Controls.Add(this.pnlLinhaNome);
            this.pnlClientes.Controls.Add(this.btnConfirmaAlteracao);
            this.pnlClientes.Controls.Add(this.imgEmail);
            this.pnlClientes.Controls.Add(this.imgBairro);
            this.pnlClientes.Controls.Add(this.imgEndereco);
            this.pnlClientes.Controls.Add(this.imgTelefone);
            this.pnlClientes.Controls.Add(this.imgCpf);
            this.pnlClientes.Controls.Add(this.imgCli);
            this.pnlClientes.Controls.Add(this.pnlSAlterar);
            this.pnlClientes.Controls.Add(this.pnlSRemover);
            this.pnlClientes.Controls.Add(this.pnlSLimpar);
            this.pnlClientes.Controls.Add(this.pnlSConfirmar);
            this.pnlClientes.Controls.Add(this.txtNomeCli);
            this.pnlClientes.Controls.Add(this.txtCpfCli);
            this.pnlClientes.Controls.Add(this.txtEmailCli);
            this.pnlClientes.Controls.Add(this.txtTelefoneCli);
            this.pnlClientes.Controls.Add(this.txtEnderecoCli);
            this.pnlClientes.Controls.Add(this.pnlMarcador2);
            this.pnlClientes.Controls.Add(this.lblViewCli);
            this.pnlClientes.Controls.Add(this.txtBusca);
            this.pnlClientes.Controls.Add(this.txtBairroCli);
            this.pnlClientes.Controls.Add(this.label1);
            this.pnlClientes.Controls.Add(this.lblMsgError);
            this.pnlClientes.Controls.Add(this.btnRemover);
            this.pnlClientes.Controls.Add(this.pnlMarcador);
            this.pnlClientes.Controls.Add(this.btnAlterar);
            this.pnlClientes.Controls.Add(this.btnConfirmar);
            this.pnlClientes.Controls.Add(this.dgClientes);
            this.pnlClientes.Controls.Add(this.btnLimpar);
            this.pnlClientes.Controls.Add(this.lblHeaderCli);
            this.pnlClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(974, 562);
            this.pnlClientes.TabIndex = 26;
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // pnlLinhaBairro
            // 
            this.pnlLinhaBairro.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaBairro.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaBairro.Location = new System.Drawing.Point(85, 381);
            this.pnlLinhaBairro.Name = "pnlLinhaBairro";
            this.pnlLinhaBairro.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaBairro.TabIndex = 45;
            // 
            // pnlLinhaEndereco
            // 
            this.pnlLinhaEndereco.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaEndereco.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaEndereco.Location = new System.Drawing.Point(85, 331);
            this.pnlLinhaEndereco.Name = "pnlLinhaEndereco";
            this.pnlLinhaEndereco.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaEndereco.TabIndex = 44;
            // 
            // pnlLinhaEmail
            // 
            this.pnlLinhaEmail.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaEmail.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaEmail.Location = new System.Drawing.Point(85, 281);
            this.pnlLinhaEmail.Name = "pnlLinhaEmail";
            this.pnlLinhaEmail.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaEmail.TabIndex = 43;
            // 
            // pnlLinhaTelefone
            // 
            this.pnlLinhaTelefone.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaTelefone.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaTelefone.Location = new System.Drawing.Point(85, 231);
            this.pnlLinhaTelefone.Name = "pnlLinhaTelefone";
            this.pnlLinhaTelefone.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaTelefone.TabIndex = 42;
            // 
            // pnlLinhaCpf
            // 
            this.pnlLinhaCpf.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaCpf.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaCpf.Location = new System.Drawing.Point(85, 181);
            this.pnlLinhaCpf.Name = "pnlLinhaCpf";
            this.pnlLinhaCpf.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaCpf.TabIndex = 41;
            // 
            // pnlLinhaNome
            // 
            this.pnlLinhaNome.BackColor = System.Drawing.Color.Black;
            this.pnlLinhaNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinhaNome.ForeColor = System.Drawing.Color.Black;
            this.pnlLinhaNome.Location = new System.Drawing.Point(85, 131);
            this.pnlLinhaNome.Name = "pnlLinhaNome";
            this.pnlLinhaNome.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaNome.TabIndex = 40;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.AutoSize = true;
            this.btnConfirmaAlteracao.BackColor = System.Drawing.Color.Black;
            this.btnConfirmaAlteracao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.White;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(190, 419);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(95, 40);
            this.btnConfirmaAlteracao.TabIndex = 39;
            this.btnConfirmaAlteracao.Text = "Concluir";
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = false;
            this.btnConfirmaAlteracao.Visible = false;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click_1);
            // 
            // imgEmail
            // 
            this.imgEmail.BackColor = System.Drawing.Color.Transparent;
            this.imgEmail.Image = ((System.Drawing.Image)(resources.GetObject("imgEmail.Image")));
            this.imgEmail.Location = new System.Drawing.Point(47, 251);
            this.imgEmail.Name = "imgEmail";
            this.imgEmail.Size = new System.Drawing.Size(32, 32);
            this.imgEmail.TabIndex = 38;
            this.imgEmail.TabStop = false;
            // 
            // imgBairro
            // 
            this.imgBairro.BackColor = System.Drawing.Color.Transparent;
            this.imgBairro.Image = ((System.Drawing.Image)(resources.GetObject("imgBairro.Image")));
            this.imgBairro.Location = new System.Drawing.Point(47, 351);
            this.imgBairro.Name = "imgBairro";
            this.imgBairro.Size = new System.Drawing.Size(32, 32);
            this.imgBairro.TabIndex = 37;
            this.imgBairro.TabStop = false;
            // 
            // imgEndereco
            // 
            this.imgEndereco.BackColor = System.Drawing.Color.Transparent;
            this.imgEndereco.Image = ((System.Drawing.Image)(resources.GetObject("imgEndereco.Image")));
            this.imgEndereco.Location = new System.Drawing.Point(47, 301);
            this.imgEndereco.Name = "imgEndereco";
            this.imgEndereco.Size = new System.Drawing.Size(32, 32);
            this.imgEndereco.TabIndex = 36;
            this.imgEndereco.TabStop = false;
            // 
            // imgTelefone
            // 
            this.imgTelefone.BackColor = System.Drawing.Color.Transparent;
            this.imgTelefone.Image = ((System.Drawing.Image)(resources.GetObject("imgTelefone.Image")));
            this.imgTelefone.Location = new System.Drawing.Point(47, 201);
            this.imgTelefone.Name = "imgTelefone";
            this.imgTelefone.Size = new System.Drawing.Size(32, 32);
            this.imgTelefone.TabIndex = 35;
            this.imgTelefone.TabStop = false;
            // 
            // imgCpf
            // 
            this.imgCpf.BackColor = System.Drawing.Color.Transparent;
            this.imgCpf.Image = ((System.Drawing.Image)(resources.GetObject("imgCpf.Image")));
            this.imgCpf.Location = new System.Drawing.Point(47, 151);
            this.imgCpf.Name = "imgCpf";
            this.imgCpf.Size = new System.Drawing.Size(32, 32);
            this.imgCpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCpf.TabIndex = 34;
            this.imgCpf.TabStop = false;
            // 
            // imgCli
            // 
            this.imgCli.BackColor = System.Drawing.Color.Transparent;
            this.imgCli.Image = ((System.Drawing.Image)(resources.GetObject("imgCli.Image")));
            this.imgCli.Location = new System.Drawing.Point(47, 101);
            this.imgCli.Name = "imgCli";
            this.imgCli.Size = new System.Drawing.Size(32, 32);
            this.imgCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCli.TabIndex = 33;
            this.imgCli.TabStop = false;
            // 
            // pnlSAlterar
            // 
            this.pnlSAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSAlterar.BackColor = System.Drawing.Color.Black;
            this.pnlSAlterar.Location = new System.Drawing.Point(864, 524);
            this.pnlSAlterar.Name = "pnlSAlterar";
            this.pnlSAlterar.Size = new System.Drawing.Size(98, 3);
            this.pnlSAlterar.TabIndex = 32;
            // 
            // pnlSRemover
            // 
            this.pnlSRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSRemover.BackColor = System.Drawing.Color.Black;
            this.pnlSRemover.Location = new System.Drawing.Point(760, 526);
            this.pnlSRemover.Name = "pnlSRemover";
            this.pnlSRemover.Size = new System.Drawing.Size(98, 3);
            this.pnlSRemover.TabIndex = 31;
            // 
            // pnlSLimpar
            // 
            this.pnlSLimpar.BackColor = System.Drawing.Color.Black;
            this.pnlSLimpar.Location = new System.Drawing.Point(47, 465);
            this.pnlSLimpar.Name = "pnlSLimpar";
            this.pnlSLimpar.Size = new System.Drawing.Size(77, 3);
            this.pnlSLimpar.TabIndex = 30;
            // 
            // pnlSConfirmar
            // 
            this.pnlSConfirmar.BackColor = System.Drawing.Color.Black;
            this.pnlSConfirmar.Location = new System.Drawing.Point(190, 465);
            this.pnlSConfirmar.Name = "pnlSConfirmar";
            this.pnlSConfirmar.Size = new System.Drawing.Size(95, 3);
            this.pnlSConfirmar.TabIndex = 29;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 562);
            this.Controls.Add(this.pnlClientes);
            this.Name = "FormClientes";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FormClientes_Load);
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
        private DataGridView dgClientes;
        private Button btnConfirmar;
        private Button btnAlterar;
        private Panel pnlMarcador;
        private Button btnRemover;
        private Label lblMsgError;
        private Label label1;
        private TextBox txtBairroCli;
        private TextBox txtBusca;
        private Label lblViewCli;
        private Panel pnlMarcador2;
        private Panel pnlClientes;
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
        private Button btnConfirmaAlteracao;
        private Panel pnlLinhaBairro;
        private Panel pnlLinhaEndereco;
        private Panel pnlLinhaEmail;
        private Panel pnlLinhaTelefone;
        private Panel pnlLinhaCpf;
        private Panel pnlLinhaNome;
    }
}