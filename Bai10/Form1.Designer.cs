namespace Bai10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.radHK3 = new System.Windows.Forms.RadioButton();
            this.radHK4 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chklbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbSemester = new System.Windows.Forms.GroupBox();
            this.grbSemester.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV: ";
            // 
            // txtMSSV
            // 
            this.txtMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSSV.Location = new System.Drawing.Point(192, 61);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(305, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(192, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(305, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Niên khóa: ";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cboKhoa.Location = new System.Drawing.Point(192, 151);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(216, 24);
            this.cboKhoa.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "TT01",
            "TT02",
            "TT03",
            "TT04",
            "TT05",
            "TT06"});
            this.cboLop.Location = new System.Drawing.Point(192, 201);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(216, 24);
            this.cboLop.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Học kỳ: ";
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK1.Location = new System.Drawing.Point(6, 14);
            this.radHK1.Name = "radHK1";
            this.radHK1.Size = new System.Drawing.Size(35, 21);
            this.radHK1.TabIndex = 5;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "I";
            this.radHK1.UseVisualStyleBackColor = true;
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK2.Location = new System.Drawing.Point(82, 14);
            this.radHK2.Name = "radHK2";
            this.radHK2.Size = new System.Drawing.Size(41, 21);
            this.radHK2.TabIndex = 6;
            this.radHK2.TabStop = true;
            this.radHK2.Text = "II";
            this.radHK2.UseVisualStyleBackColor = true;
            // 
            // radHK3
            // 
            this.radHK3.AutoSize = true;
            this.radHK3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK3.Location = new System.Drawing.Point(164, 14);
            this.radHK3.Name = "radHK3";
            this.radHK3.Size = new System.Drawing.Size(47, 21);
            this.radHK3.TabIndex = 7;
            this.radHK3.TabStop = true;
            this.radHK3.Text = "III";
            this.radHK3.UseVisualStyleBackColor = true;
            // 
            // radHK4
            // 
            this.radHK4.AutoSize = true;
            this.radHK4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHK4.Location = new System.Drawing.Point(252, 14);
            this.radHK4.Name = "radHK4";
            this.radHK4.Size = new System.Drawing.Size(45, 21);
            this.radHK4.TabIndex = 8;
            this.radHK4.TabStop = true;
            this.radHK4.Text = "IV";
            this.radHK4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Môn học:  ";
            // 
            // chklbMonHoc
            // 
            this.chklbMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklbMonHoc.CheckOnClick = true;
            this.chklbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbMonHoc.FormattingEnabled = true;
            this.chklbMonHoc.Items.AddRange(new object[] {
            "KTLT",
            "MMT",
            "Tin Học",
            "Tiếng Anh",
            "OOP",
            "LTUD"});
            this.chklbMonHoc.Location = new System.Drawing.Point(192, 298);
            this.chklbMonHoc.Name = "chklbMonHoc";
            this.chklbMonHoc.ScrollAlwaysVisible = true;
            this.chklbMonHoc.Size = new System.Drawing.Size(216, 97);
            this.chklbMonHoc.TabIndex = 9;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(95, 421);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(80, 33);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "&Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 421);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 33);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(415, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 33);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbSemester
            // 
            this.grbSemester.Controls.Add(this.radHK3);
            this.grbSemester.Controls.Add(this.radHK1);
            this.grbSemester.Controls.Add(this.radHK2);
            this.grbSemester.Controls.Add(this.radHK4);
            this.grbSemester.Location = new System.Drawing.Point(192, 241);
            this.grbSemester.Name = "grbSemester";
            this.grbSemester.Size = new System.Drawing.Size(305, 43);
            this.grbSemester.TabIndex = 13;
            this.grbSemester.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 491);
            this.Controls.Add(this.grbSemester);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.chklbMonHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Môn học: ";
            this.grbSemester.ResumeLayout(false);
            this.grbSemester.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.RadioButton radHK3;
        private System.Windows.Forms.RadioButton radHK4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chklbMonHoc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbSemester;
    }
}

