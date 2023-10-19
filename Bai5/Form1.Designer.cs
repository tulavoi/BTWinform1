namespace Bai5
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
            this.radRoman = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourierNew = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rtfVanBan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            // 
            // radRoman
            // 
            this.radRoman.AutoSize = true;
            this.radRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRoman.Location = new System.Drawing.Point(258, 95);
            this.radRoman.Name = "radRoman";
            this.radRoman.Size = new System.Drawing.Size(172, 24);
            this.radRoman.TabIndex = 2;
            this.radRoman.TabStop = true;
            this.radRoman.Text = "Times New Roman";
            this.radRoman.UseVisualStyleBackColor = true;
            this.radRoman.CheckedChanged += new System.EventHandler(this.radRoman_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArial.Location = new System.Drawing.Point(258, 137);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(64, 24);
            this.radArial.TabIndex = 3;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTahoma.Location = new System.Drawing.Point(258, 182);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(90, 24);
            this.radTahoma.TabIndex = 4;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourierNew
            // 
            this.radCourierNew.AutoSize = true;
            this.radCourierNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCourierNew.Location = new System.Drawing.Point(258, 227);
            this.radCourierNew.Name = "radCourierNew";
            this.radCourierNew.Size = new System.Drawing.Size(123, 24);
            this.radCourierNew.TabIndex = 5;
            this.radCourierNew.TabStop = true;
            this.radCourierNew.Text = "Courier New";
            this.radCourierNew.UseVisualStyleBackColor = true;
            this.radCourierNew.CheckedChanged += new System.EventHandler(this.radCourierNew_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(172, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rtfVanBan
            // 
            this.rtfVanBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfVanBan.Location = new System.Drawing.Point(42, 83);
            this.rtfVanBan.Name = "rtfVanBan";
            this.rtfVanBan.Size = new System.Drawing.Size(210, 184);
            this.rtfVanBan.TabIndex = 7;
            this.rtfVanBan.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 354);
            this.Controls.Add(this.rtfVanBan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.radCourierNew);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.radRoman);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radRoman;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourierNew;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox rtfVanBan;
    }
}

