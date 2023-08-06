using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        DBAccess ObjDBAccess = new DBAccess();

       
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void dataGridDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridDelete.Rows[e.RowIndex];
                txtBxUserIdDel.Text = row.Cells["UserID"].Value.ToString();
                


                // Populate  TextBox with respective column from the database table.
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string UserId = txtBxUserIdDel.Text;

            DialogResult dialogbox = MessageBox.Show("Are you sure you want to Delete this Account?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            if (dialogbox==DialogResult.Yes)
            {
                string query = "Delete From LoginInfo Where UserID='" + UserId + "'" ;

                SqlCommand deleteCommand = new SqlCommand(query);

               int row= ObjDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Record Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    dataGridDelete.DataSource = null;
                    DeleteAccount_Load(sender, e); // Reload the data

                }

                else
                {
                    MessageBox.Show("Record Failed to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

            }

            else if (dialogbox == DialogResult.Cancel)
            {
                // Reload Page if they donot want to delete account
                DeleteAccount_Load(sender, e);
            }

        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM LoginInfo;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DBAccess.strConnString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridDelete.DataSource = dataTable;
        }
    }
}
