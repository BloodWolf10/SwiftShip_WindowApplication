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

        
        
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userrolebox.SelectedIndex = -1;
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
            
            
            string email = txtBxEmail.Text;
            string Username = txtBxUsername.Text;
            string Password = txtBxPassword.Text;
            string ConPassword = txtBxConfirmPassword.Text;
            string UserRole = userrolebox.SelectedItem.ToString();


            

            if (txtBxEmail.Text == "")
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


          else  if (userrolebox.SelectedItem.ToString() == "")
            {
                txtBxConfirmPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a user role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxConfirmPassword.Focus();
                return;
            }


            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into LoginInfo( Email, Username, UPassword,ConfirmPassword, UserRole) Values(@email,@Username,@Password,@ConPassword,@UserRole)");


                
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@Username", Username);
                insertCommand.Parameters.AddWithValue("@Password", Password);
                insertCommand.Parameters.AddWithValue("@ConPassword", ConPassword);
                insertCommand.Parameters.AddWithValue("@UserRole",UserRole);

                int row = ObjdBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("User Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    txtBxConfirmPassword.Clear() ; 
                    txtBxEmail.Clear();
                   
                    txtBxPassword.Clear();
                    txtBxUsername.Clear();

                    
                    // Refresh the DataGridView to reflect the changes
                    accountsDataGrid.DataSource = null;
                    AddAccount_Load(sender, e); // Reload the data
                }

                else if (row == 0)
                {
                    MessageBox.Show("Failed to Add account");
                }


            }
            
            connection.Close();

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

        private void AddAccount_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM LoginInfo;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DBAccess.strConnString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            accountsDataGrid.DataSource = dataTable;
        }
    }
}
