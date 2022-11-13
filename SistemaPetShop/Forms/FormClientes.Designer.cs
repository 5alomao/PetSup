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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCadCli = new System.Windows.Forms.Label();
            this.pnlDivisao = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.BackColor = System.Drawing.Color.Teal;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(540, 355);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 38);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Altearar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(188, 355);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 38);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // dgClientes
            // 
            this.dgClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(362, 79);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.Size = new System.Drawing.Size(417, 270);
            this.dgClientes.TabIndex = 35;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.Location = new System.Drawing.Point(362, 39);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite aqui para buscar";
            this.txtBusca.Size = new System.Drawing.Size(239, 23);
            this.txtBusca.TabIndex = 36;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 123);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 21);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(87, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 38);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeCliente.Location = new System.Drawing.Point(96, 123);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PlaceholderText = "Nome Completo";
            this.txtNomeCliente.Size = new System.Drawing.Size(208, 23);
            this.txtNomeCliente.TabIndex = 22;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(659, 355);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 38);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(677, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 38);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderecoCliente.Location = new System.Drawing.Point(96, 243);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.PlaceholderText = "Endereço";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(208, 23);
            this.txtEnderecoCliente.TabIndex = 23;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpfCliente.Location = new System.Drawing.Point(96, 153);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.PlaceholderText = "CPF";
            this.txtCpfCliente.Size = new System.Drawing.Size(208, 23);
            this.txtCpfCliente.TabIndex = 24;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(96, 183);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.PlaceholderText = "Telefone";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(208, 23);
            this.txtTelefoneCliente.TabIndex = 25;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpf.AutoSize = true;
            this.lblCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(12, 153);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 21);
            this.lblCpf.TabIndex = 28;
            this.lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(12, 243);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(83, 21);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(12, 183);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 21);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailCliente.Location = new System.Drawing.Point(96, 213);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.PlaceholderText = "E-mail";
            this.txtEmailCliente.Size = new System.Drawing.Size(208, 23);
            this.txtEmailCliente.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(12, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 21);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCadCli
            // 
            this.lblCadCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadCli.AutoSize = true;
            this.lblCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadCli.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadCli.Location = new System.Drawing.Point(12, 39);
            this.lblCadCli.Name = "lblCadCli";
            this.lblCadCli.Size = new System.Drawing.Size(168, 25);
            this.lblCadCli.TabIndex = 38;
            this.lblCadCli.Text = "Cadastrar Cliente:";
            // 
            // pnlDivisao
            // 
            this.pnlDivisao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDivisao.BackColor = System.Drawing.Color.Black;
            this.pnlDivisao.Location = new System.Drawing.Point(341, 0);
            this.pnlDivisao.Name = "pnlDivisao";
            this.pnlDivisao.Size = new System.Drawing.Size(3, 452);
            this.pnlDivisao.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsgError.Location = new System.Drawing.Point(12, 408);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(12, 15);
            this.lblMsgError.TabIndex = 41;
            this.lblMsgError.Text = "*";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsgError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlDivisao);
            this.Controls.Add(this.lblCadCli);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmail);
            this.Name = "FormClientes";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAlterar;
        private Button btnConfirmar;
        private DataGridView dgClientes;
        private TextBox txtBusca;
        private Label lblNome;
        private Button btnCancelar;
        private TextBox txtNomeCliente;
        private Button btnRemover;
        private Button btnBuscar;
        private TextBox txtEnderecoCliente;
        private TextBox txtCpfCliente;
        private TextBox txtTelefoneCliente;
        private Label lblCpf;
        private Label lblEndereco;
        private Label lblTelefone;
        private TextBox txtEmailCliente;
        private Label lblEmail;
        private Label lblCadCli;
        private Panel pnlDivisao;
        private PictureBox pictureBox1;
        private Label lblMsgError;
    }
}