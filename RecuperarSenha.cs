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
    public partial class Recuperar_Senha : Form
    {
        public Recuperar_Senha()
        {
            InitializeComponent();
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções Para Recuperação da Senha Enviada com Sucesso!");
        }
    }
}
