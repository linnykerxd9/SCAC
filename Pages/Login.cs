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
        public pgLogin()
        {
            InitializeComponent();
        }


        private void lklCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            pgCadastro cadastro = new pgCadastro();
            cadastro.Show();
        }
    }
}
