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
    public partial class FormPets : Form
    {
        public FormPets()
        {
            InitializeComponent();
        }

        void listaPet()
        {
            ConectaBanco con = new ConectaBanco();
            dgPets.DataSource = con.listaPets();
        }

        void limpaCampo()
        {
            txtNomePet.Text = "";
            txtTipoPet.Text = "";
            txtPortePet.Text = "";
            txtRacaPet.Text = "";
            txtDonoPet.Text = "";
            txtNomePet.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Pet p = new Pet();
            p.NomePet = txtNomePet.Text;
            p.TipoPet = txtTipoPet.Text;
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
            limpaCampo();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgPets.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBusca.Text);
        }

        private void FormPets_Load(object sender, EventArgs e)
        {
            listaPet();
        }
    }
    }

