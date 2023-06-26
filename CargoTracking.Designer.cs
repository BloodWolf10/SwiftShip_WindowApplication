namespace SwiftShip_WindowApplication
{
    partial class CargoTracking
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
            this.lblCargoTracking = new System.Windows.Forms.Label();
            this.CargoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCargoInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCargoID = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblReceiverName = new System.Windows.Forms.Label();
            this.lblShippingDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblCargoStatus = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.lblCargoInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBxCargoId = new System.Windows.Forms.TextBox();
            this.txtBxSenderName = new System.Windows.Forms.TextBox();
            this.txtBxReceiverName = new System.Windows.Forms.TextBox();
            this.textBxWeight = new System.Windows.Forms.TextBox();
            this.txtBxTrackingNumber = new System.Windows.Forms.TextBox();
            this.txtBxDimensions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalenderShipDate = new System.Windows.Forms.MonthCalendar();
            this.CalendarDeliveryDate = new System.Windows.Forms.MonthCalendar();
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            this.DropListCargoStatus = new System.Windows.Forms.ComboBox();
            this.txtBxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBxDimension = new System.Windows.Forms.TextBox();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.UpdateBackPanel.SuspendLayout();
            this.CargoMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblCargoTracking);
            this.UpdateBackPanel.Controls.Add(this.CargoMenuStrip);
            this.UpdateBackPanel.Location = new System.Drawing.Point(318, 0);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1012, 116);
            this.UpdateBackPanel.TabIndex = 6;
            // 
            // lblCargoTracking
            // 
            this.lblCargoTracking.AutoSize = true;
            this.lblCargoTracking.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoTracking.ForeColor = System.Drawing.Color.White;
            this.lblCargoTracking.Location = new System.Drawing.Point(362, 61);
            this.lblCargoTracking.Name = "lblCargoTracking";
            this.lblCargoTracking.Size = new System.Drawing.Size(207, 46);
            this.lblCargoTracking.TabIndex = 0;
            this.lblCargoTracking.Text = "Cargo Tracking";
            // 
            // CargoMenuStrip
            // 
            this.CargoMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CargoMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveInfoToolStripMenuItem,
            this.trackCargoToolStripMenuItem,
            this.updateCargoInfoToolStripMenuItem});
            this.CargoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CargoMenuStrip.Name = "CargoMenuStrip";
            this.CargoMenuStrip.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.CargoMenuStrip.Size = new System.Drawing.Size(1012, 61);
            this.CargoMenuStrip.TabIndex = 1;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_edit_30;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(50, 18, 50, 0);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(148, 41);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_close_30;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(138, 41);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveInfoToolStripMenuItem
            // 
            this.saveInfoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveInfoToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_save_30;
            this.saveInfoToolStripMenuItem.Name = "saveInfoToolStripMenuItem";
            this.saveInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.saveInfoToolStripMenuItem.Size = new System.Drawing.Size(192, 41);
            this.saveInfoToolStripMenuItem.Text = "Save Cargo Info";
            // 
            // trackCargoToolStripMenuItem
            // 
            this.trackCargoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.trackCargoToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_tracking_50__1_;
            this.trackCargoToolStripMenuItem.Name = "trackCargoToolStripMenuItem";
            this.trackCargoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.trackCargoToolStripMenuItem.Size = new System.Drawing.Size(172, 41);
            this.trackCargoToolStripMenuItem.Text = "Track Cargo";
            // 
            // updateCargoInfoToolStripMenuItem
            // 
            this.updateCargoInfoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateCargoInfoToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delivery_tracking_30;
            this.updateCargoInfoToolStripMenuItem.Name = "updateCargoInfoToolStripMenuItem";
            this.updateCargoInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.updateCargoInfoToolStripMenuItem.Size = new System.Drawing.Size(202, 41);
            this.updateCargoInfoToolStripMenuItem.Text = "Update Cargo Info";
            // 
            // lblCargoID
            // 
            this.lblCargoID.AutoSize = true;
            this.lblCargoID.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoID.ForeColor = System.Drawing.Color.Black;
            this.lblCargoID.Location = new System.Drawing.Point(346, 197);
            this.lblCargoID.Name = "lblCargoID";
            this.lblCargoID.Size = new System.Drawing.Size(66, 23);
            this.lblCargoID.TabIndex = 7;
            this.lblCargoID.Text = "Cargo Id:";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.ForeColor = System.Drawing.Color.Black;
            this.lblSenderName.Location = new System.Drawing.Point(346, 256);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(96, 23);
            this.lblSenderName.TabIndex = 8;
            this.lblSenderName.Text = "Sender Name:";
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverName.ForeColor = System.Drawing.Color.Black;
            this.lblReceiverName.Location = new System.Drawing.Point(346, 322);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(106, 23);
            this.lblReceiverName.TabIndex = 9;
            this.lblReceiverName.Text = "Receiver Name:";
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDate.ForeColor = System.Drawing.Color.Black;
            this.lblShippingDate.Location = new System.Drawing.Point(351, 451);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(101, 23);
            this.lblShippingDate.TabIndex = 10;
            this.lblShippingDate.Text = "Shipping Date:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.Black;
            this.lblDeliveryDate.Location = new System.Drawing.Point(711, 451);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(95, 23);
            this.lblDeliveryDate.TabIndex = 11;
            this.lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblCargoStatus
            // 
            this.lblCargoStatus.AutoSize = true;
            this.lblCargoStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoStatus.ForeColor = System.Drawing.Color.Black;
            this.lblCargoStatus.Location = new System.Drawing.Point(12, 572);
            this.lblCargoStatus.Name = "lblCargoStatus";
            this.lblCargoStatus.Size = new System.Drawing.Size(95, 23);
            this.lblCargoStatus.TabIndex = 12;
            this.lblCargoStatus.Text = "Cargo Status:";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.Black;
            this.lblTrackingNumber.Location = new System.Drawing.Point(702, 256);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(120, 23);
            this.lblTrackingNumber.TabIndex = 13;
            this.lblTrackingNumber.Text = "Tracking Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(12, 497);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 23);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(718, 197);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(82, 23);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight (KG):";
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensions.ForeColor = System.Drawing.Color.Black;
            this.lblDimensions.Location = new System.Drawing.Point(702, 322);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(138, 23);
            this.lblDimensions.TabIndex = 17;
            this.lblDimensions.Text = "Dimensions (Inches):";
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.AutoSize = true;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.Black;
            this.lblAdditionalInfo.Location = new System.Drawing.Point(1100, 441);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(155, 23);
            this.lblAdditionalInfo.TabIndex = 18;
            this.lblAdditionalInfo.Text = "Additional Information:";
            // 
            // lblCargoInformation
            // 
            this.lblCargoInformation.AutoSize = true;
            this.lblCargoInformation.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoInformation.Location = new System.Drawing.Point(717, 134);
            this.lblCargoInformation.Name = "lblCargoInformation";
            this.lblCargoInformation.Size = new System.Drawing.Size(139, 25);
            this.lblCargoInformation.TabIndex = 19;
            this.lblCargoInformation.Text = "Cargo Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(345, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 10);
            this.panel1.TabIndex = 20;
            // 
            // txtBxCargoId
            // 
            this.txtBxCargoId.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCargoId.Location = new System.Drawing.Point(458, 193);
            this.txtBxCargoId.Name = "txtBxCargoId";
            this.txtBxCargoId.Size = new System.Drawing.Size(218, 27);
            this.txtBxCargoId.TabIndex = 21;
            // 
            // txtBxSenderName
            // 
            this.txtBxSenderName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSenderName.Location = new System.Drawing.Point(458, 256);
            this.txtBxSenderName.Name = "txtBxSenderName";
            this.txtBxSenderName.Size = new System.Drawing.Size(218, 27);
            this.txtBxSenderName.TabIndex = 22;
            // 
            // txtBxReceiverName
            // 
            this.txtBxReceiverName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxReceiverName.Location = new System.Drawing.Point(458, 322);
            this.txtBxReceiverName.Name = "txtBxReceiverName";
            this.txtBxReceiverName.Size = new System.Drawing.Size(218, 27);
            this.txtBxReceiverName.TabIndex = 23;
            // 
            // textBxWeight
            // 
            this.textBxWeight.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxWeight.Location = new System.Drawing.Point(838, 193);
            this.textBxWeight.Name = "textBxWeight";
            this.textBxWeight.Size = new System.Drawing.Size(209, 27);
            this.textBxWeight.TabIndex = 24;
            // 
            // txtBxTrackingNumber
            // 
            this.txtBxTrackingNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTrackingNumber.Location = new System.Drawing.Point(838, 252);
            this.txtBxTrackingNumber.Name = "txtBxTrackingNumber";
            this.txtBxTrackingNumber.Size = new System.Drawing.Size(209, 27);
            this.txtBxTrackingNumber.TabIndex = 25;
            // 
            // txtBxDimensions
            // 
            this.txtBxDimensions.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDimensions.Location = new System.Drawing.Point(838, 322);
            this.txtBxDimensions.Name = "txtBxDimensions";
            this.txtBxDimensions.Size = new System.Drawing.Size(209, 27);
            this.txtBxDimensions.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Transportation Schedule";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(346, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 10);
            this.panel2.TabIndex = 21;
            // 
            // CalenderShipDate
            // 
            this.CalenderShipDate.Location = new System.Drawing.Point(458, 451);
            this.CalenderShipDate.Name = "CalenderShipDate";
            this.CalenderShipDate.TabIndex = 28;
            // 
            // CalendarDeliveryDate
            // 
            this.CalendarDeliveryDate.Location = new System.Drawing.Point(820, 451);
            this.CalendarDeliveryDate.Name = "CalendarDeliveryDate";
            this.CalendarDeliveryDate.TabIndex = 29;
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLocation.Location = new System.Drawing.Point(94, 493);
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(218, 27);
            this.txtBxLocation.TabIndex = 30;
            // 
            // DropListCargoStatus
            // 
            this.DropListCargoStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropListCargoStatus.FormattingEnabled = true;
            this.DropListCargoStatus.Items.AddRange(new object[] {
            "Delivered",
            "Out For Delivery",
            "On Hold",
            "Lost ",
            "Damaged ",
            "In Transit",
            "Cancelled ",
            "Returned"});
            this.DropListCargoStatus.Location = new System.Drawing.Point(113, 572);
            this.DropListCargoStatus.Name = "DropListCargoStatus";
            this.DropListCargoStatus.Size = new System.Drawing.Size(227, 27);
            this.DropListCargoStatus.TabIndex = 31;
            // 
            // txtBxAdditionalInfo
            // 
            this.txtBxAdditionalInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAdditionalInfo.Location = new System.Drawing.Point(1074, 472);
            this.txtBxAdditionalInfo.Multiline = true;
            this.txtBxAdditionalInfo.Name = "txtBxAdditionalInfo";
            this.txtBxAdditionalInfo.Size = new System.Drawing.Size(243, 205);
            this.txtBxAdditionalInfo.TabIndex = 32;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(1149, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 23);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description:";
            // 
            // txtBxDimension
            // 
            this.txtBxDimension.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDimension.Location = new System.Drawing.Point(1069, 202);
            this.txtBxDimension.Multiline = true;
            this.txtBxDimension.Name = "txtBxDimension";
            this.txtBxDimension.Size = new System.Drawing.Size(248, 148);
            this.txtBxDimension.TabIndex = 34;
            // 
            // LeftPBox
            // 
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(3, 0);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(309, 464);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 5;
            this.LeftPBox.TabStop = false;
            // 
            // CargoTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1361, 749);
            this.Controls.Add(this.txtBxDimension);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBxAdditionalInfo);
            this.Controls.Add(this.DropListCargoStatus);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.CalendarDeliveryDate);
            this.Controls.Add(this.CalenderShipDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxDimensions);
            this.Controls.Add(this.txtBxTrackingNumber);
            this.Controls.Add(this.textBxWeight);
            this.Controls.Add(this.txtBxReceiverName);
            this.Controls.Add(this.txtBxSenderName);
            this.Controls.Add(this.txtBxCargoId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCargoInformation);
            this.Controls.Add(this.lblAdditionalInfo);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.lblCargoStatus);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblShippingDate);
            this.Controls.Add(this.lblReceiverName);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblCargoID);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.LeftPBox);
            this.MainMenuStrip = this.CargoMenuStrip;
            this.Name = "CargoTracking";
            this.Text = "CargoTracking";
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            this.CargoMenuStrip.ResumeLayout(false);
            this.CargoMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblCargoTracking;
        private System.Windows.Forms.Label lblCargoID;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblReceiverName;
        private System.Windows.Forms.Label lblShippingDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblCargoStatus;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label lblCargoInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBxCargoId;
        private System.Windows.Forms.TextBox txtBxSenderName;
        private System.Windows.Forms.TextBox txtBxReceiverName;
        private System.Windows.Forms.TextBox textBxWeight;
        private System.Windows.Forms.TextBox txtBxTrackingNumber;
        private System.Windows.Forms.TextBox txtBxDimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar CalenderShipDate;
        private System.Windows.Forms.MonthCalendar CalendarDeliveryDate;
        private System.Windows.Forms.TextBox txtBxLocation;
        private System.Windows.Forms.ComboBox DropListCargoStatus;
        private System.Windows.Forms.TextBox txtBxAdditionalInfo;
        private System.Windows.Forms.MenuStrip CargoMenuStrip;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtBxDimension;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCargoInfoToolStripMenuItem;
    }
}