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
        void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.listaClientes(); ;
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
        private void FormClientes_Load(object sender, EventArgs e)
        {
            listaCliente();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgClientes.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBusca.Text);
        }
    }
}
