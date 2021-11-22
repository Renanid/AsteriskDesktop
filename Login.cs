using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrarPrinc_Click(object sender, EventArgs e)
        {
            if(txtLoginPrinc.Text == "Green Leaft" && txtSenhaPrinc.Text =="1234")
            {
                MessageBox.Show("Bem Vindo Ao Asterisk Hotel!");
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos!");
            }
        }

        private void btnRecSenha_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEsqSenha_Click(object sender, EventArgs e)
        {
            Recuperar_Senha j3 = new Recuperar_Senha();
            j3.Show();
        }

        private void btnNVCadCli_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes j2 = new Cadastro_de_Clientes();
            j2.Show();
        }

        private void txtSenhaPrinc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
