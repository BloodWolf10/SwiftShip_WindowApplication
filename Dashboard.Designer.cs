namespace SwiftShip_WindowApplication
{
    partial class Dashboard
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.cargoTrackingToolStripMenuItem,
            this.inventoryManagementToolStripMenuItem,
            this.vesselSchedulingToolStripMenuItem,
            this.accountManagementToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.MainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenuStrip.Size = new System.Drawing.Size(722, 47);
            this.MainMenuStrip.TabIndex = 0;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // cargoTrackingToolStripMenuItem
            // 
            this.cargoTrackingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cargoTrackingToolStripMenuItem.Name = "cargoTrackingToolStripMenuItem";
            this.cargoTrackingToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.cargoTrackingToolStripMenuItem.Text = "Cargo Tracking";
            // 
            // inventoryManagementToolStripMenuItem
            // 
            this.inventoryManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryManagementToolStripMenuItem.Name = "inventoryManagementToolStripMenuItem";
            this.inventoryManagementToolStripMenuItem.Size = new System.Drawing.Size(167, 27);
            this.inventoryManagementToolStripMenuItem.Text = "Inventory Management";
            // 
            // vesselSchedulingToolStripMenuItem
            // 
            this.vesselSchedulingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vesselSchedulingToolStripMenuItem.Name = "vesselSchedulingToolStripMenuItem";
            this.vesselSchedulingToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.vesselSchedulingToolStripMenuItem.Text = "Vessel Scheduling";
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.accountManagementToolStripMenuItem.Text = "Account Management";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 418);
            this.Controls.Add(this.MainMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vesselSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}