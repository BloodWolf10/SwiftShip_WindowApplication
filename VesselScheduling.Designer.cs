namespace SwiftShip_WindowApplication
{
    partial class VesselScheduling
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
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.UpdateBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Location = new System.Drawing.Point(505, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(520, 142);
            this.UpdateBackPanel.TabIndex = 2;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(108, 42);
            this.lblUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(363, 68);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Vessel Scheduling";
            // 
            // LeftPBox
            // 
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(1, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(505, 731);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 4;
            this.LeftPBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vessel Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(691, 508);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estimated Time:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(691, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 26);
            this.textBox2.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(625, 156);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // VesselScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPBox);
            this.Controls.Add(this.UpdateBackPanel);
            this.Name = "VesselScheduling";
            this.Text = "VesselScheduling";
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblUpdateAccount;
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}