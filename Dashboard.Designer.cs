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
            this.HomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.lblCatchPhrase = new System.Windows.Forms.Label();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.HomeMenuStrip.SuspendLayout();
            this.UpdateBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeMenuStrip
            // 
            this.HomeMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeMenuStrip.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.HomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.cargoTrackingToolStripMenuItem,
            this.inventoryManagementToolStripMenuItem,
            this.vesselSchedulingToolStripMenuItem,
            this.accountManagementToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.HomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuStrip.Name = "HomeMenuStrip";
            this.HomeMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeMenuStrip.ShowItemToolTips = true;
            this.HomeMenuStrip.Size = new System.Drawing.Size(213, 418);
            this.HomeMenuStrip.TabIndex = 1;
            this.HomeMenuStrip.Text = "HomeMenuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Hamburger_Icon2;
            this.menuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 12);
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(200, 56);
            this.menuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.menuToolStripMenuItem.ToolTipText = "Click to Expand / Collapse Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Home_Icon;
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.homeToolStripMenuItem.ToolTipText = "Click to Return to Home Screen";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // cargoTrackingToolStripMenuItem
            // 
            this.cargoTrackingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cargoTrackingToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cargo_Tracking_icon;
            this.cargoTrackingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargoTrackingToolStripMenuItem.Name = "cargoTrackingToolStripMenuItem";
            this.cargoTrackingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.cargoTrackingToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.cargoTrackingToolStripMenuItem.Text = "     Cargo Tracking";
            this.cargoTrackingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cargoTrackingToolStripMenuItem.ToolTipText = "Click to Open Cargo Tracker";
            this.cargoTrackingToolStripMenuItem.Click += new System.EventHandler(this.cargoTrackingToolStripMenuItem_Click);
            // 
            // inventoryManagementToolStripMenuItem
            // 
            this.inventoryManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryManagementToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Inventory_Management_icon;
            this.inventoryManagementToolStripMenuItem.Name = "inventoryManagementToolStripMenuItem";
            this.inventoryManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.inventoryManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.inventoryManagementToolStripMenuItem.Text = "  Inventory Management";
            this.inventoryManagementToolStripMenuItem.ToolTipText = "Click to open Inventory Manager";
            this.inventoryManagementToolStripMenuItem.Click += new System.EventHandler(this.inventoryManagementToolStripMenuItem_Click);
            // 
            // vesselSchedulingToolStripMenuItem
            // 
            this.vesselSchedulingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vesselSchedulingToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Vessel_Scheduling_icon;
            this.vesselSchedulingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vesselSchedulingToolStripMenuItem.Name = "vesselSchedulingToolStripMenuItem";
            this.vesselSchedulingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.vesselSchedulingToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.vesselSchedulingToolStripMenuItem.Text = "      Vessel Scheduling";
            this.vesselSchedulingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vesselSchedulingToolStripMenuItem.ToolTipText = "Click to Adjust Vessel Schedules";
            this.vesselSchedulingToolStripMenuItem.Click += new System.EventHandler(this.vesselSchedulingToolStripMenuItem_Click);
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.accountManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountManagementToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Account_Management_icon;
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.accountManagementToolStripMenuItem.Text = "    Account Management";
            this.accountManagementToolStripMenuItem.ToolTipText = "Click to Manage Accounts";
            this.accountManagementToolStripMenuItem.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addAccountToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_account_24;
            this.addAccountToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateAccountToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_update_30;
            this.updateAccountToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteAccountToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delete_30;
            this.deleteAccountToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.logout_icon1;
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(200, 52);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.logOutToolStripMenuItem.ToolTipText = "Click to Logout and return to Login Screen";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblCatchPhrase);
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateBackPanel.Location = new System.Drawing.Point(213, 0);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1036, 63);
            this.UpdateBackPanel.TabIndex = 4;
            // 
            // lblCatchPhrase
            // 
            this.lblCatchPhrase.AutoSize = true;
            this.lblCatchPhrase.Font = new System.Drawing.Font("Barber Street light_PersonalUse", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatchPhrase.ForeColor = System.Drawing.Color.White;
            this.lblCatchPhrase.Location = new System.Drawing.Point(355, 35);
            this.lblCatchPhrase.Name = "lblCatchPhrase";
            this.lblCatchPhrase.Size = new System.Drawing.Size(286, 24);
            this.lblCatchPhrase.TabIndex = 1;
            this.lblCatchPhrase.Text = "The port management system for you !!";
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(389, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(229, 35);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Welcome To ShipSwift ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 418);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.HomeMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.HomeMenuStrip;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HomeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vesselSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblCatchPhrase;
        private System.Windows.Forms.Label lblUpdateAccount;
    }
}