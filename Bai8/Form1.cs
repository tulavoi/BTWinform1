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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSo.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtSo.Text);
            lstSo.Items.Add(num);
            txtSo.Clear();
            txtSo.Focus();
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSo.Text, @"^[0-9]*(\.[0-9]+)?$") && txtSo.Text.Trim().Length > 0)
            {
                errorProvider1.Clear();
                btnNhap.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtSo, "Số không hợp lệ");
                btnNhap.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in lstSo.Items)
                sum += i;
            MessageBox.Show($"Tổng các phần tử: {sum}");
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnNhap_Click(sender, e);
        }

        private void btnXoaPTDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnPTDangChon_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndex != -1)
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
        }

        private void btnTangPT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int k = (int)lstSo.Items[i] + 2;
                lstSo.Items[i] = k;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if ((int)lstSo.Items[i] % 2 == 0)
                    lstSo.SelectedIndex = i;
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if ((int)lstSo.Items[i] % 2 != 0)
                    lstSo.SelectedIndex = i;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                double square = Convert.ToDouble(lstSo.Items[i]) * Convert.ToDouble(lstSo.Items[i]);
                lstSo.Items[i] = square;
            }
        }
    }
}
