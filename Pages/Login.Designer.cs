﻿
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
            System.Windows.Forms.Label labLogin;
            this.btnLogar = new System.Windows.Forms.Button();
            this.labSenha = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.MaskedTextBox();
            this.txbSenha = new System.Windows.Forms.MaskedTextBox();
            this.lklCadastro = new System.Windows.Forms.LinkLabel();
            labLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labLogin
            // 
            labLogin.CausesValidation = false;
            labLogin.Location = new System.Drawing.Point(59, 52);
            labLogin.MinimumSize = new System.Drawing.Size(150, 15);
            labLogin.Name = "labLogin";
            labLogin.Size = new System.Drawing.Size(150, 30);
            labLogin.TabIndex = 0;
            labLogin.Text = "LOGIN";
            labLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Location = new System.Drawing.Point(59, 126);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(44, 13);
            this.labSenha.TabIndex = 2;
            this.labSenha.Text = "SENHA";
            this.labSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.txbSenha.Location = new System.Drawing.Point(62, 142);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(178, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // lklCadastro
            // 
            this.lklCadastro.AutoSize = true;
            this.lklCadastro.Location = new System.Drawing.Point(118, 234);
            this.lklCadastro.Name = "lklCadastro";
            this.lklCadastro.Size = new System.Drawing.Size(67, 13);
            this.lklCadastro.TabIndex = 6;
            this.lklCadastro.TabStop = true;
            this.lklCadastro.Text = "Se cadastrar";
            this.lklCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCadastro_LinkClicked);
            // 
            // pgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(291, 273);
            this.Controls.Add(this.lklCadastro);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.labSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(labLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "pgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.MaskedTextBox txbLogin;
        private System.Windows.Forms.MaskedTextBox txbSenha;
        private System.Windows.Forms.LinkLabel lklCadastro;
    }
}

