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

        //métodos para visualizar os containers
        private void TsmiRegiReinvindication_Click(object sender, EventArgs e)
        {
            //redimencionando e mostrando o painel de criar reinvindicação
            ChangeHeight(1700);
            PnlCreateRein.Width = 1357;
            PnlCreateRein.Height = 1650;
            PnlCreateRein.Location = new Point(0, 77);

            LtvResidentCreateRein.Items.Clear();
            LtvLeaderCreateRein.Items.Clear();
            LtvOrgPublicCreateRein.Items.Clear();
            CmbStatusCreateRein.Items.Clear();
            CmbPriorityCreateRein.Items.Clear();


            PopularTblDadosMorador(LtvResidentCreateRein);
            PopularTblDadosLider(LtvLeaderCreateRein);
            PopularTblDadosOrgPublic(LtvOrgPublicCreateRein);
            PopularTblDadadosStatus(CmbStatusCreateRein);
            PopularTblDadosPrioridade(CmbPriorityCreateRein);

            PnlCreateRein.Visible = !PnlCreateRein.Visible;
            PnlLisRein.Visible = false;
            PnlListPriority.Visible = false;
            PnlCreateResident.Visible = false;
            PnlLisRein.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListEvent.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlListResident.Visible = false;
        }
        private void TsmiListReinvindication_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlLisRein.Width = 1357;
            PnlLisRein.Height = 735;
            PnlLisRein.Location = new Point(0, 77);

            LtvListRein.Items.Clear();

            PopularTblReinvindicacao(LtvListRein);

            PnlLisRein.Visible = !PnlLisRein.Visible;
            PnlCreateRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlCreateResident.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListPriority.Visible = false;

        }
        private void TsmiListResident_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListResident.Width = 1357;
            PnlListResident.Height = 735;
            PnlListResident.Location = new Point(0, 77);
            LtvListResident.Items.Clear();

            PopularTblDadosMorador(LtvListResident);

            PnlCreateRein.Visible = false;
            PnlCreateResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlListPriority.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListEvent.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = !PnlListResident.Visible;
        }
        private void TsmiListLeader_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListLeader.Width = 1357;
            PnlListLeader.Height = 735;
            PnlListLeader.Location = new Point(0, 77);
            LtvListLeader.Items.Clear();

            PopularTblDadosLider(LtvListLeader);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListPriority.Visible = false;
            PnlCreateResident.Visible = false;
            PnlListResident.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListEvent.Visible = false;
            PnlListLeader.Visible = !PnlListLeader.Visible;
        }
        private void TsmiListEvent_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListEvent.Width = 1357;
            PnlListEvent.Height = 735;
            PnlListEvent.Location = new Point(0, 77);
            LtvListEvent.Items.Clear();

            PopularTblEventos(LtvListEvent);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListPriority.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlCreateResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListEvent.Visible = !PnlListEvent.Visible;
        }
        private void TsmiListPublicAgency_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListOrgPub.Width = 1357;
            PnlListOrgPub.Height = 735;
            PnlListOrgPub.Location = new Point(0, 77);
            LtvListOrgPub.Items.Clear();

            PopularTblDadosOrgPublic(LtvListOrgPub);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlCreateResident.Visible = false;
            PnlListPriority.Visible = false;
            PnlListLeader.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = !PnlListOrgPub.Visible;
        }
        private void listarStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListStatus.Width = 1357;
            PnlListStatus.Height = 735;
            PnlListStatus.Location = new Point(0, 77);
            LtvListStatus.Items.Clear();

            PopularTblDadadosStatus(LtvListStatus);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlCreateResident.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListPriority.Visible = false;
            PnlListStatus.Visible = !PnlListStatus.Visible;

        }
        private void listarPrioridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHeight(735);
            PnlListPriority.Width = 1357;
            PnlListPriority.Height = 735;
            PnlListPriority.Location = new Point(0, 77);
            LtvListPriority.Items.Clear();

            PopularTblDadosPrioridade(LtvListPriority);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlCreateResident.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlListStatus.Visible = false;
            PnlListPriority.Visible = !PnlListPriority.Visible;
        }
        private void TsmiRegiEvent_Click(object sender, EventArgs e)
        {
            ChangeHeight(755);
            PnlCreateEvent.Width = 1357;
            PnlCreateEvent.Height = 735;
            PnlCreateEvent.Location = new Point(0, 24);
            CmbStatusCreateEvent.Items.Clear();

            PopularTblDadadosStatus(CmbStatusCreateEvent);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListStatus.Visible = false;
            PnlListPriority.Visible = false;
            PnlCreateResident.Visible = false;
            PnlCreateEvent.Visible = !PnlCreateEvent.Visible;

        }
        private void TsmiRegiResident_Click(object sender, EventArgs e)
        {
            ChangeHeight(890);
            PnlCreateResident.Width = 1357;
            PnlCreateResident.Height = 890;
            PnlCreateResident.Location = new Point(0, 24);

            PnlCreateRein.Visible = false;
            PnlLisRein.Visible = false;
            PnlListResident.Visible = false;
            PnlListLeader.Visible = false;
            PnlListEvent.Visible = false;
            PnlListOrgPub.Visible = false;
            PnlListStatus.Visible = false;
            PnlListPriority.Visible = false;
            PnlCreateEvent.Visible = false;
            PnlCreateResident.Visible = !PnlCreateResident.Visible;
        }




        //métodos de criação
        async private void BtnSaveRein_Click(object sender, EventArgs e)
        {
            Reinvidacao reinvindicacao = new Reinvidacao()
            {
                description = TxbDescriptionCreateRein.Text,
                openDate = CldOpenDateCreateRein.SelectionStart.ToString("dd/MM/yyyy"),
                idLeader = Convert.ToInt32(LtvLeaderCreateRein.SelectedItems[0].Text),
                idResident = Convert.ToInt32(LtvResidentCreateRein.SelectedItems[0].Text),
                idStatus = CmbStatusCreateRein.SelectedIndex + 1,
                idOrgPublic = Convert.ToInt32(LtvOrgPublicCreateRein.SelectedItems[0].Text),
                idPriority = CmbPriorityCreateRein.SelectedIndex + 1
            };

            var json = JsonConvert.SerializeObject(reinvindicacao);

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://api-scac.azurewebsites.net");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var request = await cliente.PostAsync("/api/v1/vindication", content);

                if (request.IsSuccessStatusCode)
                {
                    CreateMessageSuccess("Registro concluído com sucesso");
                    ChangeHeight(740);
                    PnlCreateRein.Width = 1357;
                    PnlCreateRein.Height = 200;
                    PnlCreateRein.Visible = false;


                }
                cliente.Dispose();

            }
        }

        async private void BtnSaveCreateEvent_Click(object sender, EventArgs e)
        {
            Evento newEvent = new Evento()
            {
                nameResponsible = TxbResponsableCreateEvent.Text,
                date = CldDateCreateEvent.SelectionStart.ToString("dd/MM/yyyy"),
                hour = TxbHourCreateEvent.Text,
                description = TxbDescriptionCreateEvent.Text,
                idStatus = CmbStatusCreateEvent.SelectedIndex+1
            };

            var json = JsonConvert.SerializeObject(newEvent);

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://api-scac.azurewebsites.net");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var request = await cliente.PostAsync("/api/v1/event", content);
                var response = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    CreateMessageSuccess("Registro concluído com sucesso");
                    ChangeHeight(740);
                    this.PnlCreateEvent.Visible = false;
                }
                cliente.Dispose();
            }
        }
        async private void BtnSaveCreateResident_Click(object sender, EventArgs e)
        {
            Morador newMorador = new Morador()
            {
                fullName = TxbFullNameCreateResident.Text,
                rg = TxbRgCreateResident.Text,
                cpf = TxbCpfCreateResident.Text,
                birthday = CldBirthdayCreateResident.SelectionStart.ToString("dd/MM/yyyy"),
                telephone = TxbTelephoneCreateResident.Text,
                sex = CmbSexCreateResident.SelectedItem.ToString(),
                address = TxbAddressCreateResident.Text,
                district = TxbDistrictCreateResident.Text,
                number = TxbNumberCreateResident.Text,
                city = TxbCityCreateResident.Text,
                uf = TxbUfCreateResident.Text,
                cep = TxbCepCreateResident.Text,
                complement = TxbComplementCreateResident.Text
            };

            var json = JsonConvert.SerializeObject(newMorador);

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://api-scac.azurewebsites.net");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var request = await cliente.PostAsync("/api/v1/resident", content);
                var response = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    CreateMessageSuccess("Registro concluído com sucesso");
                    ChangeHeight(740);
                    this.PnlCreateResident.Visible = false;
                }
                cliente.Dispose();
            }
        }

        //Métodos para deletar os itens
        async private void BtnDeleteRein_Click(object sender, EventArgs e)
        {
            //Deletando os dados
            LtvListRein.SelectedItems[0].Remove();
        }
        private void BtnDeleteListResi_Click(object sender, EventArgs e)
        {
            LtvListResident.SelectedItems[0].Remove();
        }
        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            LtvListEvent.SelectedItems[0].Remove();
        }

        private void BtnDeleteOrgPub_Click(object sender, EventArgs e)
        {
            LtvListOrgPub.SelectedItems[0].Remove();
        }

        private void BtnDeletePriority_Click(object sender, EventArgs e)
        {
            LtvListPriority.SelectedItems[0].Remove();
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            LtvListStatus.SelectedItems[0].Remove();
        }


        //mostra uma mensagem de sucesso na tela 
        private void CreateMessageSuccess(string message)
        {
            System.Windows.Forms.MessageBox.Show(message,
                                                 "Sucesso",
                                                 System.Windows.Forms.MessageBoxButtons.OK);
        }


        //mudar a altura do container
        private void ChangeHeight(int size)
        {
            int window = Convert.ToInt32(SystemParameters.FullPrimaryScreenHeight);
            this.Container.Height = this.Container.Height != size ? size : window;
        }


        //Todos os métodos de GetAll para popular as tabelas
        private void PopularTblDadosPrioridade(ComboBox list)
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
                    list.Items.Add(prioridade[i].description);
                }
                cliente.Close();
            }
        }
        private void PopularTblDadosPrioridade(ListView list)
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
                    ListViewItem item = list.Items.Add(prioridade[i].id.ToString());
                    item.SubItems.Add(prioridade[i].description);
                }
                cliente.Close();
            }
        }
        private void PopularTblDadadosStatus(ComboBox list)
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
                    list.Items.Add(status[i].description);
                }
                cliente.Close();
            }
        }
        private void PopularTblDadadosStatus(ListView list)
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
                    ListViewItem item = list.Items.Add(status[i].id.ToString());
                    item.SubItems.Add(status[i].description);
                }
                cliente.Close();
            }
        }
        private void PopularTblDadosMorador(ListView list)
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/resident";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Morador> moradores = JsonConvert.DeserializeObject<List<Morador>>(objResponse.ToString());

                LtvResidentCreateRein.Items.Clear();

                for (int i = 0; i < moradores.Count; i++)
                {
                    ListViewItem item = list.Items.Add(moradores[i].id.ToString());
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
        private void PopularTblDadosLider(ListView list)
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

                LtvLeaderCreateRein.Items.Clear();

                for (int i = 0; i < lider.Count; i++)
                {
                    ListViewItem item = list.Items.Add(lider[i].id.ToString());
                    item.SubItems.Add(lider[i].fullName);
                    item.SubItems.Add(lider[i].cpf.ToString());
                    item.SubItems.Add(lider[i].rg);
                    item.SubItems.Add(lider[i].entryDate.ToString());
                    item.SubItems.Add(lider[i].exitDate.ToString());
                }
                cliente.Close();
            }
        }
        private void PopularTblDadosOrgPublic(ListView list)
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

                LtvOrgPublicCreateRein.Items.Clear();

                for (int i = 0; i < orgPublic.Count; i++)
                {
                    ListViewItem item = list.Items.Add(orgPublic[i].id.ToString());
                    item.SubItems.Add(orgPublic[i].name);
                    item.SubItems.Add(orgPublic[i].responsible);
                    item.SubItems.Add(orgPublic[i].telephone.ToString());
                    item.SubItems.Add(orgPublic[i].email);
                }
                cliente.Close();
            }
        }
        private void PopularTblReinvindicacao(ListView list)
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/vindication";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Reinvidacao> vindication = JsonConvert.DeserializeObject<List<Reinvidacao>>(objResponse.ToString());

                LtvOrgPublicCreateRein.Items.Clear();

                for (int i = 0; i < vindication.Count; i++)
                {
                    ListViewItem item = list.Items.Add(vindication[i].id.ToString());
                    item.SubItems.Add(vindication[i].description);
                    item.SubItems.Add(vindication[i].openDate);
                    item.SubItems.Add(vindication[i].completionDate);
                    item.SubItems.Add(vindication[i].Priority.description);
                    item.SubItems.Add(vindication[i].Status.description);
                    item.SubItems.Add(vindication[i].communityLeader.fullName);
                    item.SubItems.Add(vindication[i].Resident.fullName);
                    item.SubItems.Add(vindication[i].Resident.rg);
                    item.SubItems.Add(vindication[i].Resident.cpf);
                    item.SubItems.Add(vindication[i].Resident.telephone);
                    item.SubItems.Add(vindication[i].OrgPublic.name);
                    item.SubItems.Add(vindication[i].OrgPublic.responsible);
                    item.SubItems.Add(vindication[i].OrgPublic.email);
                    item.SubItems.Add(vindication[i].OrgPublic.telephone);
                }
                cliente.Close();
            }
        }
        private void PopularTblEventos(ListView list)
        {
            const string url = "https://api-scac.azurewebsites.net/api/v1/event";
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";

            using (var cliente = requisicaoWeb.GetResponse())
            {

                var streamDados = cliente.GetResponseStream();
                StreamReader reacer = new StreamReader(streamDados);
                object objResponse = reacer.ReadToEnd();
                List<Evento> eventos = JsonConvert.DeserializeObject<List<Evento>>(objResponse.ToString());

                LtvOrgPublicCreateRein.Items.Clear();

                for (int i = 0; i < eventos.Count; i++)
                {
                    ListViewItem item = list.Items.Add(eventos[i].id.ToString());
                    item.SubItems.Add(eventos[i].nameResponsible);
                    item.SubItems.Add(eventos[i].date);
                    item.SubItems.Add(eventos[i].hour);
                    item.SubItems.Add(eventos[i].description);
                    item.SubItems.Add(eventos[i].status.description);
                }
                cliente.Close();
            }
        }

    }
}
