using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRCPowertool
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "program version " + MainForm.Version;
            pictureBoxIcon.Image = Properties.Resources.iconmain.ToBitmap();
        }
    }
}
