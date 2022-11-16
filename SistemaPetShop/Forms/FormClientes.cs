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
            txtTelefoneCli.Text = "";
            txtEmailCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCpfCli.Text = "";
            txtNomeCli.Text = "";
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

    }
}
