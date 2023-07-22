namespace SwiftShip_WindowApplication
{
    partial class AddAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxConfirmPassword = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBxUserId = new System.Windows.Forms.TextBox();
            this.accountsDataGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.LeftPBox = new System.Windows.Forms.PictureBox();
            this.txtBxUserRole = new System.Windows.Forms.TextBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.lblCreateAccount);
            this.TopPanel.Location = new System.Drawing.Point(424, 2);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(541, 110);
            this.TopPanel.TabIndex = 1;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(91, 32);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(295, 57);
            this.lblCreateAccount.TabIndex = 0;
            this.lblCreateAccount.Text = "Account Manager";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(425, 219);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 29);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(424, 311);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 29);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(424, 394);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPassword.Location = new System.Drawing.Point(424, 475);
            this.lblConPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(163, 29);
            this.lblConPassword.TabIndex = 5;
            this.lblConPassword.Text = "Confirm Password:";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxEmail.Location = new System.Drawing.Point(424, 251);
            this.txtBxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(530, 32);
            this.txtBxEmail.TabIndex = 6;
            this.txtBxEmail.TextChanged += new System.EventHandler(this.txtBxEmail_TextChanged);
            this.txtBxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxEmail_Validating);
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.Location = new System.Drawing.Point(424, 343);
            this.txtBxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(530, 32);
            this.txtBxUsername.TabIndex = 7;
            this.txtBxUsername.TextChanged += new System.EventHandler(this.txtBxUsername_TextChanged);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.Location = new System.Drawing.Point(424, 426);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(530, 32);
            this.txtBxPassword.TabIndex = 8;
            this.txtBxPassword.TextChanged += new System.EventHandler(this.txtBxPassword_TextChanged);
            this.txtBxPassword.MouseHover += new System.EventHandler(this.txtBxPassword_MouseHover);
            // 
            // txtBxConfirmPassword
            // 
            this.txtBxConfirmPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxConfirmPassword.Location = new System.Drawing.Point(424, 507);
            this.txtBxConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxConfirmPassword.Name = "txtBxConfirmPassword";
            this.txtBxConfirmPassword.Size = new System.Drawing.Size(530, 32);
            this.txtBxConfirmPassword.TabIndex = 9;
            this.txtBxConfirmPassword.TextChanged += new System.EventHandler(this.txtBxConfirmPassword_TextChanged);
            this.txtBxConfirmPassword.MouseHover += new System.EventHandler(this.txtBxConfirmPassword_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(894, 607);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 23);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(425, 137);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(73, 29);
            this.lblUserId.TabIndex = 13;
            this.lblUserId.Text = "User Id:";
            // 
            // txtBxUserId
            // 
            this.txtBxUserId.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserId.Location = new System.Drawing.Point(424, 169);
            this.txtBxUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxUserId.Name = "txtBxUserId";
            this.txtBxUserId.Size = new System.Drawing.Size(530, 32);
            this.txtBxUserId.TabIndex = 14;
            this.txtBxUserId.TextChanged += new System.EventHandler(this.txtBxUserId_TextChanged);
            // 
            // accountsDataGrid
            // 
            this.accountsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.accountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.accountsDataGrid.Location = new System.Drawing.Point(973, 2);
            this.accountsDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountsDataGrid.Name = "accountsDataGrid";
            this.accountsDataGrid.RowHeadersWidth = 62;
            this.accountsDataGrid.RowTemplate.Height = 30;
            this.accountsDataGrid.Size = new System.Drawing.Size(499, 668);
            this.accountsDataGrid.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_delete_button_30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(637, 644);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(148, 52);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "      Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateAccount.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_account_24;
            this.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount.Location = new System.Drawing.Point(417, 644);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(212, 52);
            this.btnCreateAccount.TabIndex = 11;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Image = global::SwiftShip_WindowApplication.Properties.Resources.icons8_back_arrow_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(793, 644);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(148, 52);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "      Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeftPBox
            // 
            this.LeftPBox.Image = global::SwiftShip_WindowApplication.Properties.Resources.Boat2;
            this.LeftPBox.Location = new System.Drawing.Point(-4, 14);
            this.LeftPBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftPBox.Name = "LeftPBox";
            this.LeftPBox.Size = new System.Drawing.Size(421, 772);
            this.LeftPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPBox.TabIndex = 0;
            this.LeftPBox.TabStop = false;
            // 
            // txtBxUserRole
            // 
            this.txtBxUserRole.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUserRole.Location = new System.Drawing.Point(425, 576);
            this.txtBxUserRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUserRole.Name = "txtBxUserRole";
            this.txtBxUserRole.Size = new System.Drawing.Size(530, 32);
            this.txtBxUserRole.TabIndex = 17;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(425, 543);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(93, 29);
            this.lblUserRole.TabIndex = 18;
            this.lblUserRole.Text = "User Role:";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 789);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.txtBxUserRole);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.accountsDataGrid);
            this.Controls.Add(this.txtBxUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBxConfirmPassword);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblConPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccount";
            this.Text = "Add Account";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConPassword;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxConfirmPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtBxUserId;
        private System.Windows.Forms.DataGridView accountsDataGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBxUserRole;
        private System.Windows.Forms.Label lblUserRole;
    }
}