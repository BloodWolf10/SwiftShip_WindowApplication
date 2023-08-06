namespace SwiftShip_WindowApplication
{
    partial class VesselScheduleDelete
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
            this.lblVesselId = new System.Windows.Forms.Label();
            this.txtBxVesselID = new System.Windows.Forms.TextBox();
            this.VesselDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VesselDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(585, 746);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 16;
            this.LeftPBox.TabStop = false;
            // 
            // lblVesselId
            // 
            this.lblVesselId.AutoSize = true;
            this.lblVesselId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselId.Location = new System.Drawing.Point(760, 80);
            this.lblVesselId.Name = "lblVesselId";
            this.lblVesselId.Size = new System.Drawing.Size(87, 29);
            this.lblVesselId.TabIndex = 31;
            this.lblVesselId.Text = "Vessel Id:";
            // 
            // txtBxVesselID
            // 
            this.txtBxVesselID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVesselID.Location = new System.Drawing.Point(893, 80);
            this.txtBxVesselID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxVesselID.Name = "txtBxVesselID";
            this.txtBxVesselID.ReadOnly = true;
            this.txtBxVesselID.Size = new System.Drawing.Size(296, 35);
            this.txtBxVesselID.TabIndex = 32;
            // 
            // VesselDataGrid
            // 
            this.VesselDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VesselDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VesselDataGrid.Location = new System.Drawing.Point(634, 145);
            this.VesselDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VesselDataGrid.Name = "VesselDataGrid";
            this.VesselDataGrid.RowHeadersWidth = 62;
            this.VesselDataGrid.RowTemplate.Height = 28;
            this.VesselDataGrid.Size = new System.Drawing.Size(713, 399);
            this.VesselDataGrid.TabIndex = 33;
            this.VesselDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VesselDataGrid_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(732, 625);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 52);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(1134, 625);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 52);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VesselScheduleDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 746);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.VesselDataGrid);
            this.Controls.Add(this.txtBxVesselID);
            this.Controls.Add(this.lblVesselId);
            this.Controls.Add(this.LeftPBox);
            this.Name = "VesselScheduleDelete";
            this.Text = "VesselScheduleDelete";
            this.Load += new System.EventHandler(this.VesselScheduleDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VesselDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label lblVesselId;
        private System.Windows.Forms.TextBox txtBxVesselID;
        private System.Windows.Forms.DataGridView VesselDataGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}