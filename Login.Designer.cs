
namespace Prototipo
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblNomeHotel = new System.Windows.Forms.Label();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnEntLog = new System.Windows.Forms.Button();
            this.chkLembrete = new System.Windows.Forms.CheckBox();
            this.txtSenhaPrinc = new System.Windows.Forms.TextBox();
            this.txtLoginPrinc = new System.Windows.Forms.TextBox();
            this.lblSenhaPrinc = new System.Windows.Forms.Label();
            this.lblLoginPrinc = new System.Windows.Forms.Label();
            this.pnlLogoLog = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNVCadCli = new System.Windows.Forms.Button();
            this.btnEsqSenha = new System.Windows.Forms.Button();
            this.pnlLogoLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeHotel
            // 
            this.lblNomeHotel.AutoSize = true;
            this.lblNomeHotel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeHotel.Location = new System.Drawing.Point(193, 132);
            this.lblNomeHotel.Name = "lblNomeHotel";
            this.lblNomeHotel.Size = new System.Drawing.Size(228, 32);
            this.lblNomeHotel.TabIndex = 37;
            this.lblNomeHotel.Text = "Asterisk Hotel";
            this.lblNomeHotel.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelLogin.Location = new System.Drawing.Point(219, 189);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLogin.TabIndex = 36;
            this.btnCancelLogin.Text = "Cancelar";
            this.btnCancelLogin.UseVisualStyleBackColor = false;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnEntLog
            // 
            this.btnEntLog.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEntLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntLog.ForeColor = System.Drawing.Color.White;
            this.btnEntLog.Location = new System.Drawing.Point(77, 189);
            this.btnEntLog.Name = "btnEntLog";
            this.btnEntLog.Size = new System.Drawing.Size(75, 23);
            this.btnEntLog.TabIndex = 35;
            this.btnEntLog.Text = "Entrar";
            this.btnEntLog.UseVisualStyleBackColor = false;
            this.btnEntLog.Click += new System.EventHandler(this.btnEntrarPrinc_Click);
            // 
            // chkLembrete
            // 
            this.chkLembrete.AutoSize = true;
            this.chkLembrete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLembrete.Location = new System.Drawing.Point(77, 152);
            this.chkLembrete.Name = "chkLembrete";
            this.chkLembrete.Size = new System.Drawing.Size(97, 17);
            this.chkLembrete.TabIndex = 34;
            this.chkLembrete.Text = "Me Lembre";
            this.chkLembrete.UseVisualStyleBackColor = true;
            // 
            // txtSenhaPrinc
            // 
            this.txtSenhaPrinc.Location = new System.Drawing.Point(77, 109);
            this.txtSenhaPrinc.Multiline = true;
            this.txtSenhaPrinc.Name = "txtSenhaPrinc";
            this.txtSenhaPrinc.PasswordChar = '*';
            this.txtSenhaPrinc.Size = new System.Drawing.Size(217, 26);
            this.txtSenhaPrinc.TabIndex = 30;
            this.txtSenhaPrinc.TextChanged += new System.EventHandler(this.txtSenhaPrinc_TextChanged);
            // 
            // txtLoginPrinc
            // 
            this.txtLoginPrinc.Location = new System.Drawing.Point(77, 51);
            this.txtLoginPrinc.Multiline = true;
            this.txtLoginPrinc.Name = "txtLoginPrinc";
            this.txtLoginPrinc.Size = new System.Drawing.Size(217, 26);
            this.txtLoginPrinc.TabIndex = 29;
            // 
            // lblSenhaPrinc
            // 
            this.lblSenhaPrinc.AutoSize = true;
            this.lblSenhaPrinc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPrinc.Location = new System.Drawing.Point(77, 90);
            this.lblSenhaPrinc.Name = "lblSenhaPrinc";
            this.lblSenhaPrinc.Size = new System.Drawing.Size(53, 16);
            this.lblSenhaPrinc.TabIndex = 28;
            this.lblSenhaPrinc.Text = "Senha";
            // 
            // lblLoginPrinc
            // 
            this.lblLoginPrinc.AutoSize = true;
            this.lblLoginPrinc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPrinc.Location = new System.Drawing.Point(77, 32);
            this.lblLoginPrinc.Name = "lblLoginPrinc";
            this.lblLoginPrinc.Size = new System.Drawing.Size(47, 16);
            this.lblLoginPrinc.TabIndex = 27;
            this.lblLoginPrinc.Text = "Login";
            // 
            // pnlLogoLog
            // 
            this.pnlLogoLog.BackColor = System.Drawing.Color.Khaki;
            this.pnlLogoLog.Controls.Add(this.pictureBox1);
            this.pnlLogoLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoLog.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoLog.Name = "pnlLogoLog";
            this.pnlLogoLog.Size = new System.Drawing.Size(800, 73);
            this.pnlLogoLog.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNVCadCli);
            this.groupBox1.Controls.Add(this.btnEsqSenha);
            this.groupBox1.Controls.Add(this.btnCancelLogin);
            this.groupBox1.Controls.Add(this.btnEntLog);
            this.groupBox1.Controls.Add(this.txtLoginPrinc);
            this.groupBox1.Controls.Add(this.txtSenhaPrinc);
            this.groupBox1.Controls.Add(this.lblLoginPrinc);
            this.groupBox1.Controls.Add(this.chkLembrete);
            this.groupBox1.Controls.Add(this.lblSenhaPrinc);
            this.groupBox1.Location = new System.Drawing.Point(189, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 296);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // btnNVCadCli
            // 
            this.btnNVCadCli.BackColor = System.Drawing.Color.Olive;
            this.btnNVCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVCadCli.ForeColor = System.Drawing.Color.White;
            this.btnNVCadCli.Location = new System.Drawing.Point(114, 247);
            this.btnNVCadCli.Name = "btnNVCadCli";
            this.btnNVCadCli.Size = new System.Drawing.Size(138, 23);
            this.btnNVCadCli.TabIndex = 38;
            this.btnNVCadCli.Text = "Novo Cadastro";
            this.btnNVCadCli.UseVisualStyleBackColor = false;
            this.btnNVCadCli.Click += new System.EventHandler(this.btnNVCadCli_Click);
            // 
            // btnEsqSenha
            // 
            this.btnEsqSenha.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEsqSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqSenha.ForeColor = System.Drawing.Color.White;
            this.btnEsqSenha.Location = new System.Drawing.Point(114, 218);
            this.btnEsqSenha.Name = "btnEsqSenha";
            this.btnEsqSenha.Size = new System.Drawing.Size(138, 23);
            this.btnEsqSenha.TabIndex = 37;
            this.btnEsqSenha.Text = "Esqueci Minha Senha";
            this.btnEsqSenha.UseVisualStyleBackColor = false;
            this.btnEsqSenha.Click += new System.EventHandler(this.btnEsqSenha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlLogoLog);
            this.Controls.Add(this.lblNomeHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlLogoLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeHotel;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnEntLog;
        private System.Windows.Forms.CheckBox chkLembrete;
        private System.Windows.Forms.TextBox txtSenhaPrinc;
        private System.Windows.Forms.TextBox txtLoginPrinc;
        private System.Windows.Forms.Label lblSenhaPrinc;
        private System.Windows.Forms.Label lblLoginPrinc;
        private System.Windows.Forms.Panel pnlLogoLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNVCadCli;
        private System.Windows.Forms.Button btnEsqSenha;
    }
}