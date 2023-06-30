namespace SwiftShip_WindowApplication
{
    partial class FormLogin
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
            this.lblHello = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pBoxAnimation = new System.Windows.Forms.PictureBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(750, 263);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(263, 61);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Ship Swift";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.Location = new System.Drawing.Point(722, 418);
            this.txtBxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(320, 40);
            this.txtBxUsername.TabIndex = 3;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.Location = new System.Drawing.Point(722, 522);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(320, 40);
            this.txtBxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(915, 606);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 65);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(736, 606);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 65);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(722, 385);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 29);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(722, 488);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 29);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(759, 338);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(234, 20);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Managing your cargo the right way !";
            // 
            // pBoxAnimation
            // 
            this.pBoxAnimation.Image = global::SwiftShip_WindowApplication.Properties.Resources.Cargo_Ship_Gif;
            this.pBoxAnimation.Location = new System.Drawing.Point(0, -3);
            this.pBoxAnimation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBoxAnimation.Name = "pBoxAnimation";
            this.pBoxAnimation.Size = new System.Drawing.Size(600, 726);
            this.pBoxAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAnimation.TabIndex = 1;
            this.pBoxAnimation.TabStop = false;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::SwiftShip_WindowApplication.Properties.Resources.Swift_Ship_Logo_P;
            this.pBoxLogo.Location = new System.Drawing.Point(764, 42);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(234, 197);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 718);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pBoxAnimation);
            this.Controls.Add(this.pBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.PictureBox pBoxAnimation;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMessage;
    }
}

