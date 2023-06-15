using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtBxUsername.Text;
            string password = txtBxPassword.Text;

            if (User == "Admin" && password == "@dmin1")
            {

                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show(" Incorrect Password or Username entered", "Warning", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }
    }
}
