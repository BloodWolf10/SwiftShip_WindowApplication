using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DBAccess ObjdBAccess = new DBAccess();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBxEmail.Clear();
            txtBxUsername.Clear();
            txtBxPassword.Clear();
            txtBxConfirmPassword.Clear();
            txtBxUserRole.Clear();
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
            
            int userId = Int32.Parse(txtBxUserId.Text);
            string email = txtBxEmail.Text;
            string Username = txtBxUsername.Text;
            string Password = txtBxPassword.Text;
            string ConPassword = txtBxConfirmPassword.Text;
            string UserRole = txtBxUserRole.Text;


            if (txtBxUserId.Text == "")
            {
                txtBxUserId.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUserId.Focus();
                return;
            }

           else if (txtBxEmail.Text == "")
            {
                txtBxEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxEmail.Focus();
                return;
            }

           else if (txtBxUsername.Text == "")
            {
                txtBxUsername.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxUsername.Focus();
                return;
            }

           else if (txtBxPassword.Text == "")
            {
                txtBxPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter a Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxPassword.Focus();
                return;
            }

           else if (txtBxConfirmPassword.Text == "")
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please Confirm Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }

           else if (txtBxConfirmPassword.Text != txtBxPassword.Text)
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Passwords Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }


          else  if (txtBxUserRole.Text == "")
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a user role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }


            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into LoginInfo(UserId, Email, Username, UPassword,ConfirmPassword, UserRole) Values(@userId,@email,@Username,@Password,@ConPassword,@UserRole)");


                insertCommand.Parameters.AddWithValue("@userId", userId);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@Username", Username);
                insertCommand.Parameters.AddWithValue("@Password", Password);
                insertCommand.Parameters.AddWithValue("@ConPassword", ConPassword);
                insertCommand.Parameters.AddWithValue("@UserRole",UserRole);

                int row = ObjdBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("User Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxUserId.Clear();
                    txtBxConfirmPassword.Clear() ; 
                    txtBxEmail.Clear();
                    txtBxUserRole.Clear();
                    txtBxPassword.Clear();
                    txtBxUsername.Clear();


                }

                else if (row == 0)
                {
                    MessageBox.Show("Failed to Add account");
                }
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
            /*
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
            */
        }
    }
}
