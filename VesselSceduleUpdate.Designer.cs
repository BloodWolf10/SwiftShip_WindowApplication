namespace SwiftShip_WindowApplication
{
    partial class VesselSceduleUpdate
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
            this.CargoTypeList = new System.Windows.Forms.ListBox();
            this.lblcargotype = new System.Windows.Forms.Label();
            this.txtbxvesseltype = new System.Windows.Forms.TextBox();
            this.lblvesseltype = new System.Windows.Forms.Label();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtbxEstimatedTime = new System.Windows.Forms.TextBox();
            this.txtbxVesselName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.VesselDataGrid = new System.Windows.Forms.DataGridView();
            this.lblVesselId = new System.Windows.Forms.Label();
            this.txtBxVesselID = new System.Windows.Forms.TextBox();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.txtBxSelectedVessel = new System.Windows.Forms.TextBox();
            this.lblSelectVessel = new System.Windows.Forms.Label();
            this.UpdateBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VesselDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.SuspendLayout();
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
            this.CargoTypeList.Location = new System.Drawing.Point(1006, 427);
            this.CargoTypeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargoTypeList.Name = "CargoTypeList";
            this.CargoTypeList.Size = new System.Drawing.Size(292, 28);
            this.CargoTypeList.TabIndex = 26;
            this.CargoTypeList.SelectedIndexChanged += new System.EventHandler(this.CargoTypeList_SelectedIndexChanged);
            // 
            // lblcargotype
            // 
            this.lblcargotype.AutoSize = true;
            this.lblcargotype.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargotype.Location = new System.Drawing.Point(820, 427);
            this.lblcargotype.Name = "lblcargotype";
            this.lblcargotype.Size = new System.Drawing.Size(104, 29);
            this.lblcargotype.TabIndex = 25;
            this.lblcargotype.Text = "Cargo Type:";
            // 
            // txtbxvesseltype
            // 
            this.txtbxvesseltype.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxvesseltype.Location = new System.Drawing.Point(1006, 302);
            this.txtbxvesseltype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxvesseltype.Name = "txtbxvesseltype";
            this.txtbxvesseltype.Size = new System.Drawing.Size(296, 35);
            this.txtbxvesseltype.TabIndex = 24;
            // 
            // lblvesseltype
            // 
            this.lblvesseltype.AutoSize = true;
            this.lblvesseltype.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvesseltype.Location = new System.Drawing.Point(816, 308);
            this.lblvesseltype.Name = "lblvesseltype";
            this.lblvesseltype.Size = new System.Drawing.Size(107, 29);
            this.lblvesseltype.TabIndex = 23;
            this.lblvesseltype.Text = "Vessel Type:";
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateBackPanel.Location = new System.Drawing.Point(659, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1153, 114);
            this.UpdateBackPanel.TabIndex = 22;
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(337, 25);
            this.lblUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(419, 57);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Vessel Scheduling Update";
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CustomFormat = "dd/MM/yyyy";
            this.DepartureDatePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDatePicker.Location = new System.Drawing.Point(1010, 475);
            this.DepartureDatePicker.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(292, 35);
            this.DepartureDatePicker.TabIndex = 21;
            this.DepartureDatePicker.Value = new System.DateTime(2023, 8, 20, 0, 0, 0, 0);
            // 
            // txtbxEstimatedTime
            // 
            this.txtbxEstimatedTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEstimatedTime.Location = new System.Drawing.Point(1006, 548);
            this.txtbxEstimatedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxEstimatedTime.Name = "txtbxEstimatedTime";
            this.txtbxEstimatedTime.Size = new System.Drawing.Size(296, 35);
            this.txtbxEstimatedTime.TabIndex = 19;
            // 
            // txtbxVesselName
            // 
            this.txtbxVesselName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxVesselName.Location = new System.Drawing.Point(1010, 358);
            this.txtbxVesselName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxVesselName.Name = "txtbxVesselName";
            this.txtbxVesselName.Size = new System.Drawing.Size(296, 35);
            this.txtbxVesselName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Departure Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Estimated Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(816, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vessel Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(907, 638);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 52);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(1173, 638);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 52);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // VesselDataGrid
            // 
            this.VesselDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VesselDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VesselDataGrid.Location = new System.Drawing.Point(1336, 177);
            this.VesselDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VesselDataGrid.Name = "VesselDataGrid";
            this.VesselDataGrid.RowHeadersWidth = 62;
            this.VesselDataGrid.RowTemplate.Height = 28;
            this.VesselDataGrid.Size = new System.Drawing.Size(430, 529);
            this.VesselDataGrid.TabIndex = 29;
            this.VesselDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VesselDataGrid_CellContentClick);
            // 
            // lblVesselId
            // 
            this.lblVesselId.AutoSize = true;
            this.lblVesselId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselId.Location = new System.Drawing.Point(816, 249);
            this.lblVesselId.Name = "lblVesselId";
            this.lblVesselId.Size = new System.Drawing.Size(87, 29);
            this.lblVesselId.TabIndex = 30;
            this.lblVesselId.Text = "Vessel Id:";
            // 
            // txtBxVesselID
            // 
            this.txtBxVesselID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVesselID.Location = new System.Drawing.Point(1010, 243);
            this.txtBxVesselID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxVesselID.Name = "txtBxVesselID";
            this.txtBxVesselID.ReadOnly = true;
            this.txtBxVesselID.Size = new System.Drawing.Size(296, 35);
            this.txtBxVesselID.TabIndex = 31;
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(659, 744);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 15;
            this.LeftPBox.TabStop = false;
            // 
            // txtBxSelectedVessel
            // 
            this.txtBxSelectedVessel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSelectedVessel.Location = new System.Drawing.Point(1006, 185);
            this.txtBxSelectedVessel.Name = "txtBxSelectedVessel";
            this.txtBxSelectedVessel.ReadOnly = true;
            this.txtBxSelectedVessel.Size = new System.Drawing.Size(292, 32);
            this.txtBxSelectedVessel.TabIndex = 32;
            // 
            // lblSelectVessel
            // 
            this.lblSelectVessel.AutoSize = true;
            this.lblSelectVessel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVessel.Location = new System.Drawing.Point(785, 188);
            this.lblSelectVessel.Name = "lblSelectVessel";
            this.lblSelectVessel.Size = new System.Drawing.Size(173, 29);
            this.lblSelectVessel.TabIndex = 33;
            this.lblSelectVessel.Text = "Selected Vessel IMO:";
            // 
            // VesselSceduleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 744);
            this.Controls.Add(this.lblSelectVessel);
            this.Controls.Add(this.txtBxSelectedVessel);
            this.Controls.Add(this.txtBxVesselID);
            this.Controls.Add(this.lblVesselId);
            this.Controls.Add(this.VesselDataGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CargoTypeList);
            this.Controls.Add(this.lblcargotype);
            this.Controls.Add(this.txtbxvesseltype);
            this.Controls.Add(this.lblvesseltype);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.txtbxEstimatedTime);
            this.Controls.Add(this.txtbxVesselName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPBox);
            this.Name = "VesselSceduleUpdate";
            this.Text = "VesselSceduleUpdate";
            this.Load += new System.EventHandler(this.VesselSceduleUpdate_Load);
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VesselDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CargoTypeList;
        private System.Windows.Forms.Label lblcargotype;
        private System.Windows.Forms.TextBox txtbxvesseltype;
        private System.Windows.Forms.Label lblvesseltype;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblUpdateAccount;
        private System.Windows.Forms.DateTimePicker DepartureDatePicker;
        private System.Windows.Forms.TextBox txtbxEstimatedTime;
        private System.Windows.Forms.TextBox txtbxVesselName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView VesselDataGrid;
        private System.Windows.Forms.Label lblVesselId;
        private System.Windows.Forms.TextBox txtBxVesselID;
        private System.Windows.Forms.TextBox txtBxSelectedVessel;
        private System.Windows.Forms.Label lblSelectVessel;
    }
}