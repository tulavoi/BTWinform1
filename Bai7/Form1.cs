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

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSo.Focus();
            cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtSo.Text);
            cboSo.Items.Add(num);
            txtSo.Clear();
            txtSo.Focus();
            cboSo.SelectedIndex = cboSo.Items.Count - 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
                Close();
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSo.Text, @"^[0-9]*(\.[0-9]+)?$"))
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtSo, "Số không hợp lệ");
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSo.Items.Clear();
            int selectedNum = (int)cboSo.SelectedItem;
            for (int i = 1; i <= selectedNum; i++)
            {
                if (selectedNum % i == 0)
                    lstSo.Items.Add(i);
            }
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCapNhat_Click(sender, e);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
                sum += (int)lstSo.Items[i];

            MessageBox.Show($"Tổng các ước số: {sum}");
        }

        private void btnSLChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if ((int)lstSo.Items[i] % 2 == 0)
                    count++;
            }
            MessageBox.Show($"Số lượng các ước số chẵn: {count}");
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                if (IsPrime((int)lstSo.Items[i]))
                    count++;
            }
            MessageBox.Show($"Số lượng các ước số nguyên tố: {count}");
        }

        private bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
