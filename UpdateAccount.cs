using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class UpdateAccount : Form 
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }

        DBAccess ObjDbAcess = new DBAccess();
     
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string newRole = userrolebox.SelectedItem.ToString();
            string newUsername = txtBxUsernameUpd.Text;
            string newPassword = txtBxPasswordUpd.Text;
            string newConPassword = txtBxConfirmPassword.Text;
            string newEmail =txtBxEmailUpd.Text;

            string Userid = txtBxUserIdUpd.Text; 
            int newUserid = Int32.Parse(Userid);



            if(newRole.Equals(""))
            {
                MessageBox.Show("Enter a user role", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userrolebox.BackColor = Color.Pink;
                return;
            }

           else if (newUsername.Equals(""))
            {
                MessageBox.Show("Enter a username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxUsernameUpd.BackColor = Color.Pink;
                return;
            }


            else if (newUserid.Equals(""))
            {
                MessageBox.Show("Enter a user Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxUserIdUpd.BackColor = Color.Pink;
                return;
            }

            else if (newPassword.Equals(""))
            {
                MessageBox.Show("Enter a user password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxPasswordUpd.BackColor = Color.Pink;
                return;
            }

            else if (newConPassword.Equals(""))
            {
                MessageBox.Show("Please enter to confirm password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxConfirmPassword.BackColor = Color.Pink;
                return;
            }

            else if (newEmail.Equals(""))
            {
                MessageBox.Show("Enter a user email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxEmailUpd.BackColor = Color.Pink;
                return;
            }


            else
            {
                
                string Query = "Update LoginInfo SET Email = '" + @newEmail + "', Username= '" + @newUsername + "', UPassword = '" + @newPassword + "', ConfirmPassword ='" + @newConPassword + "', UserRole= '" + @newRole + "' Where UserId = '" + @newUserid+ "'";
                SqlCommand UpdateQuery = new SqlCommand(Query);


                
                UpdateQuery.Parameters.AddWithValue("@UserRole",newRole);
                UpdateQuery.Parameters.AddWithValue("@Username",newUsername);
                UpdateQuery.Parameters.AddWithValue("@Email",newEmail);
                UpdateQuery.Parameters.AddWithValue("@UPassword",newPassword);
                UpdateQuery.Parameters.AddWithValue("@ConfirmPassword",newConPassword);


                int row= ObjDbAcess.executeQuery(UpdateQuery);

                if (row==1)
                {
                    MessageBox.Show("Record Updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    dataGrid1.DataSource = null;
                    UpdateAccount_Load(sender, e); // Reload the data

                }

                else
                {
                    MessageBox.Show("Record Failed to Update","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }

        }

        private void txtBxuserRole_TextChanged(object sender, EventArgs e)
        {
            userrolebox.BackColor = Color.White;
        }

        private void txtBxUserIdUpd_TextChanged(object sender, EventArgs e)
        {
            txtBxUserIdUpd.BackColor = Color.White;
        }

        private void txtBxEmailUpd_TextChanged(object sender, EventArgs e)
        {
            txtBxEmailUpd.BackColor = Color.White;
        }

        private void txtBxUsernameUpd_TextChanged(object sender, EventArgs e)
        {
            txtBxUsernameUpd.BackColor= Color.White;
        }

        private void txtBxPasswordUpd_TextChanged(object sender, EventArgs e)
        {
            txtBxPasswordUpd.BackColor= Color.White;
        }

        private void txtBxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtBxConfirmPassword.BackColor= Color.White;
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LoginInfo;";
            SqlDataAdapter adapter = new SqlDataAdapter(query,DBAccess.strConnString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid1.DataSource = dataTable;
        }

        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid1.Rows[e.RowIndex];
                userrolebox.SelectedItem= row.Cells["UserRole"].Value.ToString();
                txtBxUserIdUpd.Text = row.Cells["UserId"].Value.ToString();
                txtBxEmailUpd.Text = row.Cells["Email"].Value.ToString();
                txtBxUsernameUpd.Text = row.Cells["Username"].Value.ToString();
                txtBxPasswordUpd.Text = row.Cells["UPassword"].Value.ToString();
                txtBxConfirmPassword.Text = row.Cells["ConfirmPassword"].Value.ToString();


                // Populate other TextBoxes with respective columns from the database table.
            }
        }
    }
}
