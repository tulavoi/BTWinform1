using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trkRed.Value = 0;
            trkGreen.Value = 0;
            trkBlue.Value = 0; 

            trkRed.Maximum = 225;
            trkGreen.Maximum = 225;
            trkBlue.Maximum = 225;
            UpdateLabelsAndPanelColor();
        }

        private void UpdateLabelsAndPanelColor()
        {
            int red = trkRed.Value;
            int green = trkGreen.Value;
            int blue = trkBlue.Value;
            lblRed.Text = $"R = {red}";
            lblGreen.Text = $"G = {green}";
            lblBlue.Text = $"B = {blue}";
            panel1.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void trkRed_Scroll(object sender, EventArgs e)
        {
            UpdateLabelsAndPanelColor();
        }

        private void trkGreen_Scroll(object sender, EventArgs e)
        {
            UpdateLabelsAndPanelColor();
        }

        private void trkBlue_Scroll(object sender, EventArgs e)
        {
            UpdateLabelsAndPanelColor();
        }
    }
}
