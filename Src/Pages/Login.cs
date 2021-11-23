using SCAC.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAC
{
    public partial class pgLogin : Form
    {
        public bool autenticado { get; private set; }

        public pgLogin()
        {
            InitializeComponent();
            autenticado = false;
        }

        private void lklCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Um novo lider foi eleito? esta ação desabilitara o lider anterior,Deseja continuar?";
            if (DialogResult.Yes == MessageBox.Show( message,
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question,
                                                     MessageBoxDefaultButton.Button2))
            {
               
            this.Close();
            pgCadastro cadastro = new pgCadastro
            {
                WindowState = FormWindowState.Normal
            };
            cadastro.Show();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string email = this.txbLogin.Text.ToLower();
            string senha = this.txbSenha.Text.ToLower();

            this.autenticado = login(email, senha);

            if (this.autenticado)
            {
                MessageBox.Show("LOGIN EFETUADO COM SUCESSO",
                                "Sucesso",
                                System.Windows.Forms.MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("LOGIN OU SENHA INCORRETOS",
                                "Error",
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        private bool login(string email, string senha)
        {

            if(email != "admin" || senha != "admin")
            {
                return false;
            }
            return true;
        }
    }
}
