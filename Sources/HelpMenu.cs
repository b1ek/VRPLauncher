using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRPLancher.Sources;

namespace VRPLancher
{
    public partial class HelpMenu : Form
    {
        public HelpMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Legal agreement = new Legal();
            agreement.agree.Enabled = false;
            agreement.disagree.Enabled = false;
            agreement.Show();
            this.Close();
        }

        private void github_Click(object sender, EventArgs e)
        {
            Browser.open("https://github.com/b1ek/VRPLauncher");
            this.Close();
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Browser.open("https://discord.com/invite/SknQerfZha");
            this.Close();
        }
    }
}
