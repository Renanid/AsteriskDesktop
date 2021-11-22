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
    public partial class Cadastrar_Funcionário : Form
    {
        public Cadastrar_Funcionário()
        {
            InitializeComponent();
        }

        private void Cadastrar_Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelFunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionário Cadastrado com Sucesso");
        }
    }
}
