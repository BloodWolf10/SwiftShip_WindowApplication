namespace SwiftShip_WindowApplication
{
    partial class InventoryDelete
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
            this.txtbxItemId = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(659, 732);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 5;
            this.LeftPBox.TabStop = false;
            // 
            // txtbxItemId
            // 
            this.txtbxItemId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxItemId.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxItemId.Location = new System.Drawing.Point(922, 61);
            this.txtbxItemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxItemId.Name = "txtbxItemId";
            this.txtbxItemId.ReadOnly = true;
            this.txtbxItemId.Size = new System.Drawing.Size(290, 35);
            this.txtbxItemId.TabIndex = 31;
            // 
            // lblItemId
            // 
            this.lblItemId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.Location = new System.Drawing.Point(789, 67);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(71, 29);
            this.lblItemId.TabIndex = 30;
            this.lblItemId.Text = "Item ID:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1144, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(970, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Item Name";
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(772, 263);
            this.InventoryDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersWidth = 62;
            this.InventoryDataGrid.RowTemplate.Height = 28;
            this.InventoryDataGrid.Size = new System.Drawing.Size(512, 322);
            this.InventoryDataGrid.TabIndex = 35;
            this.InventoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(772, 633);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 52);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(1149, 633);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 52);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // InventoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 732);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.InventoryDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxItemId);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.LeftPBox);
            this.Name = "InventoryDelete";
            this.Text = "InventoryDelete";
            this.Load += new System.EventHandler(this.InventoryDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.TextBox txtbxItemId;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}