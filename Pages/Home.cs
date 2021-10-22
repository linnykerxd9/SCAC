using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAC.Pages
{
    public partial class pgHome : Form
    {
        public pgHome()
        {
            InitializeComponent();
        }

        private void pgHome_Shown(object sender, EventArgs e)
        {
            pgLogin login = new pgLogin();
            login.Show();
        }
    }
}
