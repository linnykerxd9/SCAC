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
            this.Close();
            pgCadastro cadastro = new pgCadastro();
            cadastro.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.autenticado = true;
        }
    }
}
