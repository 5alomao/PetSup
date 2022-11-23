using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetShop.Forms
{
    public partial class FormClientes : Form
    {
        int codAlterar;
        public FormClientes()
        {
            InitializeComponent();
        }
        void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaClientes();

        }
        void limpaCampo()
        {
            txtTelefoneCli.Text = "";
            txtEmailCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCpfCli.Text = "";
            txtNomeCli.Text = "";
            txtBairroCli.Text = "";
            txtNomeCli.Focus();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
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
            limpaCampo();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgClientes.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBusca.Text);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            listaCliente();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblHeaderCli.Text = "Alterar Cliente";
            pnlSConfirmar.BackColor = Color.DarkTurquoise;
            btnConfirmar.Visible = false;
            btnConfirmaAlteracao.Visible = true;

            int linha = dgClientes.CurrentRow.Index; //pegar linha selecionada
            codAlterar = Convert.ToInt32(dgClientes.Rows[linha].Cells["Codigo"].Value.ToString());

            txtNomeCli.Text = dgClientes.Rows[linha].Cells["Nome"].Value.ToString();
            txtCpfCli.Text = dgClientes.Rows[linha].Cells["CPF"].Value.ToString();
            txtTelefoneCli.Text = dgClientes.Rows[linha].Cells["Telefone"].Value.ToString();
            txtBairroCli.Text = dgClientes.Rows[linha].Cells["Bairro"].Value.ToString();
            txtEnderecoCli.Text = dgClientes.Rows[linha].Cells["Endereco"].Value.ToString();
            txtEmailCli.Text = dgClientes.Rows[linha].Cells["Email"].Value.ToString();

        }


        private void btnConfirmaAlteracao_Click_1(object sender, EventArgs e)
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
            bool retorno = conecta.alteraCliente(c, codAlterar);

            if(retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampo();
            }
            else
            {
                lblMsgError.Text = conecta.mensagem;
            }

            listaCliente();
            btnConfirmaAlteracao.Visible = false;
            btnConfirmar.Visible = true;
            lblHeaderCli.Text = "Cadastrar Cliente";
            pnlSConfirmar.BackColor = Color.GreenYellow;
        }
    }
    }

