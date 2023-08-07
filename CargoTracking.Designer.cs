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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            this.DropListCargoStatus = new System.Windows.Forms.ComboBox();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.txtBxAddNotes = new System.Windows.Forms.TextBox();
            this.ShippingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.UpdateBackPanel.Location = new System.Drawing.Point(424, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1349, 142);
            this.UpdateBackPanel.TabIndex = 6;
            // 
            // lblCargoTracking
            // 
            this.lblCargoTracking.AutoSize = true;
            this.lblCargoTracking.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoTracking.ForeColor = System.Drawing.Color.White;
            this.lblCargoTracking.Location = new System.Drawing.Point(483, 75);
            this.lblCargoTracking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoTracking.Name = "lblCargoTracking";
            this.lblCargoTracking.Size = new System.Drawing.Size(258, 57);
            this.lblCargoTracking.TabIndex = 0;
            this.lblCargoTracking.Text = "Cargo Tracking";
            // 
            // CargoMenuStrip
            // 
            this.CargoMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CargoMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CargoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveInfoToolStripMenuItem});
            this.CargoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CargoMenuStrip.Name = "CargoMenuStrip";
            this.CargoMenuStrip.Padding = new System.Windows.Forms.Padding(8, 12, 0, 12);
            this.CargoMenuStrip.Size = new System.Drawing.Size(1349, 70);
            this.CargoMenuStrip.TabIndex = 1;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_close_30;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 46);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveInfoToolStripMenuItem
            // 
            this.saveInfoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveInfoToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_save_30;
            this.saveInfoToolStripMenuItem.Name = "saveInfoToolStripMenuItem";
            this.saveInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(40, 18, 40, 0);
            this.saveInfoToolStripMenuItem.Size = new System.Drawing.Size(222, 46);
            this.saveInfoToolStripMenuItem.Text = "Save Cargo Info";
            this.saveInfoToolStripMenuItem.Click += new System.EventHandler(this.saveInfoToolStripMenuItem_Click);
            // 
            // lblCargoID
            // 
            this.lblCargoID.AutoSize = true;
            this.lblCargoID.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoID.ForeColor = System.Drawing.Color.Black;
            this.lblCargoID.Location = new System.Drawing.Point(461, 242);
            this.lblCargoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoID.Name = "lblCargoID";
            this.lblCargoID.Size = new System.Drawing.Size(84, 29);
            this.lblCargoID.TabIndex = 7;
            this.lblCargoID.Text = "Cargo Id:";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.ForeColor = System.Drawing.Color.Black;
            this.lblSenderName.Location = new System.Drawing.Point(461, 315);
            this.lblSenderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(123, 29);
            this.lblSenderName.TabIndex = 8;
            this.lblSenderName.Text = "Sender Name:";
            // 
            // lblReceiverName
            // 
            this.lblReceiverName.AutoSize = true;
            this.lblReceiverName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverName.ForeColor = System.Drawing.Color.Black;
            this.lblReceiverName.Location = new System.Drawing.Point(461, 396);
            this.lblReceiverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverName.Name = "lblReceiverName";
            this.lblReceiverName.Size = new System.Drawing.Size(136, 29);
            this.lblReceiverName.TabIndex = 9;
            this.lblReceiverName.Text = "Receiver Name:";
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDate.ForeColor = System.Drawing.Color.Black;
            this.lblShippingDate.Location = new System.Drawing.Point(449, 555);
            this.lblShippingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(127, 29);
            this.lblShippingDate.TabIndex = 10;
            this.lblShippingDate.Text = "Shipping Date:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.Black;
            this.lblDeliveryDate.Location = new System.Drawing.Point(924, 559);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(122, 29);
            this.lblDeliveryDate.TabIndex = 11;
            this.lblDeliveryDate.Text = "Delivery Date:";
            // 
            // lblCargoStatus
            // 
            this.lblCargoStatus.AutoSize = true;
            this.lblCargoStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoStatus.ForeColor = System.Drawing.Color.Black;
            this.lblCargoStatus.Location = new System.Drawing.Point(13, 682);
            this.lblCargoStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoStatus.Name = "lblCargoStatus";
            this.lblCargoStatus.Size = new System.Drawing.Size(120, 29);
            this.lblCargoStatus.TabIndex = 12;
            this.lblCargoStatus.Text = "Cargo Status:";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.Black;
            this.lblTrackingNumber.Location = new System.Drawing.Point(936, 315);
            this.lblTrackingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(152, 29);
            this.lblTrackingNumber.TabIndex = 13;
            this.lblTrackingNumber.Text = "Tracking Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(16, 612);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(84, 29);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(957, 242);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(105, 29);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight (KG):";
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensions.ForeColor = System.Drawing.Color.Black;
            this.lblDimensions.Location = new System.Drawing.Point(936, 396);
            this.lblDimensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(175, 29);
            this.lblDimensions.TabIndex = 17;
            this.lblDimensions.Text = "Dimensions (Inches):";
            // 
            // lblCargoInformation
            // 
            this.lblCargoInformation.AutoSize = true;
            this.lblCargoInformation.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoInformation.Location = new System.Drawing.Point(956, 165);
            this.lblCargoInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoInformation.Name = "lblCargoInformation";
            this.lblCargoInformation.Size = new System.Drawing.Size(173, 33);
            this.lblCargoInformation.TabIndex = 19;
            this.lblCargoInformation.Text = "Cargo Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(460, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 10);
            this.panel1.TabIndex = 20;
            // 
            // txtBxCargoId
            // 
            this.txtBxCargoId.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCargoId.Location = new System.Drawing.Point(611, 238);
            this.txtBxCargoId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxCargoId.Name = "txtBxCargoId";
            this.txtBxCargoId.Size = new System.Drawing.Size(289, 32);
            this.txtBxCargoId.TabIndex = 21;
            // 
            // txtBxSenderName
            // 
            this.txtBxSenderName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSenderName.Location = new System.Drawing.Point(611, 315);
            this.txtBxSenderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSenderName.Name = "txtBxSenderName";
            this.txtBxSenderName.Size = new System.Drawing.Size(289, 32);
            this.txtBxSenderName.TabIndex = 22;
            // 
            // txtBxReceiverName
            // 
            this.txtBxReceiverName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxReceiverName.Location = new System.Drawing.Point(611, 396);
            this.txtBxReceiverName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxReceiverName.Name = "txtBxReceiverName";
            this.txtBxReceiverName.Size = new System.Drawing.Size(289, 32);
            this.txtBxReceiverName.TabIndex = 23;
            // 
            // textBxWeight
            // 
            this.textBxWeight.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxWeight.Location = new System.Drawing.Point(1117, 238);
            this.textBxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBxWeight.Name = "textBxWeight";
            this.textBxWeight.Size = new System.Drawing.Size(267, 32);
            this.textBxWeight.TabIndex = 24;
            // 
            // txtBxTrackingNumber
            // 
            this.txtBxTrackingNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTrackingNumber.Location = new System.Drawing.Point(1117, 310);
            this.txtBxTrackingNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxTrackingNumber.Name = "txtBxTrackingNumber";
            this.txtBxTrackingNumber.Size = new System.Drawing.Size(267, 32);
            this.txtBxTrackingNumber.TabIndex = 25;
            // 
            // txtBxDimensions
            // 
            this.txtBxDimensions.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDimensions.Location = new System.Drawing.Point(1117, 396);
            this.txtBxDimensions.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxDimensions.Name = "txtBxDimensions";
            this.txtBxDimensions.Size = new System.Drawing.Size(267, 32);
            this.txtBxDimensions.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(923, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Transportation Schedule";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(461, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 10);
            this.panel2.TabIndex = 21;
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLocation.Location = new System.Drawing.Point(153, 609);
            this.txtBxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(289, 32);
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
            this.DropListCargoStatus.Location = new System.Drawing.Point(153, 683);
            this.DropListCargoStatus.Margin = new System.Windows.Forms.Padding(4);
            this.DropListCargoStatus.Name = "DropListCargoStatus";
            this.DropListCargoStatus.Size = new System.Drawing.Size(301, 32);
            this.DropListCargoStatus.TabIndex = 31;
            // 
            // LeftPBox
            // 
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(4, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(412, 571);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 5;
            this.LeftPBox.TabStop = false;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNotes.Location = new System.Drawing.Point(1461, 164);
            this.lblAddNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(159, 33);
            this.lblAddNotes.TabIndex = 32;
            this.lblAddNotes.Text = "Additional Notes";
            // 
            // txtBxAddNotes
            // 
            this.txtBxAddNotes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBxAddNotes.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAddNotes.Location = new System.Drawing.Point(1442, 219);
            this.txtBxAddNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxAddNotes.Multiline = true;
            this.txtBxAddNotes.Name = "txtBxAddNotes";
            this.txtBxAddNotes.Size = new System.Drawing.Size(309, 296);
            this.txtBxAddNotes.TabIndex = 33;
            // 
            // ShippingDatePicker
            // 
            this.ShippingDatePicker.CustomFormat = "yyyy-MM-dd";
            this.ShippingDatePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShippingDatePicker.Location = new System.Drawing.Point(586, 555);
            this.ShippingDatePicker.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.ShippingDatePicker.Name = "ShippingDatePicker";
            this.ShippingDatePicker.Size = new System.Drawing.Size(292, 35);
            this.ShippingDatePicker.TabIndex = 34;
            this.ShippingDatePicker.Value = new System.DateTime(2023, 8, 6, 0, 0, 0, 0);
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.CustomFormat = "yyyy-MM-dd";
            this.DeliveryDatePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDatePicker.Location = new System.Drawing.Point(1056, 553);
            this.DeliveryDatePicker.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(292, 35);
            this.DeliveryDatePicker.TabIndex = 35;
            this.DeliveryDatePicker.Value = new System.DateTime(2023, 8, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(461, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargo Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(460, 201);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1294, 10);
            this.panel3.TabIndex = 20;
            // 
            // CargoTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1764, 751);
            this.Controls.Add(this.DeliveryDatePicker);
            this.Controls.Add(this.ShippingDatePicker);
            this.Controls.Add(this.txtBxAddNotes);
            this.Controls.Add(this.lblAddNotes);
            this.Controls.Add(this.DropListCargoStatus);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxDimensions);
            this.Controls.Add(this.txtBxTrackingNumber);
            this.Controls.Add(this.textBxWeight);
            this.Controls.Add(this.txtBxReceiverName);
            this.Controls.Add(this.txtBxSenderName);
            this.Controls.Add(this.txtBxCargoId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCargoInformation);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.lblCargoStatus);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblShippingDate);
            this.Controls.Add(this.lblReceiverName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblCargoID);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.LeftPBox);
            this.MainMenuStrip = this.CargoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargoTracking";
            this.Text = "z";
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
        private System.Windows.Forms.TextBox txtBxLocation;
        private System.Windows.Forms.ComboBox DropListCargoStatus;
        private System.Windows.Forms.MenuStrip CargoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInfoToolStripMenuItem;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox txtBxAddNotes;
        private System.Windows.Forms.DateTimePicker ShippingDatePicker;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}