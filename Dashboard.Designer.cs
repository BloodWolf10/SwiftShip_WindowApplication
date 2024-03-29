﻿namespace SwiftShip_WindowApplication
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
            this.trackCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVesselSceduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVesselScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVesselScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateBackPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserlog = new System.Windows.Forms.Label();
            this.lblUpdateAccount = new System.Windows.Forms.Label();
            this.HomeMenuStrip.SuspendLayout();
            this.UpdateBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.HomeMenuStrip.Size = new System.Drawing.Size(255, 624);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(242, 56);
            this.menuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.menuToolStripMenuItem.ToolTipText = "Click to Expand / Collapse Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_satelite_64;
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
            this.homeToolStripMenuItem.Text = "Live Ship Tracking";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.homeToolStripMenuItem.ToolTipText = "Click to View Live Tracking";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // cargoTrackingToolStripMenuItem
            // 
            this.cargoTrackingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackCargoToolStripMenuItem,
            this.updateListToolStripMenuItem,
            this.deleteListToolStripMenuItem});
            this.cargoTrackingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cargoTrackingToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cargo_Tracking_icon;
            this.cargoTrackingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargoTrackingToolStripMenuItem.Name = "cargoTrackingToolStripMenuItem";
            this.cargoTrackingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.cargoTrackingToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
            this.cargoTrackingToolStripMenuItem.Text = "     Log Shipment";
            this.cargoTrackingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cargoTrackingToolStripMenuItem.ToolTipText = "Click to Open Cargo Tracker";
            this.cargoTrackingToolStripMenuItem.Click += new System.EventHandler(this.cargoTrackingToolStripMenuItem_Click);
            // 
            // trackCargoToolStripMenuItem
            // 
            this.trackCargoToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackCargoToolStripMenuItem.Name = "trackCargoToolStripMenuItem";
            this.trackCargoToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.trackCargoToolStripMenuItem.Text = "Create Log";
            this.trackCargoToolStripMenuItem.Click += new System.EventHandler(this.trackCargoToolStripMenuItem_Click);
            // 
            // updateListToolStripMenuItem
            // 
            this.updateListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateListToolStripMenuItem.Name = "updateListToolStripMenuItem";
            this.updateListToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.updateListToolStripMenuItem.Text = "Update Log";
            this.updateListToolStripMenuItem.Click += new System.EventHandler(this.updateListToolStripMenuItem_Click);
            // 
            // deleteListToolStripMenuItem
            // 
            this.deleteListToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteListToolStripMenuItem.Name = "deleteListToolStripMenuItem";
            this.deleteListToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.deleteListToolStripMenuItem.Text = "Delete Log";
            this.deleteListToolStripMenuItem.Click += new System.EventHandler(this.deleteListToolStripMenuItem_Click);
            // 
            // inventoryManagementToolStripMenuItem
            // 
            this.inventoryManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.updateItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.inventoryManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryManagementToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Inventory_Management_icon;
            this.inventoryManagementToolStripMenuItem.Name = "inventoryManagementToolStripMenuItem";
            this.inventoryManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.inventoryManagementToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
            this.inventoryManagementToolStripMenuItem.Text = "  Inventory Management";
            this.inventoryManagementToolStripMenuItem.ToolTipText = "Click to open Inventory Manager";
            this.inventoryManagementToolStripMenuItem.Click += new System.EventHandler(this.inventoryManagementToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.updateItemToolStripMenuItem.Text = "Update Item";
            this.updateItemToolStripMenuItem.Click += new System.EventHandler(this.updateItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // vesselSchedulingToolStripMenuItem
            // 
            this.vesselSchedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVesselSceduleToolStripMenuItem,
            this.updateVesselScheduleToolStripMenuItem,
            this.deleteVesselScheduleToolStripMenuItem});
            this.vesselSchedulingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vesselSchedulingToolStripMenuItem.Image = global::SwiftShip_WindowApplication.Properties.Resources.Vessel_Scheduling_icon;
            this.vesselSchedulingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vesselSchedulingToolStripMenuItem.Name = "vesselSchedulingToolStripMenuItem";
            this.vesselSchedulingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.vesselSchedulingToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
            this.vesselSchedulingToolStripMenuItem.Text = "      Vessel Scheduling";
            this.vesselSchedulingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vesselSchedulingToolStripMenuItem.ToolTipText = "Click to Adjust Vessel Schedules";
            this.vesselSchedulingToolStripMenuItem.Click += new System.EventHandler(this.vesselSchedulingToolStripMenuItem_Click);
            // 
            // addVesselSceduleToolStripMenuItem
            // 
            this.addVesselSceduleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addVesselSceduleToolStripMenuItem.Name = "addVesselSceduleToolStripMenuItem";
            this.addVesselSceduleToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.addVesselSceduleToolStripMenuItem.Text = "Add Vessel Schedule";
            this.addVesselSceduleToolStripMenuItem.Click += new System.EventHandler(this.addVesselSceduleToolStripMenuItem_Click);
            // 
            // updateVesselScheduleToolStripMenuItem
            // 
            this.updateVesselScheduleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updateVesselScheduleToolStripMenuItem.Name = "updateVesselScheduleToolStripMenuItem";
            this.updateVesselScheduleToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.updateVesselScheduleToolStripMenuItem.Text = "Update Vessel Schedule";
            this.updateVesselScheduleToolStripMenuItem.Click += new System.EventHandler(this.updateVesselScheduleToolStripMenuItem_Click);
            // 
            // deleteVesselScheduleToolStripMenuItem
            // 
            this.deleteVesselScheduleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteVesselScheduleToolStripMenuItem.Name = "deleteVesselScheduleToolStripMenuItem";
            this.deleteVesselScheduleToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.deleteVesselScheduleToolStripMenuItem.Text = "Delete Vessel Schedule";
            this.deleteVesselScheduleToolStripMenuItem.Click += new System.EventHandler(this.deleteVesselScheduleToolStripMenuItem_Click);
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
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
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
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
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
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
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
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(242, 52);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.logOutToolStripMenuItem.ToolTipText = "Click to Logout and return to Login Screen";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.UpdateBackPanel.Controls.Add(this.pictureBox1);
            this.UpdateBackPanel.Controls.Add(this.lblUserlog);
            this.UpdateBackPanel.Controls.Add(this.lblUpdateAccount);
            this.UpdateBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateBackPanel.Location = new System.Drawing.Point(255, 0);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(1456, 92);
            this.UpdateBackPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_administrator_male_32;
            this.pictureBox1.Location = new System.Drawing.Point(1318, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserlog
            // 
            this.lblUserlog.AutoSize = true;
            this.lblUserlog.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserlog.ForeColor = System.Drawing.Color.White;
            this.lblUserlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserlog.Location = new System.Drawing.Point(1360, 27);
            this.lblUserlog.Name = "lblUserlog";
            this.lblUserlog.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblUserlog.Size = new System.Drawing.Size(75, 38);
            this.lblUserlog.TabIndex = 2;
            this.lblUserlog.Text = "User";
            this.lblUserlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserlog.Click += new System.EventHandler(this.lblUserlog_Click);
            // 
            // lblUpdateAccount
            // 
            this.lblUpdateAccount.AutoSize = true;
            this.lblUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAccount.Location = new System.Drawing.Point(576, 27);
            this.lblUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAccount.Name = "lblUpdateAccount";
            this.lblUpdateAccount.Size = new System.Drawing.Size(340, 52);
            this.lblUpdateAccount.TabIndex = 0;
            this.lblUpdateAccount.Text = "Welcome To ShipSwift ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 624);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.HomeMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.HomeMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblUpdateAccount;
        private System.Windows.Forms.Label lblUserlog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVesselSceduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVesselScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVesselScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteListToolStripMenuItem;
    }
}