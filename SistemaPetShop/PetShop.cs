using System.Data;
using System.Runtime.InteropServices;
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
            pnlHome.Visible = true;
            listaCliente();
            listaPet();
            listaProduto();
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
            pnlMarca.Visible = false;
            pnlCategoria.Visible = false;
            pnlContatos.Visible = false;
            pnlSobreNos.Visible = false;
            
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

        void limpaCampoMarca()
        {
            txtNomeMarca.Text = "";
        }

        void limpaCampoCategoria()
        {
            txtNomeCategoria.Text = "";
        }
        void limpaCampoPet()
        {
            txtNomePet.Text = "";
            txtTipoPet.Text = "";
            txtPortePet.Text = "";
            txtRacaPet.Text = "";
            cbClientes.Text = "Selecione um Cliente";
            txtCorPet.Text = "";
            txtNomePet.Focus();
        }
        void limpaCampoProd()
        {
            txtNomeProd.Text = "";
            cbCategoriaProd.Text = "Selecione uma Categoria";
            cbMarcaProd.Text = "Selecione uma Marca";
            txtVendaProd.Text = "";
            txtCustoProd.Text = "";
            txtQntdEstoque.Text = "";
            txtNomeProd.Focus();
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
                lblMsgErrorCli.Text = conecta.mensagem;

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
                lblMsgErrorCli.Text = conecta.mensagem;
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
                    lblMsgErrorCli.Text = conecta.mensagem;
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
            ((DataTable)dgClientes.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBuscaCli.Text);
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
            listaClienteCB();

        }

        //Variável codAlterar
        int codAlterarPet;

        //Listar Pet
        void listaPet()
        {
            ConectaBanco con = new ConectaBanco();
            dgPets.DataSource = con.listaPets();
        }
        void listaClienteCB()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaClientes();
            cbClientes.DataSource = tabelaDados;
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Codigo";
            cbClientes.Text = "Selecione um Cliente";
            lblMsgErrorPet.Text = con.mensagem;
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
            p.DonoPet = Convert.ToInt32(cbClientes.SelectedValue.ToString());

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.inserePet(p);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgErrorPet.Text = conecta.mensagem;

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
            p.DonoPet = Convert.ToInt32(cbClientes.SelectedValue.ToString());


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
                lblMsgErrorPet.Text = conecta.mensagem;
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
                    lblMsgErrorPet.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            listaPet();
        }

        //Alterar Pet
        private void btnAlterarPet_Click(object sender, EventArgs e)
        {
            lblHeaderPet.Text = "Alterar Pet";

            btnConfirmarPet.Visible = false;
            btnConcluirPet.Visible = true;

            int linha = dgPets.CurrentRow.Index; //pegar linha selecionada
            codAlterarPet = Convert.ToInt32(dgPets.Rows[linha].Cells["Codigo"].Value.ToString());

            txtNomePet.Text = dgPets.Rows[linha].Cells["Nome"].Value.ToString();
            txtTipoPet.Text = dgPets.Rows[linha].Cells["Especie"].Value.ToString();
            txtCorPet.Text = dgPets.Rows[linha].Cells["Cor"].Value.ToString();
            txtRacaPet.Text = dgPets.Rows[linha].Cells["Raca"].Value.ToString();
            txtPortePet.Text = dgPets.Rows[linha].Cells["Porte"].Value.ToString();
            cbClientes.Text = dgPets.Rows[linha].Cells["Dono"].Value.ToString();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //arrastar pela barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlAba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login sair = new Login();
            this.Hide();
            sair.ShowDialog();
            this.Close();
        }

        //COMANDOS PRODUTOS

        int codAlterarProd;
        //Botão NavBar Produtos
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            DesativaCL();
            DesativaButton();
            DesativaPnl();
            pnlProdutos.Visible = true;
            btnProdutos.BackColor = Color.FromArgb(97, 24, 96);
            pnlCima.BackColor = Color.FromArgb(97, 24, 96);
            btnLogo.BackColor = Color.FromArgb(80, 02, 80);
            listaCategoria();
            listaMarca();

        }

        //lista Categorias
        void listaCategoria()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbCategoriaProd.DataSource = tabelaDados;
            cbCategoriaProd.DisplayMember = "nomeCategoria";
            cbCategoriaProd.ValueMember = "codCategoria";
            cbCategoriaProd.Text = "Selecione uma categoria";
            lblMsgErrorProd.Text = con.mensagem;
            dgCategorias.DataSource = con.listaCategorias();
        }

        //lista Marcas
        void listaMarca()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarcas();
            cbMarcaProd.DataSource = tabelaDados;
            cbMarcaProd.DisplayMember = "nomeMarca";
            cbMarcaProd.ValueMember = "codMarca";
            cbMarcaProd.Text = "Selecione uma marca";
            lblMsgErrorProd.Text = con.mensagem;
            dgMarcas.DataSource = con.listaMarcas();
        }
        //lista Produtos
        void listaProduto()
        {
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.listaProdutos();
        }
        //Confirmar Inserção Produto
        private void btnConfirmarProd_Click(object sender, EventArgs e)
        {
            Produto pr = new Produto();
            pr.NomeProduto = txtNomeProd.Text;
            pr.MarcaProduto = Convert.ToInt32(cbMarcaProd.SelectedValue.ToString());
            pr.CategoriaProduto = Convert.ToInt32(cbCategoriaProd.SelectedValue.ToString());
            pr.PrecoVenda = txtVendaProd.Text;
            pr.PrecoCusto = txtCustoProd.Text;
            pr.QntEstoque = txtQntdEstoque.Text;


            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereProdutos(pr);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgErrorProd.Text = conecta.mensagem;

            listaProduto();
            limpaCampoProd();
        }
        //ALTERAR PROD
        private void btnAlteraProd_Click(object sender, EventArgs e)
        {
            lblHeaderCli.Text = "Alterar Produto";

            btnConfirmarProd.Visible = false;
            btnConcluirProd.Visible = true;

            int linha = dgProdutos.CurrentRow.Index; //pegar linha selecionada
            codAlterarProd = Convert.ToInt32(dgProdutos.Rows[linha].Cells["Codigo"].Value.ToString());
            txtNomeProd.Text = dgProdutos.Rows[linha].Cells["Nome"].Value.ToString();
            txtCustoProd.Text = dgProdutos.Rows[linha].Cells["Custo"].Value.ToString();
            txtVendaProd.Text = dgProdutos.Rows[linha].Cells["Venda"].Value.ToString();
            cbMarcaProd.Text = dgProdutos.Rows[linha].Cells["Marca"].Value.ToString();
            cbCategoriaProd.Text = dgProdutos.Rows[linha].Cells["Categoria"].Value.ToString();
            txtQntdEstoque.Text = dgProdutos.Rows[linha].Cells["Estoque"].Value.ToString();
        }
        //CONCLUIR ALTERAÇÃO PROD
        private void btnConcluirProd_Click(object sender, EventArgs e)
        {
            Produto pr = new Produto();
            pr.NomeProduto = txtNomeProd.Text;
            pr.PrecoVenda = txtVendaProd.Text;
            pr.PrecoCusto = txtCustoProd.Text;
            pr.MarcaProduto = Convert.ToInt32(cbMarcaProd.SelectedValue.ToString());
            pr.CategoriaProduto = Convert.ToInt32(cbCategoriaProd.SelectedValue.ToString());
            pr.QntEstoque = txtQntdEstoque.Text;


            //Enviar dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraProdutos(pr, codAlterarProd);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampoProd();
            }
            else
            {
                lblMsgErrorProd.Text = conecta.mensagem;
            }

            listaProduto();
            btnConcluirProd.Visible = false;
            btnConfirmarProd.Visible = true;
            lblHeaderPet.Text = "Cadastrar Produto";

        }
       //LIMPAR CAMPOS PROD
        private void btnLimparProd_Click(object sender, EventArgs e)
        {
            limpaCampoProd();
        }
        //REMOVER PRODUTO
        private void btnRemoverProd_Click(object sender, EventArgs e)
        {
            int linha = dgProdutos.CurrentRow.Index; //pegar linha selecionada
            int codRemover = Convert.ToInt32(dgProdutos.Rows[linha].Cells["Codigo"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Deletar Produto", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaProduto(codRemover);
                if (retorno == true)
                {
                    MessageBox.Show("Produto Removido !");
                }
                else
                    lblMsgErrorProd.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            listaProduto();
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            btnClientes_Click(sender, e);
            txtNomeCli.Focus();
        }

        private void txtBuscaProd_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgProdutos.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBuscaProd.Text);
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            DesativaPnl();
            pnlCategoria.Visible = true;
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            DesativaPnl();
            DesativaButton();
            DesativaCL();
            pnlContatos.Visible = true;
            btnLogo.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            DesativaButton();
            DesativaCL();
            DesativaPnl();
            pnlSobreNos.Visible = true;
            btnLogo.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            DesativaPnl();
            pnlMarca.Visible = true;
        }

        private void btnConfirmarMarca_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.NomeMarca = txtNomeMarca.Text;
            

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereMarca(m);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgErrorMarca.Text = conecta.mensagem;
            limpaCampoMarca();
            listaMarca();
        }

        private void btnRemoverMarca_Click(object sender, EventArgs e)
        {
            int linha = dgMarcas.CurrentRow.Index; //pegar linha selecionada
            int codRemover = Convert.ToInt32(dgMarcas.Rows[linha].Cells["codMarca"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Deletar Marca", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaMarca(codRemover);
                if (retorno == true)
                {
                    MessageBox.Show("Marca Removida !");
                }
                else
                    lblMsgErrorPet.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            limpaCampoMarca();
            listaMarca();
        }
        int codAlterarMarca;
        private void btnAlterarMarca_Click(object sender, EventArgs e)
        {
            lblHeaderAddMarca.Text = "Alterar Marca";

            btnConfirmarMarca.Visible = false;
            btnConcluirMarca.Visible = true;

            int linha = dgMarcas.CurrentRow.Index; //pegar linha selecionada
            codAlterarMarca = Convert.ToInt32(dgMarcas.Rows[linha].Cells["codMarca"].Value.ToString());
            txtNomeMarca.Text = dgMarcas.Rows[linha].Cells["nomeMarca"].Value.ToString();
            
        }

        private void btnConcluirMarca_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.NomeMarca = txtNomeMarca.Text;
           


            //Enviar dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraMarca(m, codAlterarMarca);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampoMarca();
            }
            else
            {
                lblMsgErrorMarca.Text = conecta.mensagem;
            }
            listaMarca();
            btnConfirmarMarca.Visible = true;
            btnConcluirMarca.Visible = false;
            lblHeaderAddMarca.Text = "Cadastrar Marca";
        }

        private void txtBuscaMarca_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgMarcas.DataSource).DefaultView.RowFilter = string.Format("nomeMarca like '{0}%'", txtBuscaMarca.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DesativaPnl();
            pnlProdutos.Visible = true;
            lblHeaderAddMarca.Text = "Cadastrar Marca";
            limpaCampoMarca();
        }


        int codAlterarCategoria;
        private void btnConfirmarCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.NomeCategoria = txtNomeCategoria.Text;


            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereCategoria(cat);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
                lblMsgErrorCategoria.Text = conecta.mensagem;
            limpaCampoCategoria();
            listaCategoria();
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            int linha = dgCategorias.CurrentRow.Index; //pegar linha selecionada
            int codRemover = Convert.ToInt32(dgCategorias.Rows[linha].Cells["codCategoria"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Deletar Categoria", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.deletaCategoria(codRemover);
                if (retorno == true)
                {
                    MessageBox.Show("Categoria Removida !");
                }
                else
                    lblMsgErrorPet.Text = conecta.mensagem;
            } // final if YES
            else
                MessageBox.Show("Operação Cancelada");

            limpaCampoCategoria();
            listaCategoria();
        }

        private void btnAlterarCategoria_Click(object sender, EventArgs e)
        {
            lblHeaderAddCategoria.Text = "Alterar Categoria";

            btnConfirmarCategoria.Visible = false;
            btnConcluirCategoria.Visible = true;

            int linha = dgCategorias.CurrentRow.Index; //pegar linha selecionada
            codAlterarCategoria = Convert.ToInt32(dgCategorias.Rows[linha].Cells["codCategoria"].Value.ToString());
            txtNomeCategoria.Text = dgCategorias.Rows[linha].Cells["nomeCategoria"].Value.ToString();
        }

        private void btnConcluirCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.NomeCategoria = txtNomeCategoria.Text;



            //Enviar dados para alterar
            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.alteraCategoria(cat, codAlterarCategoria);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampoCategoria();
            }
            else
            {
                lblMsgErrorCategoria.Text = conecta.mensagem;
            }
            listaCategoria();
            btnConfirmarCategoria.Visible = true;
            btnConcluirCategoria.Visible = false;
            lblHeaderAddCategoria.Text = "Cadastrar Categoria";
        }

        private void txtBuscaCategoria_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgCategorias.DataSource).DefaultView.RowFilter = string.Format("nomeCategoria like '{0}%'", txtBuscaCategoria.Text);
        }

        private void btnVoltarCateg_Click(object sender, EventArgs e)
        {
            DesativaPnl();
            pnlProdutos.Visible = true;
            lblHeaderAddCategoria.Text = "Cadastrar Categoria";
            limpaCampoCategoria();
        }
    }
}


    
