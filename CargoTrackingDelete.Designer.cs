namespace SwiftShip_WindowApplication
{
    partial class CargoTrackingDelete
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
            this.CargoDeleteView = new System.Windows.Forms.DataGridView();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblCargoTracking = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnBackDel = new System.Windows.Forms.Button();
            this.txtBxCargoId = new System.Windows.Forms.TextBox();
            this.lblVesselId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CargoDeleteView)).BeginInit();
            this.UpdateBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CargoDeleteView
            // 
            this.CargoDeleteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargoDeleteView.Location = new System.Drawing.Point(56, 298);
            this.CargoDeleteView.Name = "CargoDeleteView";
            this.CargoDeleteView.RowHeadersWidth = 51;
            this.CargoDeleteView.RowTemplate.Height = 24;
            this.CargoDeleteView.Size = new System.Drawing.Size(1215, 336);
            this.CargoDeleteView.TabIndex = 50;
            this.CargoDeleteView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CargoDeleteView_CellContentClick);
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblCargoTracking);
            this.UpdateBackPanel.Location = new System.Drawing.Point(3, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1390, 155);
            this.UpdateBackPanel.TabIndex = 51;
            // 
            // lblCargoTracking
            // 
            this.lblCargoTracking.AutoSize = true;
            this.lblCargoTracking.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoTracking.ForeColor = System.Drawing.Color.White;
            this.lblCargoTracking.Location = new System.Drawing.Point(483, 75);
            this.lblCargoTracking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargoTracking.Name = "lblCargoTracking";
            this.lblCargoTracking.Size = new System.Drawing.Size(364, 57);
            this.lblCargoTracking.TabIndex = 0;
            this.lblCargoTracking.Text = "Cargo Tracking Delete";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteRecord.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteRecord.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delete_30;
            this.btnDeleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRecord.Location = new System.Drawing.Point(1001, 666);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(240, 52);
            this.btnDeleteRecord.TabIndex = 52;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnBackDel
            // 
            this.btnBackDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackDel.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_back_arrow_32;
            this.btnBackDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackDel.Location = new System.Drawing.Point(238, 666);
            this.btnBackDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackDel.Name = "btnBackDel";
            this.btnBackDel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBackDel.Size = new System.Drawing.Size(148, 52);
            this.btnBackDel.TabIndex = 53;
            this.btnBackDel.Text = "    Back";
            this.btnBackDel.UseVisualStyleBackColor = false;
            this.btnBackDel.Click += new System.EventHandler(this.btnBackDel_Click);
            // 
            // txtBxCargoId
            // 
            this.txtBxCargoId.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCargoId.Location = new System.Drawing.Point(563, 208);
            this.txtBxCargoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxCargoId.Name = "txtBxCargoId";
            this.txtBxCargoId.ReadOnly = true;
            this.txtBxCargoId.Size = new System.Drawing.Size(428, 35);
            this.txtBxCargoId.TabIndex = 55;
            // 
            // lblVesselId
            // 
            this.lblVesselId.AutoSize = true;
            this.lblVesselId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselId.Location = new System.Drawing.Point(430, 208);
            this.lblVesselId.Name = "lblVesselId";
            this.lblVesselId.Size = new System.Drawing.Size(84, 29);
            this.lblVesselId.TabIndex = 54;
            this.lblVesselId.Text = "Cargo Id:";
            // 
            // CargoTrackingDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 771);
            this.Controls.Add(this.txtBxCargoId);
            this.Controls.Add(this.lblVesselId);
            this.Controls.Add(this.btnBackDel);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.CargoDeleteView);
            this.Name = "CargoTrackingDelete";
            this.Text = "CargoTrackingDelete";
            this.Load += new System.EventHandler(this.CargoTrackingDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CargoDeleteView)).EndInit();
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CargoDeleteView;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblCargoTracking;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnBackDel;
        private System.Windows.Forms.TextBox txtBxCargoId;
        private System.Windows.Forms.Label lblVesselId;
    }
}