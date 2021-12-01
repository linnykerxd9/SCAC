using Newtonsoft.Json;
using SCAC.Src.Classes;
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

namespace SCAC.Pages
{
    public partial class pgCadastro : Form
    {
        public pgCadastro()
        {
            InitializeComponent();
        }

        async private void BtnRegistration_Click(object sender, EventArgs e)
        {
            LiderComunitario leader = new LiderComunitario {
                fullName = this.TxbFullName.Text,
                cpf = this.TxbCpf.Text,
                rg = this.TxbRg.Text,
                login = this.TxbLogin.Text,
                password = this.TxbPassword.Text,
                entryDate = DateTime.Now
                };

           var json =  JsonConvert.SerializeObject(leader);


            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://api-scac.azurewebsites.net");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var request = await cliente.PostAsync("/api/v1/leader", content);

                if (request.IsSuccessStatusCode)
                {
                    this.Close();
                    pgLogin login = new pgLogin
                    {
                        WindowState = FormWindowState.Normal
                    };
                    login.Show();
                }
                cliente.Dispose();

            }
        }
    }
}
