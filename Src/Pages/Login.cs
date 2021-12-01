using Microsoft.AspNetCore.WebUtilities;
using SCAC.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAC
{
    public partial class pgLogin : Form
    {
        public pgLogin()
        {
            InitializeComponent();
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

        async private void btnLogar_Click(object sender, EventArgs e)
        {

            string email = this.txbLogin.Text;
            string senha = this.txbSenha.Text;

            var autenticado = await Login(email, senha);

            if (autenticado.StatusCode == HttpStatusCode.OK)
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

        async private Task<HttpResponseMessage> Login(string login, string password)
        {

            var query = new Dictionary<string, string>();
            query.Add("login", login);
            query.Add("password", password);

            using (var cliente = new HttpClient())
            {
                const string url = "https://api-scac.azurewebsites.net/api/v1/leader/login";

                var newUrl = new Uri(QueryHelpers.AddQueryString(url, query));
                var request = await cliente.GetAsync(newUrl);
                return request;
            }
        }
    }
}
