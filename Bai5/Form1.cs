using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radRoman.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?",
                                                "Confirm",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void radRoman_CheckedChanged(object sender, EventArgs e)
        {
            if(radRoman.Checked) 
                rtfVanBan.Font = new Font("Times New Roman", 20);
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked)
                rtfVanBan.Font = new Font("Arial", 20);
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma.Checked)
                rtfVanBan.Font = new Font("Tahoma", 20);
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourierNew.Checked)
                rtfVanBan.Font = new Font("CourierNew", 20);
        }
    }
}
