using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teoria_Grafurilor
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {

        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDraw.help = null;
        }
    }
}
