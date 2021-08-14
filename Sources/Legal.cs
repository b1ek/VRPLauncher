using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRPLancher.Properties;

namespace VRPLancher
{
    public partial class Legal : Form
    {
        public Legal()
        {
            InitializeComponent();
            licenseText.Rtf = Resources.license;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryConfig.lastVersion = Central.version;
            this.Close();
            Central.openForm1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
