using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Net.Http;
using SCAC.Src.Classes;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using static System.Windows.Forms.ListView;

namespace SCAC.Pages
{
    public partial class pgHome : Form
    {
        public pgHome()
        {
            InitializeComponent();
        }

        private void PgHome_Shown(object sender, EventArgs e)
        {
            pgLogin login = new pgLogin
            {
                WindowState = FormWindowState.Normal
            };
            login.Show();
        } 

         private void TsmiRegiReinvindication_Click(object sender, EventArgs e)
        {
            //redimencionando e mostrando o painel de criar reinvindicação
            ChangeHeight(1700);
            PnlCreateRein.Width = 1357;
            PnlCreateRein.Height = 1650;
            PnlCreateRein.Location = new Point(0,77);

            InserirDadosMorador();
            InserirDadosLider();
            InserirDadosOrgPublic();
            InserirDadadosStatus();
            InserirDadosPrioridade();

            this.PnlCreateRein.Visible = !this.PnlCreateRein.Visible;
        }

        private void ChangeHeight(int size)
        {
            int window = Convert.ToInt32(SystemParameters.FullPrimaryScreenHeight);
            this.Container.Height = this.Container.Height != size ? size : window;
        }


        private void InserirDadosPrioridade()
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/priority";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Prioridade> prioridade = JsonConvert.DeserializeObject<List<Prioridade>>(objResponse.ToString());


                for (int i = 0; i < prioridade.Count; i++)
                {
                    CmbPriority.Items.Add(prioridade[i].description);
                }
                cliente.Close();
            }
        }
        private void InserirDadadosStatus()
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/status";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Status> status = JsonConvert.DeserializeObject<List<Status>>(objResponse.ToString());


                for (int i = 0; i < status.Count; i++)
                {
                    CmbStatus.Items.Add(status[i].description);
                }
                cliente.Close();
            }
        }
        private void InserirDadosMorador()
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/resident";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados =  cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Morador> moradores = JsonConvert.DeserializeObject<List<Morador>>(objResponse.ToString());

                LtvResident.Items.Clear();

                for (int i = 0; i < moradores.Count; i++)
                {
                    ListViewItem item = LtvResident.Items.Add(moradores[i].id.ToString());
                    item.SubItems.Add(moradores[i].fullName);
                    item.SubItems.Add(moradores[i].birthday);
                    item.SubItems.Add(moradores[i].sex.ToString());
                    item.SubItems.Add(moradores[i].cpf);
                    item.SubItems.Add(moradores[i].rg);
                    item.SubItems.Add(moradores[i].telephone);
                    item.SubItems.Add(moradores[i].number);
                    item.SubItems.Add(moradores[i].address);
                    item.SubItems.Add(moradores[i].district);
                    item.SubItems.Add(moradores[i].cep);
                    item.SubItems.Add(moradores[i].city);
                    item.SubItems.Add(moradores[i].uf);
                    item.SubItems.Add(moradores[i].complement);
                }
                cliente.Close();
            }
        }
        private void InserirDadosLider()
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/leader";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<LiderComunitario> lider = JsonConvert.DeserializeObject<List<LiderComunitario>>(objResponse.ToString());

                LtvLeader.Items.Clear();

                for (int i = 0; i < lider.Count; i++)
                {
                    ListViewItem item = LtvLeader.Items.Add(lider[i].id.ToString());
                    item.SubItems.Add(lider[i].fullName);
                    item.SubItems.Add(lider[i].cpf.ToString());
                    item.SubItems.Add(lider[i].rg);
                    item.SubItems.Add(lider[i].entryDate.ToString());
                    item.SubItems.Add(lider[i].exitDate.ToString());
                }
                cliente.Close();
            }
        }
        private void InserirDadosOrgPublic()
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/orgPublic";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<OrgPublico> orgPublic = JsonConvert.DeserializeObject<List<OrgPublico>>(objResponse.ToString());

                LtvOrgPublic.Items.Clear();

                for (int i = 0; i < orgPublic.Count; i++)
                {
                    ListViewItem item = LtvOrgPublic.Items.Add(orgPublic[i].id.ToString());
                    item.SubItems.Add(orgPublic[i].name);
                    item.SubItems.Add(orgPublic[i].responsible);
                    item.SubItems.Add(orgPublic[i].telephone.ToString());
                    item.SubItems.Add(orgPublic[i].email);
                }
                cliente.Close();
            }
        }

        async private void BtnSaveRein_Click(object sender, EventArgs e)
        {
            Reinvidacao reinvindicacao = new Reinvidacao()
            {
                description = TxbDescription.Text,
                openDate = CldOpenDate.SelectionStart.ToString("dd/MM/yyyy"),
                idLeader = Convert.ToInt32(LtvLeader.SelectedItems[0].Text),
                idResident = Convert.ToInt32(LtvResident.SelectedItems[0].Text),
                idStatus = CmbStatus.SelectedIndex + 1,
                idOrgPublic = Convert.ToInt32(LtvOrgPublic.SelectedItems[0].Text),
                idPriority = CmbPriority.SelectedIndex + 1
            };

             var json = JsonConvert.SerializeObject(reinvindicacao);

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://api-scac.azurewebsites.net");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var request = await cliente.PostAsync("/api/v1/vindication", content);
                var response = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    ChangeHeight(1700);
                    PnlCreateRein.Width = 1357;
                    PnlCreateRein.Height = 200;
                    this.PnlCreateRein.Visible = false;

                }
                cliente.Dispose();

            }
        }
    }
}
