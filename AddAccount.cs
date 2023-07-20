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


            /*
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into VesselSchedule(VesselType,VesselName,CargoType,DepartureDate,EstimatedTime) Values(@VesselType,@VesselName,@CargoType,@DepartureDate,@EstimatedTime)");


                insertCommand.Parameters.AddWithValue("@VesselType", VesselType);
                insertCommand.Parameters.AddWithValue("@VesselName", VesseName);
                insertCommand.Parameters.AddWithValue("@CargoType", CargoType);
                insertCommand.Parameters.AddWithValue("@DepartureDate", DepartureDate);
                insertCommand.Parameters.AddWithValue("@EstimatedTime", Estimatedtime);


                int row = ObjdBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Vessel Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxEstimatedTime.Clear();
                    txtbxVesselName.Clear();
                    txtbxvesseltype.Clear();
                    CargoTypeList.ClearSelected();

                }

                else if (row == 0)
                {
                    MessageBox.Show("Operation failed");
                }
            }
            */

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

            /*
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
