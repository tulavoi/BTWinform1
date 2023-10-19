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
using static System.Net.Mime.MediaTypeNames;

namespace Bai1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close?",
                                                   "Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            txtName.Focus();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length == 0)
                errorProvider1.SetError(txtName, "You must enter Your name");
            else
                errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            string str = $"Your name is: {txtName.Text}\nYour age is: {age.ToString()}";
            MessageBox.Show(str);
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length > 0 && Regex.IsMatch(ctrl.Text, @"^[0-9]+$"))
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtYear, "Not invalid number");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
