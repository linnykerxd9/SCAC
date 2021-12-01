
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
            this.TxbFullName = new System.Windows.Forms.MaskedTextBox();
            this.TxbRg = new System.Windows.Forms.MaskedTextBox();
            this.TxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.TxbLogin = new System.Windows.Forms.MaskedTextBox();
            this.TxbPassword = new System.Windows.Forms.MaskedTextBox();
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
            this.LblFullName.Location = new System.Drawing.Point(131, 96);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(124, 20);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "Nome completo:";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.BackColor = System.Drawing.Color.Transparent;
            this.LblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRg.Location = new System.Drawing.Point(131, 179);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(120, 20);
            this.LblRg.TabIndex = 2;
            this.LblRg.Text = "Número do RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(129, 260);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(126, 20);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "Número do CPF:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(131, 407);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(60, 20);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Senha:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.SystemColors.Control;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(131, 330);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(52, 20);
            this.LblLogin.TabIndex = 5;
            this.LblLogin.Text = "Login:";
            // 
            // TxbFullName
            // 
            this.TxbFullName.Location = new System.Drawing.Point(159, 130);
            this.TxbFullName.Name = "TxbFullName";
            this.TxbFullName.Size = new System.Drawing.Size(172, 20);
            this.TxbFullName.TabIndex = 6;
            // 
            // TxbRg
            // 
            this.TxbRg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TxbRg.Location = new System.Drawing.Point(159, 224);
            this.TxbRg.Mask = "0.000.000";
            this.TxbRg.Name = "TxbRg";
            this.TxbRg.Size = new System.Drawing.Size(172, 20);
            this.TxbRg.TabIndex = 7;
            this.TxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxbCpf
            // 
            this.TxbCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TxbCpf.Location = new System.Drawing.Point(159, 294);
            this.TxbCpf.Mask = "000.000.000-00";
            this.TxbCpf.Name = "TxbCpf";
            this.TxbCpf.Size = new System.Drawing.Size(172, 20);
            this.TxbCpf.TabIndex = 8;
            this.TxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TxbLogin
            // 
            this.TxbLogin.Location = new System.Drawing.Point(159, 366);
            this.TxbLogin.Name = "TxbLogin";
            this.TxbLogin.Size = new System.Drawing.Size(172, 20);
            this.TxbLogin.TabIndex = 9;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(159, 447);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(172, 20);
            this.TxbPassword.TabIndex = 10;
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
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // pgCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCAC.Properties.Resources.LogoSample;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(503, 544);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.TxbLogin);
            this.Controls.Add(this.TxbCpf);
            this.Controls.Add(this.TxbRg);
            this.Controls.Add(this.TxbFullName);
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
        private System.Windows.Forms.MaskedTextBox TxbFullName;
        private System.Windows.Forms.MaskedTextBox TxbRg;
        private System.Windows.Forms.MaskedTextBox TxbCpf;
        private System.Windows.Forms.MaskedTextBox TxbLogin;
        private System.Windows.Forms.MaskedTextBox TxbPassword;
        private System.Windows.Forms.Button BtnRegistration;
    }
}