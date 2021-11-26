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
            Panel ResizePanel = this.PnlCreateRein;
            ResizePanel.Width = 1357;
            ResizePanel.Height = 1650;
            ResizePanel.Location = new Point(0,77);

            ChangeHeight(1700);
            this.PnlCreateRein.Visible = !this.PnlCreateRein.Visible;
        }

        private void ChangeHeight(int size)
        {
            int window = Convert.ToInt32(SystemParameters.FullPrimaryScreenHeight);
            this.Container.Height = this.Container.Height != size ? size : window;
        }
    }
}
