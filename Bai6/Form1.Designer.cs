namespace Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEngland = new System.Windows.Forms.RadioButton();
            this.rad日本 = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radVN = new System.Windows.Forms.RadioButton();
            this.picEngland = new System.Windows.Forms.PictureBox();
            this.picVN = new System.Windows.Forms.PictureBox();
            this.picJapan = new System.Windows.Forms.PictureBox();
            this.picUSA = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEngland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJapan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEngland);
            this.groupBox1.Controls.Add(this.rad日本);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Controls.Add(this.radVN);
            this.groupBox1.Location = new System.Drawing.Point(44, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(215, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radEngland
            // 
            this.radEngland.AutoSize = true;
            this.radEngland.Location = new System.Drawing.Point(45, 205);
            this.radEngland.Name = "radEngland";
            this.radEngland.Size = new System.Drawing.Size(90, 24);
            this.radEngland.TabIndex = 5;
            this.radEngland.TabStop = true;
            this.radEngland.Text = "England";
            this.radEngland.UseVisualStyleBackColor = true;
            this.radEngland.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rad日本
            // 
            this.rad日本.AutoSize = true;
            this.rad日本.Location = new System.Drawing.Point(45, 151);
            this.rad日本.Name = "rad日本";
            this.rad日本.Size = new System.Drawing.Size(64, 24);
            this.rad日本.TabIndex = 4;
            this.rad日本.TabStop = true;
            this.rad日本.Text = "日本";
            this.rad日本.UseVisualStyleBackColor = true;
            this.rad日本.CheckedChanged += new System.EventHandler(this.rad日本_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(45, 97);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(64, 24);
            this.radUSA.TabIndex = 3;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radVN
            // 
            this.radVN.AutoSize = true;
            this.radVN.Location = new System.Drawing.Point(45, 43);
            this.radVN.Name = "radVN";
            this.radVN.Size = new System.Drawing.Size(99, 24);
            this.radVN.TabIndex = 2;
            this.radVN.TabStop = true;
            this.radVN.Text = "Việt Nam";
            this.radVN.UseVisualStyleBackColor = true;
            this.radVN.CheckedChanged += new System.EventHandler(this.radVN_CheckedChanged);
            // 
            // picEngland
            // 
            this.picEngland.Image = ((System.Drawing.Image)(resources.GetObject("picEngland.Image")));
            this.picEngland.Location = new System.Drawing.Point(339, 159);
            this.picEngland.Name = "picEngland";
            this.picEngland.Size = new System.Drawing.Size(318, 186);
            this.picEngland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEngland.TabIndex = 2;
            this.picEngland.TabStop = false;
            this.picEngland.Visible = false;
            // 
            // picVN
            // 
            this.picVN.Image = ((System.Drawing.Image)(resources.GetObject("picVN.Image")));
            this.picVN.Location = new System.Drawing.Point(339, 159);
            this.picVN.Name = "picVN";
            this.picVN.Size = new System.Drawing.Size(318, 186);
            this.picVN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVN.TabIndex = 3;
            this.picVN.TabStop = false;
            // 
            // picJapan
            // 
            this.picJapan.Image = ((System.Drawing.Image)(resources.GetObject("picJapan.Image")));
            this.picJapan.Location = new System.Drawing.Point(339, 159);
            this.picJapan.Name = "picJapan";
            this.picJapan.Size = new System.Drawing.Size(318, 186);
            this.picJapan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJapan.TabIndex = 4;
            this.picJapan.TabStop = false;
            this.picJapan.Visible = false;
            // 
            // picUSA
            // 
            this.picUSA.Image = ((System.Drawing.Image)(resources.GetObject("picUSA.Image")));
            this.picUSA.Location = new System.Drawing.Point(339, 159);
            this.picUSA.Name = "picUSA";
            this.picUSA.Size = new System.Drawing.Size(318, 186);
            this.picUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUSA.TabIndex = 5;
            this.picUSA.TabStop = false;
            this.picUSA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 447);
            this.Controls.Add(this.picUSA);
            this.Controls.Add(this.picJapan);
            this.Controls.Add(this.picVN);
            this.Controls.Add(this.picEngland);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEngland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJapan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEngland;
        private System.Windows.Forms.RadioButton rad日本;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radVN;
        private System.Windows.Forms.PictureBox picEngland;
        private System.Windows.Forms.PictureBox picVN;
        private System.Windows.Forms.PictureBox picJapan;
        private System.Windows.Forms.PictureBox picUSA;
    }
}

