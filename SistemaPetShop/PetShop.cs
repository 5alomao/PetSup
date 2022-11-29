using System.Data;
using System.Runtime.InteropServices.ObjectiveC;

namespace SistemaPetShop
{
    public partial class PetShop : Form
    {
        public PetShop()
        {
            InitializeComponent();
        }

        private void PetShop_Load(object sender, EventArgs e)
        {
            DesativaPnl();
            listaCliente();
            listaPet();
        }
    
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlProdutos.Visible = true;
            btnProdutos.BackColor = Color.FromArgb(97,24,96);
            pnlCima.BackColor = Color.FromArgb(97,24,96);
            btnLogo.BackColor = Color.FromArgb(80,02,80);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlFuncionarios.Visible = true;
            btnFuncionarios.BackColor = Color.DarkCyan;
            pnlCima.BackColor = Color.DarkCyan;
            btnLogo.BackColor = Color.Teal;  
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlVendas.Visible = true;
            btnVendas.BackColor = Color.Orange;
            pnlCima.BackColor = Color.Orange;
            btnLogo.BackColor = Color.DarkOrange;
        }

        // Resets
        private void DesativaButton()
        {
            btnPets.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnFuncionarios.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnProdutos.BackColor = Color.Transparent;
        }

        private void DesativaCL()
        {
            pnlCima.BackColor = Color.FromArgb(30, 30, 30);
            btnLogo.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void DesativaPnl()
        {
            pnlCadCli.Visible = false;
            pnlCadPet.Visible = false;
            pnlHome.Visible = false;
            pnlVendas.Visible = false;
            pnlProdutos.Visible = false;
            pnlFuncionarios.Visible = false;
        }

        void limpaCampoCli()
        {
            txtTelefoneCli.Text = "";
            txtEmailCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCpfCli.Text = "";
            txtNomeCli.Text = "";
            txtBairroCli.Text = "";
            txtNomeCli.Focus();
        }

        void limpaCampoPet()
        {
            txtNomePet.Text = "";
            txtTipoPet.Text = "";
            txtPortePet.Text = "";
            txtRacaPet.Text = "";
            txtDonoPet.Text = "";
            txtCorPet.Text = "";
            txtNomePet.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
            DesativaButton();
            DesativaCL();
            DesativaPnl();
            pnlHome.Visible = true;
            btnLogo.BackColor = Color.FromArgb(10, 10, 10);
        }

        //----------------

        //COMANDOS CLIENTES

        //Botão Clientes NavBar
        private void btnClientes_Click(object sender, EventArgs e)
        {

            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlCadCli.Visible = true;
            btnClientes.BackColor = Color.MediumSeaGreen;
            pnlCima.BackColor = Color.MediumSeaGreen;
            btnLogo.BackColor = Color.SeaGreen;

        }

        //Variável codAlterar
        int codAlterarCli;

        //Listar Clientes 
        void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaClientes();
        }

        //Limpar Campos Cliente
        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            limpaCampoCli();
        }

        //Confirmar Inserção Cliente
        private void btnConfirmarCli_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = txtNomeCli.Text;
            c.CpfCliente = txtCpfCli.Text;
            c.TelefoneCliente = txtTelefoneCli.Text;
            c.EmailCliente = txtEmailCli.Text;
            c.EnderecoCliente = txtEnderecoCli.Text;
            c.BairroCliente = txtBairroCli.Text;

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereCliente(c);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgError.Text = conecta.mensagem;

            listaCliente();
            limpaCampoCli();
        }

        //Concluir Alteração Cliente
        private void btnConcluirCli_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = txtNomeCli.Text;
            c.CpfCliente = txtCpfCli.Text;
            c.EmailCliente = txtEmailCli.Text;
            c.TelefoneCliente = txtTelefoneCli.Text;
            c.BairroCliente = txtBairroCli.Text;
            c.EnderecoCliente = txtEnderecoCli.Text;

            //Enviar dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraCliente(c, codAlterarCli);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampoCli();
            }
            else
            {
                lblMsgError.Text = conecta.mensagem;
            }

            listaCliente();
            btnConcluirCli.Visible = false;
            btnConfirmarCli.Visible = true;
            lblHeaderCli.Text = "Cadastrar Cliente";
            
        }

        //Remover Cliente
        private void btnRemoverCli_Click(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index; //pegar linha selecionada
            int codRemover = Convert.ToInt32(dgClientes.Rows[linha].Cells["Codigo"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Deletar Cliente", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaCliente(codRemover);
                if (retorno == true)
                {
                    MessageBox.Show("Cliente Removido !");
                }
                else
                    lblMsgError.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            listaCliente();
        }

        //Alterar Cliente
        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            lblHeaderCli.Text = "Alterar Cliente";

            btnConfirmarCli.Visible = false;
            btnConcluirCli.Visible = true;

            int linha = dgClientes.CurrentRow.Index; //pegar linha selecionada
            codAlterarCli = Convert.ToInt32(dgClientes.Rows[linha].Cells["Codigo"].Value.ToString());
            txtNomeCli.Text = dgClientes.Rows[linha].Cells["Nome"].Value.ToString();
            txtCpfCli.Text = dgClientes.Rows[linha].Cells["CPF"].Value.ToString();
            txtTelefoneCli.Text = dgClientes.Rows[linha].Cells["Telefone"].Value.ToString();
            txtBairroCli.Text = dgClientes.Rows[linha].Cells["Bairro"].Value.ToString();
            txtEnderecoCli.Text = dgClientes.Rows[linha].Cells["Endereco"].Value.ToString();
            txtEmailCli.Text = dgClientes.Rows[linha].Cells["Email"].Value.ToString();
        }

        //Buscar Cliente por Nome
        private void txtBuscaCli_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgClientes.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBuscaPet.Text);
        }
        
        //----------------

        //COMANDOS PETS

        //Botão Pets NavBar
        private void btnPets_Click(object sender, EventArgs e)
        {
            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlCadPet.Visible = true;
            btnPets.BackColor = Color.Firebrick;
            pnlCima.BackColor = Color.Firebrick;
            btnLogo.BackColor = Color.Maroon;
        }

        //Variável codAlterar
        int codAlterarPet;

        //Listar Pet
        void listaPet()
        {
            ConectaBanco con = new ConectaBanco();
            dgPets.DataSource = con.listaPets();
        }

        //Limpar Campos Pet
        private void btnLimparPet_Click(object sender, EventArgs e)
        {
            limpaCampoPet();
        }

        //Confirmar Inserção Pet
        private void btnConfirmarPet_Click(object sender, EventArgs e)
        {
            Pet p = new Pet();
            p.NomePet = txtNomePet.Text;
            p.TipoPet = txtTipoPet.Text;
            p.CorPet = txtCorPet.Text;
            p.RacaPet = txtRacaPet.Text;
            p.PortePet = txtPortePet.Text;
            p.DonoPet = txtDonoPet.Text;

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.inserePet(p);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgError.Text = conecta.mensagem;

            listaPet();
            limpaCampoPet();
        }

        //Confirmar Alteração Pet
        private void btnConcluirPet_Click(object sender, EventArgs e)
        {
            Pet p = new Pet();
            p.NomePet = txtNomePet.Text;
            p.TipoPet = txtTipoPet.Text;
            p.CorPet = txtCorPet.Text;
            p.RacaPet = txtRacaPet.Text;
            p.PortePet = txtPortePet.Text;
            p.DonoPet = txtDonoPet.Text;

            //Enviar dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraPet(p, codAlterarPet);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampoPet();
            }
            else
            {
                lblMsgError.Text = conecta.mensagem;
            }

            listaPet();
            btnConcluirPet.Visible = false;
            btnConfirmarPet.Visible = true;
            lblHeaderPet.Text = "Cadastrar Pet";
            
        }

        //Remover Pet
        private void btnRemoverPet_Click(object sender, EventArgs e)
        {
            int linha = dgPets.CurrentRow.Index; //pegar linha selecionada
            int codRemover = Convert.ToInt32(dgPets.Rows[linha].Cells["Codigo"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Deletar Pet", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaPet(codRemover);
                if (retorno == true)
                {
                    MessageBox.Show("Pet Removido !");
                }
                else
                    lblMsgError.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            listaPet();
        }

        //Alterar Pet
        private void btnAlterarPet_Click(object sender, EventArgs e)
        {
            lblHeaderPet.Text = "Alterar Cliente";
            
            btnConfirmarPet.Visible = false;
            btnConcluirPet.Visible = true;

            int linha = dgPets.CurrentRow.Index; //pegar linha selecionada
            codAlterarPet = Convert.ToInt32(dgPets.Rows[linha].Cells["Codigo"].Value.ToString());

            txtNomePet.Text = dgPets.Rows[linha].Cells["Nome"].Value.ToString();
            txtTipoPet.Text = dgPets.Rows[linha].Cells["Especie"].Value.ToString();
            txtCorPet.Text = dgPets.Rows[linha].Cells["Cor"].Value.ToString();
            txtRacaPet.Text = dgPets.Rows[linha].Cells["Raca"].Value.ToString();
            txtPortePet.Text = dgPets.Rows[linha].Cells["Porte"].Value.ToString();
            txtDonoPet.Text = dgPets.Rows[linha].Cells["Dono"].Value.ToString();
        }

        //Buscar Pet por Nome
        private void txtBuscaPet_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgPets.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBuscaPet.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
