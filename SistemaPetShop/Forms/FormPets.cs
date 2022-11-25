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
        int codAlterar;
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
            txtCorPet.Text = "";
            txtNomePet.Focus();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgPets.DataSource).DefaultView.RowFilter = string.Format("Nome like '{0}%'", txtBusca.Text);
        }

        private void FormPets_Load(object sender, EventArgs e)
        {
            listaPet();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
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
            limpaCampo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblHeaderPet.Text = "Alterar Cliente";
            pnlSConfirmar.BackColor = Color.DarkTurquoise;
            btnConfirmar.Visible = false;
            btnConfirmaAlteracao.Visible = true;

            int linha = dgPets.CurrentRow.Index; //pegar linha selecionada
            codAlterar = Convert.ToInt32(dgPets.Rows[linha].Cells["Codigo"].Value.ToString());

            txtNomePet.Text = dgPets.Rows[linha].Cells["Nome"].Value.ToString();
            txtTipoPet.Text = dgPets.Rows[linha].Cells["Especie"].Value.ToString();
            txtCorPet.Text = dgPets.Rows[linha].Cells["Cor"].Value.ToString();
            txtRacaPet.Text = dgPets.Rows[linha].Cells["Raca"].Value.ToString();
            txtPortePet.Text = dgPets.Rows[linha].Cells["Porte"].Value.ToString();
            txtDonoPet.Text = dgPets.Rows[linha].Cells["Dono"].Value.ToString();
        }
        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
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
            bool retorno = conecta.alteraPet(p, codAlterar);

            if (retorno == true)
            {
                MessageBox.Show("Dados alterados com sucesso !");
                limpaCampo();
            }
            else
            {
                lblMsgError.Text = conecta.mensagem;
            }

            listaPet();
            btnConfirmaAlteracao.Visible = false;
            btnConfirmar.Visible = true;
            lblHeaderPet.Text = "Cadastrar Pet";
            pnlSConfirmar.BackColor = Color.ForestGreen;
        }

    }
    }
    

