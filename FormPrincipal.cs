using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Prototipo
{
    public partial class FormPrincipal : Form
    {
        private Form frmAtivo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(btnLogin);
            FormShow(new Login());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            ActiveFormClose();
            Application.Exit();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            FormShow(new Form());
            ActiveFormClose();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnReservas);
            FormShow(new Reservas());
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMapa);
            FormShow(new Mapa_de_Ocupação());
        }

        private void btnFuncionários_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFuncionários);
            FormShow(new Funcionários());
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFinanceiro);
            FormShow(new Financeiro());
        }

        //private void btnEstoque_Click(object sender, EventArgs e)
        //{

        //}

        private void btnHistReservas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHistReservas);
            FormShow(new Histórico_de_Reservas());
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
