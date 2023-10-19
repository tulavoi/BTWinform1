using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMSSV.Focus();
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cboKhoa.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            radHK1.Checked = false; 
            radHK2.Checked = false;
            radHK2.Checked = false;
            radHK4.Checked = false;
            for (int i = 0; i < chklbMonHoc.Items.Count; i++)
                chklbMonHoc.SetItemChecked(i, false);

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hocKy = SelectedSemester();
            
            MessageBox.Show($"Sinh viên: {txtHoTen.Text}\n" +
                $"Lớp: {cboLop.SelectedItem}\n" +
                $"Niên khóa: {cboKhoa.SelectedItem}\n" +
                $"Đã đăng ký {hocKy}, các môn học:\n" +
                PrintSelectedSubject());
        }

        private string PrintSelectedSubject()
        {
            string msg = "";
            int count = 1;
            for (int i = 0; i < chklbMonHoc.Items.Count; i++)
            {
                if (chklbMonHoc.GetItemChecked(i))
                    msg += $"{count++}. {chklbMonHoc.Items[i]} \n";
            }
            return msg;
        }

        private string SelectedSemester()
        {
            foreach (Control control in grbSemester.Controls)
            {
                if (control is RadioButton rad && rad.Checked)
                    return $"Học kỳ {rad.Text}";
            }
            return null;
        }
    }
}
