
namespace Prototipo
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistReservas = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionários = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Khaki;
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.btnFuncionários);
            this.panelPrincipal.Controls.Add(this.btnFinanceiro);
            this.panelPrincipal.Controls.Add(this.btnReservas);
            this.panelPrincipal.Controls.Add(this.btnLogin);
            this.panelPrincipal.Controls.Add(this.btnHome);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(203, 575);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistReservas);
            this.panel1.Controls.Add(this.btnMapa);
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 10;
            // 
            // btnHistReservas
            // 
            this.btnHistReservas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistReservas.FlatAppearance.BorderSize = 0;
            this.btnHistReservas.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnHistReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHistReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnHistReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistReservas.ForeColor = System.Drawing.Color.Black;
            this.btnHistReservas.Location = new System.Drawing.Point(0, 45);
            this.btnHistReservas.Name = "btnHistReservas";
            this.btnHistReservas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistReservas.Size = new System.Drawing.Size(200, 39);
            this.btnHistReservas.TabIndex = 5;
            this.btnHistReservas.Text = "Histórico de Reservas";
            this.btnHistReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistReservas.UseVisualStyleBackColor = true;
            this.btnHistReservas.Click += new System.EventHandler(this.btnHistReservas_Click);
            // 
            // btnMapa
            // 
            this.btnMapa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMapa.FlatAppearance.BorderSize = 0;
            this.btnMapa.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapa.ForeColor = System.Drawing.Color.Black;
            this.btnMapa.Location = new System.Drawing.Point(0, 0);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMapa.Size = new System.Drawing.Size(200, 39);
            this.btnMapa.TabIndex = 4;
            this.btnMapa.Text = "Mapa De Ocupação";
            this.btnMapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMapa.UseVisualStyleBackColor = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(0, 524);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(200, 39);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFuncionários
            // 
            this.btnFuncionários.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionários.FlatAppearance.BorderSize = 0;
            this.btnFuncionários.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionários.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFuncionários.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionários.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionários.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionários.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionários.Location = new System.Drawing.Point(0, 328);
            this.btnFuncionários.Name = "btnFuncionários";
            this.btnFuncionários.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFuncionários.Size = new System.Drawing.Size(200, 39);
            this.btnFuncionários.TabIndex = 6;
            this.btnFuncionários.Text = "Funcionários";
            this.btnFuncionários.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionários.UseVisualStyleBackColor = true;
            this.btnFuncionários.Click += new System.EventHandler(this.btnFuncionários_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnFinanceiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.Color.Black;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 373);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(200, 39);
            this.btnFinanceiro.TabIndex = 5;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.Black;
            this.btnReservas.Location = new System.Drawing.Point(3, 187);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(200, 39);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(0, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(200, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 97);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 39);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 88);
            this.panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Khaki;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(194, 88);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(203, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(797, 575);
            this.panelForm.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1000, 575);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asterisk Hotel";
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnFuncionários;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistReservas;
    }
}

