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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.imgCadCli = new System.Windows.Forms.PictureBox();
            this.lblCadCli = new System.Windows.Forms.Label();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlHeaderCli = new System.Windows.Forms.Panel();
            this.pnlViewCli = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadCli)).BeginInit();
            this.pnlFundo.SuspendLayout();
            this.pnlHeaderCli.SuspendLayout();
            this.pnlViewCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(14, 106);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.Size = new System.Drawing.Size(417, 270);
            this.dgClientes.TabIndex = 35;
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDivisao.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(5, 450);
            this.pnlDivisao.TabIndex = 39;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(14, 23);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 41;
            this.lblMsgError.Text = "*";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoCliente.Location = new System.Drawing.Point(117, 252);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.PlaceholderText = "Endereço";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(208, 23);
            this.txtEnderecoCliente.TabIndex = 23;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailCliente.Location = new System.Drawing.Point(117, 222);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.PlaceholderText = "E-mail";
            this.txtEmailCliente.Size = new System.Drawing.Size(208, 23);
            this.txtEmailCliente.TabIndex = 26;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(117, 192);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.PlaceholderText = "Telefone";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(208, 23);
            this.txtTelefoneCliente.TabIndex = 25;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfCliente.Location = new System.Drawing.Point(117, 162);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.PlaceholderText = "CPF";
            this.txtCpfCliente.Size = new System.Drawing.Size(208, 23);
            this.txtCpfCliente.TabIndex = 24;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(117, 132);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PlaceholderText = "Nome Completo";
            this.txtNomeCliente.Size = new System.Drawing.Size(208, 23);
            this.txtNomeCliente.TabIndex = 22;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(10, 252);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(83, 21);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "Endereço:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(329, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 38);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(10, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 21);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(306, 382);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 38);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(14, 64);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 36;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(10, 192);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 21);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpf.AutoSize = true;
            this.lblCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(10, 162);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 21);
            this.lblCpf.TabIndex = 28;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(10, 132);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 21);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome: ";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BackColor = System.Drawing.Color.Teal;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(187, 382);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 38);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(109, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 38);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(209, 385);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 38);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // imgCadCli
            // 
            this.imgCadCli.Image = ((System.Drawing.Image)(resources.GetObject("imgCadCli.Image")));
            this.imgCadCli.Location = new System.Drawing.Point(247, 23);
            this.imgCadCli.Name = "imgCadCli";
            this.imgCadCli.Size = new System.Drawing.Size(64, 64);
            this.imgCadCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCadCli.TabIndex = 40;
            this.imgCadCli.TabStop = false;
            // 
            // lblCadCli
            // 
            this.lblCadCli.AutoSize = true;
            this.lblCadCli.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadCli.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadCli.Location = new System.Drawing.Point(26, 23);
            this.lblCadCli.Name = "lblCadCli";
            this.lblCadCli.Size = new System.Drawing.Size(168, 25);
            this.lblCadCli.TabIndex = 38;
            this.lblCadCli.Text = "Cadastrar Cliente:";
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlFundo.Controls.Add(this.pnlHeaderCli);
            this.pnlFundo.Controls.Add(this.btnConfirmar);
            this.pnlFundo.Controls.Add(this.pnlDivisao);
            this.pnlFundo.Controls.Add(this.lblNome);
            this.pnlFundo.Controls.Add(this.btnCancelar);
            this.pnlFundo.Controls.Add(this.lblEndereco);
            this.pnlFundo.Controls.Add(this.lblEmail);
            this.pnlFundo.Controls.Add(this.txtEnderecoCliente);
            this.pnlFundo.Controls.Add(this.txtNomeCliente);
            this.pnlFundo.Controls.Add(this.lblCpf);
            this.pnlFundo.Controls.Add(this.txtEmailCliente);
            this.pnlFundo.Controls.Add(this.txtCpfCliente);
            this.pnlFundo.Controls.Add(this.lblTelefone);
            this.pnlFundo.Controls.Add(this.txtTelefoneCliente);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(346, 450);
            this.pnlFundo.TabIndex = 42;
            // 
            // pnlHeaderCli
            // 
            this.pnlHeaderCli.Controls.Add(this.imgCadCli);
            this.pnlHeaderCli.Controls.Add(this.lblCadCli);
            this.pnlHeaderCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCli.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCli.Name = "pnlHeaderCli";
            this.pnlHeaderCli.Size = new System.Drawing.Size(341, 100);
            this.pnlHeaderCli.TabIndex = 40;
            // 
            // pnlViewCli
            // 
            this.pnlViewCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlViewCli.Controls.Add(this.txtBusca);
            this.pnlViewCli.Controls.Add(this.lblMsgError);
            this.pnlViewCli.Controls.Add(this.btnRemover);
            this.pnlViewCli.Controls.Add(this.btnAlterar);
            this.pnlViewCli.Controls.Add(this.dgClientes);
            this.pnlViewCli.Controls.Add(this.btnBuscar);
            this.pnlViewCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewCli.Location = new System.Drawing.Point(346, 0);
            this.pnlViewCli.Name = "pnlViewCli";
            this.pnlViewCli.Size = new System.Drawing.Size(454, 450);
            this.pnlViewCli.TabIndex = 43;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewCli);
            this.Controls.Add(this.pnlFundo);
            this.Name = "FormClientes";
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadCli)).EndInit();
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.pnlHeaderCli.ResumeLayout(false);
            this.pnlHeaderCli.PerformLayout();
            this.pnlViewCli.ResumeLayout(false);
            this.pnlViewCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgClientes;
        private Panel pnlDivisao;
        private Label lblMsgError;
        private TextBox txtEnderecoCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefoneCliente;
        private TextBox txtCpfCliente;
        private TextBox txtNomeCliente;
        private Label lblEndereco;
        private Button btnBuscar;
        private Label lblEmail;
        private Button btnRemover;
        private TextBox txtBusca;
        private Label lblTelefone;
        private Label lblCpf;
        private Label lblNome;
        private Button btnAlterar;
        private Button btnCancelar;
        private Button btnConfirmar;
        private PictureBox imgCadCli;
        private Label lblCadCli;
        private Panel pnlFundo;
        private Panel pnlHeaderCli;
        private Panel pnlViewCli;
    }
}