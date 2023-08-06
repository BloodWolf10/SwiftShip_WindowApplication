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
    public partial class InventoryDelete : Form
    {
        public InventoryDelete()
        {
            InitializeComponent();
        }

        DBAccess ObjDBAccess = new DBAccess();

        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InventoryDataGrid.Rows[e.RowIndex];
                txtbxItemId.Text = row.Cells["ItemId"].Value.ToString();
                

                // Populate other TextBoxes with respective columns from the database table.
            }
        }

        private void InventoryDelete_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM InventoryManagement;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            InventoryDataGrid.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Item = txtbxItemId.Text;
            int ItemId = int.Parse(Item);

            DialogResult dialogbox = MessageBox.Show("Are you sure you want to Delete this Item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            if (dialogbox == DialogResult.OK)
            {
                string query = "Delete From InventoryManagement Where ItemId='" + ItemId + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = ObjDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Record Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    InventoryDataGrid.DataSource = null;
                    InventoryDelete_Load(sender, e); // Reload the data

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
                InventoryDelete_Load(sender, e);
            }

        }
    }
}
