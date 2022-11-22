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
            OpenChildForm(new Forms.FormClientes());
            btnClientes.BackColor = Color.MediumSeaGreen;
            pnlCima.BackColor = Color.MediumSeaGreen;
            pnlBordaEsquerda.BackColor = Color.SeaGreen;
            pnlBordaCima.BackColor = Color.SeaGreen;
            btnLogo.BackColor = Color.SeaGreen;
            btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        private void btnPets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPets());
            btnPets.BackColor = Color.Firebrick;
            pnlCima.BackColor = Color.Firebrick;
            pnlBordaEsquerda.BackColor = Color.Maroon;
            pnlBordaCima.BackColor = Color.Maroon;
            btnLogo.BackColor = Color.Maroon;
            btnPets.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProdutos());
            btnProdutos.BackColor = Color.Goldenrod;
            pnlCima.BackColor = Color.Goldenrod;
            pnlBordaEsquerda.BackColor = Color.DarkGoldenrod;
            pnlBordaCima.BackColor = Color.DarkGoldenrod;
            btnLogo.BackColor = Color.DarkGoldenrod;
            btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuncionarios());
            btnFuncionarios.BackColor = Color.DarkCyan;
            pnlCima.BackColor = Color.DarkCyan;
            pnlBordaEsquerda.BackColor = Color.FromArgb(0, 64, 64);
            pnlBordaCima.BackColor = Color.FromArgb(0, 64, 64);
            btnLogo.BackColor = Color.FromArgb(0, 64, 64);
            btnFuncionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVendas());
            btnVendas.BackColor = Color.Crimson;
            pnlCima.BackColor = Color.Crimson;
            pnlBordaCima.BackColor = Color.DarkRed;
            pnlBordaEsquerda.BackColor = Color.DarkRed;
            btnLogo.BackColor = Color.DarkRed;
            btnVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        private void DesativaButton()
        {
            btnPets.BackColor = Color.FromArgb(51, 51, 76);
            btnClientes.BackColor = Color.FromArgb(51, 51, 76);
            btnFuncionarios.BackColor = Color.FromArgb(51, 51, 76);
            btnVendas.BackColor = Color.FromArgb(51, 51, 76);
            btnProdutos.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void DesativaCL()
        {
            pnlCima.BackColor = Color.FromArgb(51, 51, 76);
            btnLogo.BackColor = Color.FromArgb(31, 31, 51);
        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            DesativaButton();
            DesativaCL();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlConteudo.Controls.Add(childForm);
            this.pnlConteudo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            DesativaButton();
            DesativaCL();
            pnlBordaCima.BackColor = Color.FromArgb(31, 31, 51);
            pnlBordaEsquerda.BackColor = Color.FromArgb(31, 31, 51);
            lblTitle.Text = "HOME";
        }

        private void pnlRedes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PetShop_Load(object sender, EventArgs e)
        {

        }
    }
}
    
