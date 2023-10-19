using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstLopA.Items.Add(txtName.Text);
            txtName.Clear();
            txtName.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstLopA.Items.Clear();
            txtName.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.SelectedItems.Count; i++)
            {
                lstLopB.Items.Add(lstLopA.SelectedItems[i]);
            }
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }
        }

        private void btn2Left_Click(object sender, EventArgs e)
        {
            lstLopB.Items.AddRange(lstLopA.Items);
            lstLopA.Items.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtName, "Không được để trống");
                btnUpdate.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate_Click(sender, e);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopB.SelectedItems.Count; i++)
            {
                lstLopA.Items.Add(lstLopB.SelectedItems[i]);
            }
            for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
            }
        }

        private void btn2Right_Click(object sender, EventArgs e)
        {
            lstLopA.Items.AddRange(lstLopB.Items);
            lstLopB.Items.Clear();
        }
    }
}
