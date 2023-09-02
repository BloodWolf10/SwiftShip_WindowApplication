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
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxEstimatedTime = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.lblvesseltype = new System.Windows.Forms.Label();
            this.txtbxvesseltype = new System.Windows.Forms.TextBox();
            this.lblcargotype = new System.Windows.Forms.Label();
            this.CargoTypeList = new System.Windows.Forms.ListBox();
            this.lblSelectVessel = new System.Windows.Forms.Label();
            this.txtBxSelectedVessel = new System.Windows.Forms.TextBox();
            this.InformationStrip = new System.Windows.Forms.StatusStrip();
            this.fieldInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtBxitemname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.UpdateBackPanel.SuspendLayout();
            this.InformationStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(4, 4);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(659, 780);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 4;
            this.LeftPBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(807, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vessel Name:";
            // 
            // txtbxVesselName
            // 
            this.txtbxVesselName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxVesselName.Location = new System.Drawing.Point(1006, 323);
            this.txtbxVesselName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxVesselName.Name = "txtbxVesselName";
            this.txtbxVesselName.ReadOnly = true;
            this.txtbxVesselName.Size = new System.Drawing.Size(296, 35);
            this.txtbxVesselName.TabIndex = 6;
            this.txtbxVesselName.TextChanged += new System.EventHandler(this.txtbxVesselName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CustomFormat = "yyyy-MM-dd";
            this.DepartureDatePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDatePicker.Location = new System.Drawing.Point(1006, 454);
            this.DepartureDatePicker.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(292, 35);
            this.DepartureDatePicker.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estimated Time:";
            // 
            // txtbxEstimatedTime
            // 
            this.txtbxEstimatedTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEstimatedTime.Location = new System.Drawing.Point(1006, 527);
            this.txtbxEstimatedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxEstimatedTime.Name = "txtbxEstimatedTime";
            this.txtbxEstimatedTime.Size = new System.Drawing.Size(296, 35);
            this.txtbxEstimatedTime.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(1218, 667);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 52);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(852, 667);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 52);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateBackPanel.Location = new System.Drawing.Point(663, 4);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(788, 114);
            this.UpdateBackPanel.TabIndex = 10;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(297, 27);
            this.lblUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(304, 57);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Vessel Scheduling";
            // 
            // lblvesseltype
            // 
            this.lblvesseltype.AutoSize = true;
            this.lblvesseltype.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvesseltype.Location = new System.Drawing.Point(816, 249);
            this.lblvesseltype.Name = "lblvesseltype";
            this.lblvesseltype.Size = new System.Drawing.Size(107, 29);
            this.lblvesseltype.TabIndex = 11;
            this.lblvesseltype.Text = "Vessel Type:";
            // 
            // txtbxvesseltype
            // 
            this.txtbxvesseltype.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxvesseltype.Location = new System.Drawing.Point(1006, 249);
            this.txtbxvesseltype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxvesseltype.Name = "txtbxvesseltype";
            this.txtbxvesseltype.Size = new System.Drawing.Size(296, 35);
            this.txtbxvesseltype.TabIndex = 12;
            this.txtbxvesseltype.TextChanged += new System.EventHandler(this.txtbxvesseltype_TextChanged);
            // 
            // lblcargotype
            // 
            this.lblcargotype.AutoSize = true;
            this.lblcargotype.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargotype.Location = new System.Drawing.Point(820, 394);
            this.lblcargotype.Name = "lblcargotype";
            this.lblcargotype.Size = new System.Drawing.Size(104, 29);
            this.lblcargotype.TabIndex = 13;
            this.lblcargotype.Text = "Cargo Type:";
            // 
            // CargoTypeList
            // 
            this.CargoTypeList.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoTypeList.FormattingEnabled = true;
            this.CargoTypeList.ItemHeight = 24;
            this.CargoTypeList.Items.AddRange(new object[] {
            "General Cargo",
            "Bulk Cargo",
            "Chemicals / Oil",
            "Refrigerated Goods ",
            "Vehicles"});
            this.CargoTypeList.Location = new System.Drawing.Point(1006, 394);
            this.CargoTypeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargoTypeList.Name = "CargoTypeList";
            this.CargoTypeList.Size = new System.Drawing.Size(292, 28);
            this.CargoTypeList.TabIndex = 14;
            this.CargoTypeList.SelectedIndexChanged += new System.EventHandler(this.CargoTypeList_SelectedIndexChanged);
            // 
            // lblSelectVessel
            // 
            this.lblSelectVessel.AutoSize = true;
            this.lblSelectVessel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVessel.Location = new System.Drawing.Point(807, 182);
            this.lblSelectVessel.Name = "lblSelectVessel";
            this.lblSelectVessel.Size = new System.Drawing.Size(173, 29);
            this.lblSelectVessel.TabIndex = 15;
            this.lblSelectVessel.Text = "Selected Vessel IMO:";
            // 
            // txtBxSelectedVessel
            // 
            this.txtBxSelectedVessel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSelectedVessel.Location = new System.Drawing.Point(1006, 182);
            this.txtBxSelectedVessel.Name = "txtBxSelectedVessel";
            this.txtBxSelectedVessel.ReadOnly = true;
            this.txtBxSelectedVessel.Size = new System.Drawing.Size(292, 32);
            this.txtBxSelectedVessel.TabIndex = 16;
            this.txtBxSelectedVessel.MouseLeave += new System.EventHandler(this.txtBxSelectedVessel_MouseLeave);
            this.txtBxSelectedVessel.MouseHover += new System.EventHandler(this.txtBxSelectedVessel_MouseHover);
            // 
            // InformationStrip
            // 
            this.InformationStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.InformationStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldInfo});
            this.InformationStrip.Location = new System.Drawing.Point(663, 754);
            this.InformationStrip.Name = "InformationStrip";
            this.InformationStrip.Size = new System.Drawing.Size(788, 30);
            this.InformationStrip.TabIndex = 17;
            this.InformationStrip.Text = "statusStrip1";
            // 
            // fieldInfo
            // 
            this.fieldInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldInfo.Name = "fieldInfo";
            this.fieldInfo.Size = new System.Drawing.Size(141, 24);
            this.fieldInfo.Text = "Information on item";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(786, 602);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(102, 29);
            this.lblItemName.TabIndex = 18;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtBxitemname
            // 
            this.txtBxitemname.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxitemname.Location = new System.Drawing.Point(1006, 602);
            this.txtBxitemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxitemname.Name = "txtBxitemname";
            this.txtBxitemname.Size = new System.Drawing.Size(296, 35);
            this.txtBxitemname.TabIndex = 19;
            // 
            // VesselScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 789);
            this.Controls.Add(this.txtBxitemname);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.InformationStrip);
            this.Controls.Add(this.txtBxSelectedVessel);
            this.Controls.Add(this.lblSelectVessel);
            this.Controls.Add(this.CargoTypeList);
            this.Controls.Add(this.lblcargotype);
            this.Controls.Add(this.txtbxvesseltype);
            this.Controls.Add(this.lblvesseltype);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.txtbxEstimatedTime);
            this.Controls.Add(this.txtbxVesselName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VesselScheduling";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.Text = "VesselScheduling";
            this.Load += new System.EventHandler(this.VesselScheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            this.InformationStrip.ResumeLayout(false);
            this.InformationStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxVesselName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DepartureDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxEstimatedTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblUpdateAccount;
        private System.Windows.Forms.Label lblvesseltype;
        private System.Windows.Forms.TextBox txtbxvesseltype;
        private System.Windows.Forms.Label lblcargotype;
        private System.Windows.Forms.ListBox CargoTypeList;
        private System.Windows.Forms.Label lblSelectVessel;
        private System.Windows.Forms.TextBox txtBxSelectedVessel;
        private System.Windows.Forms.StatusStrip InformationStrip;
        private System.Windows.Forms.ToolStripStatusLabel fieldInfo;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtBxitemname;
    }
}