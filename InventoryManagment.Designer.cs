namespace SwiftShip_WindowApplication
{
    partial class InventoryManagment
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
            this.Inventory = new System.Windows.Forms.Panel();
            this.lblInventoryManagement = new System.Windows.Forms.Label();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.lbladditem = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.txtbxItemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxItemType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSelector = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtbxLocation = new System.Windows.Forms.TextBox();
            this.Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Inventory.Controls.Add(this.lblInventoryManagement);
            this.Inventory.Location = new System.Drawing.Point(660, 0);
            this.Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(820, 110);
            this.Inventory.TabIndex = 2;
            // 
            // lblInventoryManagement
            // 
            this.lblInventoryManagement.AutoSize = true;
            this.lblInventoryManagement.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagement.ForeColor = System.Drawing.Color.White;
            this.lblInventoryManagement.Location = new System.Drawing.Point(223, 38);
            this.lblInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryManagement.Name = "lblInventoryManagement";
            this.lblInventoryManagement.Size = new System.Drawing.Size(381, 57);
            this.lblInventoryManagement.TabIndex = 0;
            this.lblInventoryManagement.Text = "Inventory Management";
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(659, 721);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 3;
            this.LeftPBox.TabStop = false;
            // 
            // lbladditem
            // 
            this.lbladditem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbladditem.AutoSize = true;
            this.lbladditem.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem.Location = new System.Drawing.Point(976, 127);
            this.lbladditem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladditem.Name = "lbladditem";
            this.lbladditem.Size = new System.Drawing.Size(117, 41);
            this.lbladditem.TabIndex = 4;
            this.lbladditem.Text = "Add Item";
            // 
            // lblitemname
            // 
            this.lblitemname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.Location = new System.Drawing.Point(760, 210);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(102, 29);
            this.lblitemname.TabIndex = 5;
            this.lblitemname.Text = "Item Name:";
            // 
            // txtbxItemname
            // 
            this.txtbxItemname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxItemname.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxItemname.Location = new System.Drawing.Point(893, 207);
            this.txtbxItemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxItemname.Name = "txtbxItemname";
            this.txtbxItemname.Size = new System.Drawing.Size(290, 35);
            this.txtbxItemname.TabIndex = 6;
            this.txtbxItemname.TextChanged += new System.EventHandler(this.txtbxItemname_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Type:";
            // 
            // txtBxItemType
            // 
            this.txtBxItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxItemType.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxItemType.Location = new System.Drawing.Point(893, 266);
            this.txtBxItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxItemType.Name = "txtBxItemType";
            this.txtBxItemType.Size = new System.Drawing.Size(290, 35);
            this.txtBxItemType.TabIndex = 6;
            this.txtBxItemType.TextChanged += new System.EventHandler(this.txtBxItemType_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // numericSelector
            // 
            this.numericSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericSelector.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSelector.Location = new System.Drawing.Point(893, 323);
            this.numericSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericSelector.Name = "numericSelector";
            this.numericSelector.Size = new System.Drawing.Size(107, 32);
            this.numericSelector.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(888, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1062, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(707, 483);
            this.InventoryDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersWidth = 62;
            this.InventoryDataGrid.RowTemplate.Height = 28;
            this.InventoryDataGrid.Size = new System.Drawing.Size(464, 211);
            this.InventoryDataGrid.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(1211, 461);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 52);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(1211, 548);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 52);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(760, 373);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(84, 29);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // txtbxLocation
            // 
            this.txtbxLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxLocation.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLocation.Location = new System.Drawing.Point(893, 370);
            this.txtbxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxLocation.Name = "txtbxLocation";
            this.txtbxLocation.Size = new System.Drawing.Size(290, 35);
            this.txtbxLocation.TabIndex = 13;
            // 
            // InventoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 721);
            this.Controls.Add(this.txtbxLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbladditem);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.InventoryDataGrid);
            this.Controls.Add(this.numericSelector);
            this.Controls.Add(this.txtBxItemType);
            this.Controls.Add(this.txtbxItemname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.LeftPBox);
            this.Controls.Add(this.Inventory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventoryManagment";
            this.Load += new System.EventHandler(this.InventoryManagment_Load);
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Inventory;
        private System.Windows.Forms.Label lblInventoryManagement;
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label lbladditem;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.TextBox txtbxItemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtbxLocation;
    }
}