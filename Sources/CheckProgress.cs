using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRPLancher.Sources
{
    public partial class CheckProgress : Form
    {
        public CheckProgress()
        {
            InitializeComponent();
        }
        public string text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public int progress
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                progressBar1.Value = value;
            }
        }
    }
}
