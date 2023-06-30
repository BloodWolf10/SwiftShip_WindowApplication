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
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxVesselName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxEstimatedTime = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.UpdateBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(741, 986);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 4;
            this.LeftPBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(923, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vessel Name:";
            // 
            // txtbxVesselName
            // 
            this.txtbxVesselName.Location = new System.Drawing.Point(1110, 543);
            this.txtbxVesselName.Name = "txtbxVesselName";
            this.txtbxVesselName.Size = new System.Drawing.Size(333, 26);
            this.txtbxVesselName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(908, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1110, 614);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(324, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estimated Time:";
            // 
            // txtbxEstimatedTime
            // 
            this.txtbxEstimatedTime.Location = new System.Drawing.Point(1110, 698);
            this.txtbxEstimatedTime.Name = "txtbxEstimatedTime";
            this.txtbxEstimatedTime.Size = new System.Drawing.Size(333, 26);
            this.txtbxEstimatedTime.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1084, 226);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(1457, 826);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 65);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(1301, 826);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 65);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateBackPanel.Location = new System.Drawing.Point(741, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(924, 142);
            this.UpdateBackPanel.TabIndex = 10;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(334, 34);
            this.lblUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(363, 68);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Vessel Scheduling";
            // 
            // VesselScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 986);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbxEstimatedTime);
            this.Controls.Add(this.txtbxVesselName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VesselScheduling";
            this.Text = "VesselScheduling";
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxVesselName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxEstimatedTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblUpdateAccount;
    }
}