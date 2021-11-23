
namespace SCAC.Pages
{
    partial class pgCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.ItbFullName = new System.Windows.Forms.MaskedTextBox();
            this.ItbRg = new System.Windows.Forms.MaskedTextBox();
            this.ItbCpf = new System.Windows.Forms.MaskedTextBox();
            this.ItbLogin = new System.Windows.Forms.MaskedTextBox();
            this.ItbPassword = new System.Windows.Forms.MaskedTextBox();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullName.Location = new System.Drawing.Point(67, 102);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(124, 20);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "Nome completo:";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRg.Location = new System.Drawing.Point(67, 185);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(120, 20);
            this.LblRg.TabIndex = 2;
            this.LblRg.Text = "Número do RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(65, 266);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(126, 20);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "Número do CPF:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(67, 413);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(60, 20);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Senha:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(67, 336);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(52, 20);
            this.LblLogin.TabIndex = 5;
            this.LblLogin.Text = "Login:";
            // 
            // ItbFullName
            // 
            this.ItbFullName.Location = new System.Drawing.Point(95, 136);
            this.ItbFullName.Name = "ItbFullName";
            this.ItbFullName.Size = new System.Drawing.Size(172, 20);
            this.ItbFullName.TabIndex = 6;
            // 
            // ItbRg
            // 
            this.ItbRg.Location = new System.Drawing.Point(95, 230);
            this.ItbRg.Mask = "0.000.000";
            this.ItbRg.Name = "ItbRg";
            this.ItbRg.Size = new System.Drawing.Size(172, 20);
            this.ItbRg.TabIndex = 7;
            // 
            // ItbCpf
            // 
            this.ItbCpf.Location = new System.Drawing.Point(95, 300);
            this.ItbCpf.Mask = "000.000.000-00";
            this.ItbCpf.Name = "ItbCpf";
            this.ItbCpf.Size = new System.Drawing.Size(172, 20);
            this.ItbCpf.TabIndex = 8;
            // 
            // ItbLogin
            // 
            this.ItbLogin.Location = new System.Drawing.Point(95, 372);
            this.ItbLogin.Name = "ItbLogin";
            this.ItbLogin.Size = new System.Drawing.Size(172, 20);
            this.ItbLogin.TabIndex = 9;
            // 
            // ItbPassword
            // 
            this.ItbPassword.Location = new System.Drawing.Point(95, 453);
            this.ItbPassword.Name = "ItbPassword";
            this.ItbPassword.PasswordChar = '*';
            this.ItbPassword.Size = new System.Drawing.Size(172, 20);
            this.ItbPassword.TabIndex = 10;
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistration.Location = new System.Drawing.Point(206, 489);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(100, 34);
            this.BtnRegistration.TabIndex = 11;
            this.BtnRegistration.Text = "Cadastrar";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            // 
            // pgCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCAC.Properties.Resources.LogoSample;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(503, 544);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.ItbPassword);
            this.Controls.Add(this.ItbLogin);
            this.Controls.Add(this.ItbCpf);
            this.Controls.Add(this.ItbRg);
            this.Controls.Add(this.ItbFullName);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.LblFullName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "pgCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.MaskedTextBox ItbFullName;
        private System.Windows.Forms.MaskedTextBox ItbRg;
        private System.Windows.Forms.MaskedTextBox ItbCpf;
        private System.Windows.Forms.MaskedTextBox ItbLogin;
        private System.Windows.Forms.MaskedTextBox ItbPassword;
        private System.Windows.Forms.Button BtnRegistration;
    }
}