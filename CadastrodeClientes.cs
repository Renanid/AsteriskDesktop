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
    public partial class Cadastro_de_Clientes : Form
    {
        public Cadastro_de_Clientes()
        {
            InitializeComponent();
        }

        private void btnCancelCadCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hospede Cadastrado Com Sucesso!");
        }
    }
}
