namespace SistemaPetShop.Forms
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.pnlHeaderFunc = new System.Windows.Forms.Panel();
            this.lblCadFuncionario = new System.Windows.Forms.Label();
            this.imgCadFuncionario = new System.Windows.Forms.PictureBox();
            this.pnlCadFuncionarios = new System.Windows.Forms.Panel();
            this.txtTelefoneFunc = new System.Windows.Forms.TextBox();
            this.txtCtpsFunc = new System.Windows.Forms.TextBox();
            this.lblCtpsFunc = new System.Windows.Forms.Label();
            this.cbCargoFunc = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.txtCpfFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblCpfFunc = new System.Windows.Forms.Label();
            this.lblTelefoneFunc = new System.Windows.Forms.Label();
            this.lblCargoFunc = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.pnlViewFunc = new System.Windows.Forms.Panel();
            this.imgMarcador = new System.Windows.Forms.PictureBox();
            this.imgBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgFuncionarios = new System.Windows.Forms.DataGridView();
            this.pnlHeaderFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadFuncionario)).BeginInit();
            this.pnlCadFuncionarios.SuspendLayout();
            this.pnlViewFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderFunc
            // 
            this.pnlHeaderFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlHeaderFunc.Controls.Add(this.lblCadFuncionario);
            this.pnlHeaderFunc.Controls.Add(this.imgCadFuncionario);
            this.pnlHeaderFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderFunc.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderFunc.Name = "pnlHeaderFunc";
            this.pnlHeaderFunc.Size = new System.Drawing.Size(341, 100);
            this.pnlHeaderFunc.TabIndex = 0;
            // 
            // lblCadFuncionario
            // 
            this.lblCadFuncionario.AutoSize = true;
            this.lblCadFuncionario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadFuncionario.Location = new System.Drawing.Point(26, 23);
            this.lblCadFuncionario.Name = "lblCadFuncionario";
            this.lblCadFuncionario.Size = new System.Drawing.Size(214, 25);
            this.lblCadFuncionario.TabIndex = 1;
            this.lblCadFuncionario.Text = "Cadastrar Funcionário:";
            // 
            // imgCadFuncionario
            // 
            this.imgCadFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("imgCadFuncionario.Image")));
            this.imgCadFuncionario.Location = new System.Drawing.Point(247, 23);
            this.imgCadFuncionario.Name = "imgCadFuncionario";
            this.imgCadFuncionario.Size = new System.Drawing.Size(64, 64);
            this.imgCadFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCadFuncionario.TabIndex = 0;
            this.imgCadFuncionario.TabStop = false;
            // 
            // pnlCadFuncionarios
            // 
            this.pnlCadFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlCadFuncionarios.Controls.Add(this.txtTelefoneFunc);
            this.pnlCadFuncionarios.Controls.Add(this.txtCtpsFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblCtpsFunc);
            this.pnlCadFuncionarios.Controls.Add(this.cbCargoFunc);
            this.pnlCadFuncionarios.Controls.Add(this.btnConfirmar);
            this.pnlCadFuncionarios.Controls.Add(this.btnCancelar);
            this.pnlCadFuncionarios.Controls.Add(this.txtEmailFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblEmailFunc);
            this.pnlCadFuncionarios.Controls.Add(this.txtCpfFunc);
            this.pnlCadFuncionarios.Controls.Add(this.txtNomeFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblCpfFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblTelefoneFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblCargoFunc);
            this.pnlCadFuncionarios.Controls.Add(this.lblNomeFunc);
            this.pnlCadFuncionarios.Controls.Add(this.pnlHeaderFunc);
            this.pnlCadFuncionarios.Controls.Add(this.pnlDivisao);
            this.pnlCadFuncionarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.pnlCadFuncionarios.Name = "pnlCadFuncionarios";
            this.pnlCadFuncionarios.Size = new System.Drawing.Size(346, 450);
            this.pnlCadFuncionarios.TabIndex = 1;
            // 
            // txtTelefoneFunc
            // 
            this.txtTelefoneFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefoneFunc.Location = new System.Drawing.Point(117, 192);
            this.txtTelefoneFunc.Name = "txtTelefoneFunc";
            this.txtTelefoneFunc.PlaceholderText = "Telefone";
            this.txtTelefoneFunc.Size = new System.Drawing.Size(198, 23);
            this.txtTelefoneFunc.TabIndex = 54;
            // 
            // txtCtpsFunc
            // 
            this.txtCtpsFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCtpsFunc.Location = new System.Drawing.Point(117, 282);
            this.txtCtpsFunc.Name = "txtCtpsFunc";
            this.txtCtpsFunc.PlaceholderText = "CTPS";
            this.txtCtpsFunc.Size = new System.Drawing.Size(198, 23);
            this.txtCtpsFunc.TabIndex = 61;
            // 
            // lblCtpsFunc
            // 
            this.lblCtpsFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCtpsFunc.AutoSize = true;
            this.lblCtpsFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCtpsFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCtpsFunc.ForeColor = System.Drawing.Color.Black;
            this.lblCtpsFunc.Location = new System.Drawing.Point(10, 282);
            this.lblCtpsFunc.Name = "lblCtpsFunc";
            this.lblCtpsFunc.Size = new System.Drawing.Size(51, 21);
            this.lblCtpsFunc.TabIndex = 60;
            this.lblCtpsFunc.Text = "CTPS:";
            // 
            // cbCargoFunc
            // 
            this.cbCargoFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCargoFunc.FormattingEnabled = true;
            this.cbCargoFunc.Location = new System.Drawing.Point(117, 222);
            this.cbCargoFunc.Name = "cbCargoFunc";
            this.cbCargoFunc.Size = new System.Drawing.Size(198, 23);
            this.cbCargoFunc.TabIndex = 59;
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
            // txtEmailFunc
            // 
            this.txtEmailFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailFunc.Location = new System.Drawing.Point(117, 252);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.PlaceholderText = "E-mail";
            this.txtEmailFunc.Size = new System.Drawing.Size(198, 23);
            this.txtEmailFunc.TabIndex = 56;
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmailFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailFunc.ForeColor = System.Drawing.Color.Black;
            this.lblEmailFunc.Location = new System.Drawing.Point(10, 252);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(58, 21);
            this.lblEmailFunc.TabIndex = 55;
            this.lblEmailFunc.Text = "E-mail:";
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfFunc.Location = new System.Drawing.Point(117, 162);
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.PlaceholderText = "CPF";
            this.txtCpfFunc.Size = new System.Drawing.Size(198, 23);
            this.txtCpfFunc.TabIndex = 53;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFunc.Location = new System.Drawing.Point(117, 132);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.PlaceholderText = "Nome Completo";
            this.txtNomeFunc.Size = new System.Drawing.Size(198, 23);
            this.txtNomeFunc.TabIndex = 52;
            // 
            // lblCpfFunc
            // 
            this.lblCpfFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpfFunc.AutoSize = true;
            this.lblCpfFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCpfFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpfFunc.ForeColor = System.Drawing.Color.Black;
            this.lblCpfFunc.Location = new System.Drawing.Point(10, 162);
            this.lblCpfFunc.Name = "lblCpfFunc";
            this.lblCpfFunc.Size = new System.Drawing.Size(41, 21);
            this.lblCpfFunc.TabIndex = 51;
            this.lblCpfFunc.Text = "CPF:";
            // 
            // lblTelefoneFunc
            // 
            this.lblTelefoneFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefoneFunc.AutoSize = true;
            this.lblTelefoneFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefoneFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefoneFunc.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneFunc.Location = new System.Drawing.Point(10, 192);
            this.lblTelefoneFunc.Name = "lblTelefoneFunc";
            this.lblTelefoneFunc.Size = new System.Drawing.Size(77, 21);
            this.lblTelefoneFunc.TabIndex = 50;
            this.lblTelefoneFunc.Text = "Telefone:";
            // 
            // lblCargoFunc
            // 
            this.lblCargoFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargoFunc.AutoSize = true;
            this.lblCargoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCargoFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargoFunc.ForeColor = System.Drawing.Color.Black;
            this.lblCargoFunc.Location = new System.Drawing.Point(10, 222);
            this.lblCargoFunc.Name = "lblCargoFunc";
            this.lblCargoFunc.Size = new System.Drawing.Size(58, 21);
            this.lblCargoFunc.TabIndex = 49;
            this.lblCargoFunc.Text = "Cargo:";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFunc.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFunc.Location = new System.Drawing.Point(10, 132);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(59, 21);
            this.lblNomeFunc.TabIndex = 48;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDivisao.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(5, 450);
            this.pnlDivisao.TabIndex = 62;
            // 
            // pnlViewFunc
            // 
            this.pnlViewFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlViewFunc.Controls.Add(this.imgMarcador);
            this.pnlViewFunc.Controls.Add(this.imgBusca);
            this.pnlViewFunc.Controls.Add(this.txtBusca);
            this.pnlViewFunc.Controls.Add(this.lblMsgError);
            this.pnlViewFunc.Controls.Add(this.btnRemover);
            this.pnlViewFunc.Controls.Add(this.btnAlterar);
            this.pnlViewFunc.Controls.Add(this.dgFuncionarios);
            this.pnlViewFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewFunc.Location = new System.Drawing.Point(346, 0);
            this.pnlViewFunc.Name = "pnlViewFunc";
            this.pnlViewFunc.Size = new System.Drawing.Size(454, 450);
            this.pnlViewFunc.TabIndex = 2;
            // 
            // imgMarcador
            // 
            this.imgMarcador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMarcador.Image = ((System.Drawing.Image)(resources.GetObject("imgMarcador.Image")));
            this.imgMarcador.Location = new System.Drawing.Point(399, 23);
            this.imgMarcador.Name = "imgMarcador";
            this.imgMarcador.Size = new System.Drawing.Size(32, 32);
            this.imgMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMarcador.TabIndex = 63;
            this.imgMarcador.TabStop = false;
            // 
            // imgBusca
            // 
            this.imgBusca.Image = ((System.Drawing.Image)(resources.GetObject("imgBusca.Image")));
            this.imgBusca.Location = new System.Drawing.Point(14, 62);
            this.imgBusca.Name = "imgBusca";
            this.imgBusca.Size = new System.Drawing.Size(32, 32);
            this.imgBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBusca.TabIndex = 65;
            this.imgBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(52, 71);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 64;
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
            // dgFuncionarios
            // 
            this.dgFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Location = new System.Drawing.Point(14, 106);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.RowTemplate.Height = 25;
            this.dgFuncionarios.Size = new System.Drawing.Size(417, 270);
            this.dgFuncionarios.TabIndex = 56;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewFunc);
            this.Controls.Add(this.pnlCadFuncionarios);
            this.Name = "FormFuncionarios";
            this.Text = "FUNCIONÁRIOS";
            this.pnlHeaderFunc.ResumeLayout(false);
            this.pnlHeaderFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadFuncionario)).EndInit();
            this.pnlCadFuncionarios.ResumeLayout(false);
            this.pnlCadFuncionarios.PerformLayout();
            this.pnlViewFunc.ResumeLayout(false);
            this.pnlViewFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeaderFunc;
        private Panel pnlCadFuncionarios;
        private Panel pnlViewFunc;
        private ComboBox cbCargoFunc;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtEmailFunc;
        private Label lblEmailFunc;
        private TextBox txtTelefoneFunc;
        private TextBox txtCpfFunc;
        private TextBox txtNomeFunc;
        private Label lblCpfFunc;
        private Label lblTelefoneFunc;
        private Label lblCargoFunc;
        private Label lblNomeFunc;
        private TextBox txtCtpsFunc;
        private Label lblCtpsFunc;
        private Panel pnlDivisao;
        private PictureBox imgCadFuncionario;
        private Label lblCadFuncionario;
        private Label lblMsgError;
        private Button btnRemover;
        private Button btnAlterar;
        private DataGridView dgFuncionarios;
        private PictureBox imgMarcador;
        private PictureBox imgBusca;
        private TextBox txtBusca;
    }
}