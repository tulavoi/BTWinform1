using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (a == 0)
            {
                if (b == 0)
                    txtNghiem.Text = "Phương trình vô số nghiệm";
                else
                    txtNghiem.Text = "Phương trình vô nghiệm";
                btnXoa.Enabled = true;
                btnGiai.Enabled = false;
            }
            else
            {
                double x = -b / a;
                txtNghiem.Text = x.ToString(); 
                btnXoa.Enabled = true;
                btnGiai.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            txtA.Focus();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            bool isInvalid = InvalidString(txtA.Text);
            if (isInvalid)
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtA, "Not invalid number");
            UpdateBtnGiai();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            bool isInvalid = InvalidString(txtB.Text);
            if (isInvalid)
                errorProvider1.Clear();
            else
                errorProvider1.SetError(txtB, "Not invalid number");
            UpdateBtnGiai();
        }

        private bool InvalidString(string text)
        {
            // Kiểm tra text không trống và phải là số nguyên hoặc số thực
            return Regex.IsMatch(text, @"^[0-9]*(\.[0-9]+)?$") && (text.Trim().Length > 0);
        }

        private void UpdateBtnGiai()
        {
            // Cập nhật lại nút giải dựa vào tính hợp lệ của txtA và txtB
            btnGiai.Enabled = InvalidString(txtA.Text) && InvalidString(txtB.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lúc đầu, nút giải và nút xóa bị vô hiệu hóa 
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
