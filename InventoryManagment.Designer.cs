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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblInventoryManagement = new System.Windows.Forms.Label();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.lbladditem = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.txtbxItemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxItemType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.lblInventoryManagement);
            this.TopPanel.Location = new System.Drawing.Point(742, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(922, 138);
            this.TopPanel.TabIndex = 2;
            // 
            // lblInventoryManagement
            // 
            this.lblInventoryManagement.AutoSize = true;
            this.lblInventoryManagement.Font = new System.Drawing.Font("Bahnschrift Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagement.ForeColor = System.Drawing.Color.White;
            this.lblInventoryManagement.Location = new System.Drawing.Point(251, 48);
            this.lblInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryManagement.Name = "lblInventoryManagement";
            this.lblInventoryManagement.Size = new System.Drawing.Size(454, 68);
            this.lblInventoryManagement.TabIndex = 0;
            this.lblInventoryManagement.Text = "Inventory Management";
            // 
            // LeftPBox
            // 
            this.LeftPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cool_Ship;
            this.LeftPBox.Location = new System.Drawing.Point(0, 0);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(741, 901);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 3;
            this.LeftPBox.TabStop = false;
            // 
            // lbladditem
            // 
            this.lbladditem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbladditem.AutoSize = true;
            this.lbladditem.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem.Location = new System.Drawing.Point(1098, 159);
            this.lbladditem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladditem.Name = "lbladditem";
            this.lbladditem.Size = new System.Drawing.Size(138, 48);
            this.lbladditem.TabIndex = 4;
            this.lbladditem.Text = "Add Item";
            // 
            // lblitemname
            // 
            this.lblitemname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.Location = new System.Drawing.Point(855, 262);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(118, 34);
            this.lblitemname.TabIndex = 5;
            this.lblitemname.Text = "Item Name:";
            // 
            // txtbxItemname
            // 
            this.txtbxItemname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxItemname.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxItemname.Location = new System.Drawing.Point(1005, 259);
            this.txtbxItemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxItemname.Name = "txtbxItemname";
            this.txtbxItemname.Size = new System.Drawing.Size(326, 41);
            this.txtbxItemname.TabIndex = 6;
            this.txtbxItemname.TextChanged += new System.EventHandler(this.txtbxItemname_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(855, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Type:";
            // 
            // txtBxItemType
            // 
            this.txtBxItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxItemType.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxItemType.Location = new System.Drawing.Point(1005, 332);
            this.txtBxItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxItemType.Name = "txtBxItemType";
            this.txtBxItemType.Size = new System.Drawing.Size(326, 41);
            this.txtBxItemType.TabIndex = 6;
            this.txtBxItemType.TextChanged += new System.EventHandler(this.txtBxItemType_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1005, 420);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(811, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(999, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Type";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1189, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1150, 420);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(795, 536);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(522, 331);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(1362, 576);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 65);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(1362, 685);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 65);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // InventoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 901);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbladditem);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtBxItemType);
            this.Controls.Add(this.txtbxItemname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.LeftPBox);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventoryManagment";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblInventoryManagement;
        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Label lbladditem;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.TextBox txtbxItemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
    }
}