using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VipWinding
{
    public partial class WarningUp : Form
    {
        public WarningUp()
        {
            InitializeComponent();
        }


        public bool W_ans = false;
        public bool W_ch = false;

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            W_ans = true;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            W_ch = true;
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
