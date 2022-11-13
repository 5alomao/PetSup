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
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaClientes(); ;
        }

        void listaPet()
        {

        }
        void limpaCampo()
        {
            txtTelefoneCliente.Text = "";
            txtEmailCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtCpfCliente.Text = "";
            txtNomeCliente.Text = "";
            txtNomeCliente.Focus();
        }
        private void PetShop_Load(object sender, EventArgs e)
        {
            listaCliente();
        }

        private void pnlEsquerda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCima_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpfCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnderecoCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = txtNomeCliente.Text;
            c.CpfCliente = txtCpfCliente.Text;
            c.TelefoneCliente = txtTelefoneCliente.Text;
            c.EmailCliente = txtEmailCliente.Text;
            c.EnderecoCliente = txtEnderecoCliente.Text;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("nomeCliente like '{0}%'", txtBusca.Text);
        }
    }
}
