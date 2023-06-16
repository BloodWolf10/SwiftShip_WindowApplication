namespace SwiftShip_WindowApplication
{
    partial class DeleteAccount
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
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.lblUserIdDel = new System.Windows.Forms.Label();
            this.txtBxUserIdDel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnBackDel = new System.Windows.Forms.Button();
            this.LeftPBoxDel = new System.Windows.Forms.PictureBox();
            this.UpdateBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBoxDel)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBackPanel.Controls.Add(this.lblDeleteAccount);
            this.UpdateBackPanel.Location = new System.Drawing.Point(327, 2);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(460, 102);
            this.UpdateBackPanel.TabIndex = 2;
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.lblDeleteAccount.Location = new System.Drawing.Point(136, 29);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(202, 45);
            this.lblDeleteAccount.TabIndex = 0;
            this.lblDeleteAccount.Text = "Delete Account";
            // 
            // lblUserIdDel
            // 
            this.lblUserIdDel.AutoSize = true;
            this.lblUserIdDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIdDel.Location = new System.Drawing.Point(334, 119);
            this.lblUserIdDel.Name = "lblUserIdDel";
            this.lblUserIdDel.Size = new System.Drawing.Size(57, 23);
            this.lblUserIdDel.TabIndex = 14;
            this.lblUserIdDel.Text = "User Id:";
            // 
            // txtBxUserIdDel
            // 
            this.txtBxUserIdDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserIdDel.Location = new System.Drawing.Point(391, 118);
            this.txtBxUserIdDel.Name = "txtBxUserIdDel";
            this.txtBxUserIdDel.Size = new System.Drawing.Size(388, 27);
            this.txtBxUserIdDel.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(441, 238);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAccount.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delete_30;
            this.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAccount.Location = new System.Drawing.Point(593, 457);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(180, 42);
            this.btnUpdateAccount.TabIndex = 27;
            this.btnUpdateAccount.Text = "Delete Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            // 
            // btnBackDel
            // 
            this.btnBackDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackDel.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_back_arrow_32;
            this.btnBackDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackDel.Location = new System.Drawing.Point(361, 457);
            this.btnBackDel.Name = "btnBackDel";
            this.btnBackDel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBackDel.Size = new System.Drawing.Size(111, 42);
            this.btnBackDel.TabIndex = 26;
            this.btnBackDel.Text = "    Back";
            this.btnBackDel.UseVisualStyleBackColor = false;
            this.btnBackDel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeftPBoxDel
            // 
            this.LeftPBoxDel.Image = global::SwiftShip_WindowApplication.Properties.Resources.Boat2;
            this.LeftPBoxDel.Location = new System.Drawing.Point(1, 2);
            this.LeftPBoxDel.Name = "LeftPBoxDel";
            this.LeftPBoxDel.Size = new System.Drawing.Size(327, 567);
            this.LeftPBoxDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBoxDel.TabIndex = 1;
            this.LeftPBoxDel.TabStop = false;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 551);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnBackDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBxUserIdDel);
            this.Controls.Add(this.lblUserIdDel);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.LeftPBoxDel);
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBoxDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPBoxDel;
        private System.Windows.Forms.Panel UpdateBackPanel;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Label lblUserIdDel;
        private System.Windows.Forms.TextBox txtBxUserIdDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackDel;
        private System.Windows.Forms.Button btnUpdateAccount;
    }
}