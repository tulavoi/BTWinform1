namespace Bai11
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
            this.trkRed = new System.Windows.Forms.TrackBar();
            this.trkGreen = new System.Windows.Forms.TrackBar();
            this.trkBlue = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trkRed
            // 
            this.trkRed.AutoSize = false;
            this.trkRed.Location = new System.Drawing.Point(30, 15);
            this.trkRed.Name = "trkRed";
            this.trkRed.Size = new System.Drawing.Size(139, 37);
            this.trkRed.TabIndex = 0;
            this.trkRed.Scroll += new System.EventHandler(this.trkRed_Scroll);
            // 
            // trkGreen
            // 
            this.trkGreen.AutoSize = false;
            this.trkGreen.Location = new System.Drawing.Point(30, 64);
            this.trkGreen.Name = "trkGreen";
            this.trkGreen.Size = new System.Drawing.Size(139, 37);
            this.trkGreen.TabIndex = 1;
            this.trkGreen.Scroll += new System.EventHandler(this.trkGreen_Scroll);
            // 
            // trkBlue
            // 
            this.trkBlue.AutoSize = false;
            this.trkBlue.Location = new System.Drawing.Point(30, 115);
            this.trkBlue.Name = "trkBlue";
            this.trkBlue.Size = new System.Drawing.Size(139, 37);
            this.trkBlue.TabIndex = 2;
            this.trkBlue.Scroll += new System.EventHandler(this.trkBlue_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(175, 15);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(102, 37);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "R = 0";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGreen.Location = new System.Drawing.Point(175, 64);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(102, 37);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "G = 0";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(185)))));
            this.lblBlue.Location = new System.Drawing.Point(175, 115);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(102, 37);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "B = 0";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(295, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 137);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trkBlue);
            this.Controls.Add(this.trkGreen);
            this.Controls.Add(this.trkRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trkRed;
        private System.Windows.Forms.TrackBar trkGreen;
        private System.Windows.Forms.TrackBar trkBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Panel panel1;
    }
}

