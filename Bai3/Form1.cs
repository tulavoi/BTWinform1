using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool isInvalid = InvalidString(txtNum1.Text);
            if (isInvalid)
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtNum1, "Not invalid num");
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            bool isInvalid = InvalidString(txtNum2.Text);
            if (isInvalid)
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtNum2, "Not invalid num");
        }

        private bool InvalidString(string text)
        {
            return Regex.IsMatch(text, @"^[0-9]*(\.[0-9]+)?$") && (text.Trim().Length > 0);
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double sum;
            if (radCong.Checked)
            {
                sum = num1 + num2;
                txtResult.Text = sum.ToString();
            }
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double tru;
            if (radTru.Checked)
            {
                tru = num1 - num2;
                txtResult.Text = tru.ToString();
            }
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double nhan;
            if (radNhan.Checked)
            {
                nhan = num1 * num2;
                txtResult.Text = nhan.ToString();
            }
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double chia;
            if (radChia.Checked)
            {
                if (num2 == 0)
                    txtResult.Text = "Không thể chia cho 0";
                else
                {
                    chia = num1 / num2;
                    txtResult.Text = chia.ToString();
                }
            }
        }
    }
}
