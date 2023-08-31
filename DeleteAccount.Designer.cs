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
            this.dataGridDelete = new System.Windows.Forms.DataGridView();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnBackDel = new System.Windows.Forms.Button();
            this.LeftPBoxDel = new System.Windows.Forms.PictureBox();
            this.UpdateBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBoxDel)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBackPanel
            // 
            this.UpdateBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBackPanel.Controls.Add(this.lblDeleteAccount);
            this.UpdateBackPanel.Location = new System.Drawing.Point(445, 2);
            this.UpdateBackPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBackPanel.Name = "UpdateBackPanel";
            this.UpdateBackPanel.Size = new System.Drawing.Size(935, 126);
            this.UpdateBackPanel.TabIndex = 2;
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.lblDeleteAccount.Location = new System.Drawing.Point(359, 30);
            this.lblDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(256, 57);
            this.lblDeleteAccount.TabIndex = 0;
            this.lblDeleteAccount.Text = "Delete Account";
            // 
            // lblUserIdDel
            // 
            this.lblUserIdDel.AutoSize = true;
            this.lblUserIdDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIdDel.Location = new System.Drawing.Point(548, 169);
            this.lblUserIdDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIdDel.Name = "lblUserIdDel";
            this.lblUserIdDel.Size = new System.Drawing.Size(73, 29);
            this.lblUserIdDel.TabIndex = 14;
            this.lblUserIdDel.Text = "User Id:";
            // 
            // txtBxUserIdDel
            // 
            this.txtBxUserIdDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserIdDel.Location = new System.Drawing.Point(668, 166);
            this.txtBxUserIdDel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUserIdDel.Name = "txtBxUserIdDel";
            this.txtBxUserIdDel.Size = new System.Drawing.Size(516, 32);
            this.txtBxUserIdDel.TabIndex = 15;
            // 
            // dataGridDelete
            // 
            this.dataGridDelete.AllowUserToAddRows = false;
            this.dataGridDelete.AllowUserToDeleteRows = false;
            this.dataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDelete.Location = new System.Drawing.Point(626, 236);
            this.dataGridDelete.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDelete.Name = "dataGridDelete";
            this.dataGridDelete.ReadOnly = true;
            this.dataGridDelete.RowHeadersWidth = 62;
            this.dataGridDelete.Size = new System.Drawing.Size(588, 293);
            this.dataGridDelete.TabIndex = 16;
            this.dataGridDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDelete_CellContentClick);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAccount.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delete_30;
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAccount.Location = new System.Drawing.Point(925, 595);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(240, 52);
            this.btnDeleteAccount.TabIndex = 27;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnBackDel
            // 
            this.btnBackDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackDel.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_back_arrow_32;
            this.btnBackDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackDel.Location = new System.Drawing.Point(569, 595);
            this.btnBackDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackDel.Name = "btnBackDel";
            this.btnBackDel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBackDel.Size = new System.Drawing.Size(148, 52);
            this.btnBackDel.TabIndex = 26;
            this.btnBackDel.Text = "    Back";
            this.btnBackDel.UseVisualStyleBackColor = false;
            this.btnBackDel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeftPBoxDel
            // 
            this.LeftPBoxDel.Image = global::SwiftShip_WindowApplication.Properties.Resources.Boat2;
            this.LeftPBoxDel.Location = new System.Drawing.Point(2, 2);
            this.LeftPBoxDel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPBoxDel.Name = "LeftPBoxDel";
            this.LeftPBoxDel.Size = new System.Drawing.Size(443, 751);
            this.LeftPBoxDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBoxDel.TabIndex = 1;
            this.LeftPBoxDel.TabStop = false;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 756);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnBackDel);
            this.Controls.Add(this.dataGridDelete);
            this.Controls.Add(this.txtBxUserIdDel);
            this.Controls.Add(this.lblUserIdDel);
            this.Controls.Add(this.UpdateBackPanel);
            this.Controls.Add(this.LeftPBoxDel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            this.UpdateBackPanel.ResumeLayout(false);
            this.UpdateBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridDelete;
        private System.Windows.Forms.Button btnBackDel;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}