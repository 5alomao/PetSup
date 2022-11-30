using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetShop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void limpaCampo()
        {
            txtSenha.Text = "";
            txtEmailUser.Text = "";
            txtUser.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            Login fazer = new Login();
            this.Hide();
            fazer.ShowDialog();
            this.Close();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string senhaHash = Hash.makeHash(txtSenha.Text);
            u.NomeUser = txtUser.Text;
            u.EmailUser = txtEmailUser.Text;
            u.SenhaUser = senhaHash;
                

            ConectaBanco conecta = new ConectaBanco();
            bool retorno = conecta.insereUsuarios(u);
            if (retorno == true)
            {
                MessageBox.Show("Dados Inseridos com Sucesso :)");
            }
            else
            MessageBox.Show("Erro :(" + conecta.mensagem);

            limpaCampo();
            Login fazer = new Login();
            this.Hide();
            fazer.ShowDialog();
            this.Close();
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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
