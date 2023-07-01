namespace SwiftShip_WindowApplication
{
    partial class Loadingscreen
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
            this.components = new System.ComponentModel.Container();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.picbxStartup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxStartup)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 6000;
            this.loadingTimer.Tick += new System.EventHandler(this.timerStartup_Tick);
            // 
            // picbxStartup
            // 
            this.picbxStartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbxStartup.Image = global::SwiftShip_WindowApplication.Properties.Resources.Container_Gif;
            this.picbxStartup.Location = new System.Drawing.Point(0, 0);
            this.picbxStartup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbxStartup.Name = "picbxStartup";
            this.picbxStartup.Size = new System.Drawing.Size(533, 292);
            this.picbxStartup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxStartup.TabIndex = 0;
            this.picbxStartup.TabStop = false;
            // 
            // Loadingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.ControlBox = false;
            this.Controls.Add(this.picbxStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loadingscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loadingscreen";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxStartup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxStartup;
        private System.Windows.Forms.Timer loadingTimer;
    }
}