using SistemaPetShop.Forms;
using System.Data;
using System.Runtime.InteropServices.ObjectiveC;

namespace SistemaPetShop
{
    public partial class PetShop : Form
    {
        private Form activeForm = new Form();
        public PetShop()
        {
            InitializeComponent();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaCL();
            DesativaButton();
            btnClientes.BackColor = Color.MediumSeaGreen;
            pnlCima.BackColor = Color.MediumSeaGreen; 
            btnLogo.BackColor = Color.SeaGreen;
            
            OpenChildForm(new Forms.FormClientes());

        }
        private void btnPets_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaCL();
            DesativaButton();
            btnPets.BackColor = Color.Firebrick;
            pnlCima.BackColor = Color.Firebrick;
            btnLogo.BackColor = Color.Maroon;
            
            OpenChildForm(new Forms.FormPets());
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaCL();
            DesativaButton();
            btnProdutos.BackColor = Color.Goldenrod;
            pnlCima.BackColor = Color.Goldenrod;
            btnLogo.BackColor = Color.DarkGoldenrod;
            
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaCL();
            DesativaButton();
            btnFuncionarios.BackColor = Color.DarkCyan;
            pnlCima.BackColor = Color.DarkCyan;
            btnLogo.BackColor = Color.Teal;
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaCL();
            DesativaButton();
            btnVendas.BackColor = Color.Crimson;
            pnlCima.BackColor = Color.Crimson;
            btnLogo.BackColor = Color.DarkRed;
            
        }
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

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlConteudo.Controls.Add(childForm);
            this.pnlConteudo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaButton();
            DesativaCL();
            
        }

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PetShop_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
    
