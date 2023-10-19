using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radVN_CheckedChanged(object sender, EventArgs e)
        {
            if (radVN.Checked)
            {
                picVN.Visible = true;
                picUSA.Visible = false;
                picJapan.Visible = false;
                picEngland.Visible = false;
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                picUSA.Visible = true;
                picVN.Visible = false;
                picJapan.Visible = false;
                picEngland.Visible = false;
            }
        }

        private void rad日本_CheckedChanged(object sender, EventArgs e)
        {
            if (rad日本.Checked)
            {
                picJapan.Visible = true;
                picUSA.Visible = false;
                picVN.Visible = false;
                picEngland.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radEngland.Checked)
            {
                picEngland.Visible = true;
                picJapan.Visible = false;
                picUSA.Visible = false;
                picVN.Visible = false;
            }
        }
    }
}
