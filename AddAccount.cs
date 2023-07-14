using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBxEmail.Clear();
            txtBxUsername.Clear();
            txtBxPassword.Clear();
            txtBxConfirmPassword.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtBxPassword, txtBxPassword.Text);
        }

        private void txtBxConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtBxPassword, txtBxPassword.Text);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtBxUserId.Text == "")
            {
                txtBxUserId.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUserId.Focus();
                return;
            }

            if (txtBxEmail.Text == "")
            {
                txtBxEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxEmail.Focus();
                return;
            }

            if (txtBxUsername.Text == "")
            {
                txtBxUsername.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUsername.Focus();
                return;
            }

            if (txtBxPassword.Text == "")
            {
                txtBxPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter a Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxPassword.Focus();
                return;
            }

            if (txtBxConfirmPassword.Text == "")
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please Confirm Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }

            if (txtBxConfirmPassword.Text != txtBxPassword.Text)
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Passwords Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }

        }

        private void txtBxUserId_TextChanged(object sender, EventArgs e)
        {
            txtBxUserId.BackColor = Color.White;
        }

        private void txtBxEmail_TextChanged(object sender, EventArgs e)
        {
            txtBxEmail.BackColor = Color.White;
        }

        private void txtBxUsername_TextChanged(object sender, EventArgs e)
        {
            txtBxUsername.BackColor = Color.White;
        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            txtBxPassword.BackColor = Color.White;
        }

        private void txtBxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtBxConfirmPassword.BackColor = Color.White;
        }

        private void txtBxEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtBxEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter an email address.");
                return;
            }

            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(email))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
        }
    }
}
