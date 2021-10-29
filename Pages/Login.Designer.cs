
namespace SCAC
{
    partial class pgLogin
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
            System.Windows.Forms.Label lblLogin;
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.MaskedTextBox();
            this.txbSenha = new System.Windows.Forms.MaskedTextBox();
            this.lklCadastro = new System.Windows.Forms.LinkLabel();
            this.lblScac = new System.Windows.Forms.Label();
            lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.CausesValidation = false;
            lblLogin.Location = new System.Drawing.Point(59, 52);
            lblLogin.MinimumSize = new System.Drawing.Size(150, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(150, 30);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(110, 193);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 29);
            this.btnLogar.TabIndex = 1;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(59, 126);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(62, 85);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(178, 20);
            this.txbLogin.TabIndex = 3;
            // 
            // txbSenha
            // 
            this.txbSenha.HideSelection = false;
            this.txbSenha.Location = new System.Drawing.Point(62, 142);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(178, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // lklCadastro
            // 
            this.lklCadastro.AutoSize = true;
            this.lklCadastro.LinkColor = System.Drawing.Color.Black;
            this.lklCadastro.Location = new System.Drawing.Point(118, 234);
            this.lklCadastro.Name = "lklCadastro";
            this.lklCadastro.Size = new System.Drawing.Size(67, 13);
            this.lklCadastro.TabIndex = 6;
            this.lklCadastro.TabStop = true;
            this.lklCadastro.Text = "Se cadastrar";
            this.lklCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCadastro_LinkClicked);
            // 
            // lblScac
            // 
            this.lblScac.AutoSize = true;
            this.lblScac.Location = new System.Drawing.Point(118, 30);
            this.lblScac.Name = "lblScac";
            this.lblScac.Size = new System.Drawing.Size(35, 13);
            this.lblScac.TabIndex = 7;
            this.lblScac.Text = "SCAC";
            // 
            // pgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(291, 273);
            this.Controls.Add(this.lblScac);
            this.Controls.Add(this.lklCadastro);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(lblLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "pgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox txbLogin;
        private System.Windows.Forms.MaskedTextBox txbSenha;
        private System.Windows.Forms.LinkLabel lklCadastro;
        private System.Windows.Forms.Label lblScac;
    }
}

