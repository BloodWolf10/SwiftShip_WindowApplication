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
    public partial class InventoryManagementUpdateForm : Form
    {
        public InventoryManagementUpdateForm()
        {
            InitializeComponent();
        }

        DBAccess objDbAccess = new DBAccess();
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);



        private void InventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InventoryDataGrid.Rows[e.RowIndex];
                txtbxItemId.Text = row.Cells["ItemId"].Value.ToString();
                txtbxItemname.Text = row.Cells["ItemName"].Value.ToString();
                txtBxItemType.Text = row.Cells["ItemType"].Value.ToString();
                txtbxLocation.Text = row.Cells["Location"].Value.ToString();
                numericSelector.Text = row.Cells["Quantity"].Value.ToString();
                


                // Populate other TextBoxes with respective columns from the database table.
            }

        }

        private void s_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM InventoryManagement;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            InventoryDataGrid.DataSource = dataTable;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            string item = txtbxItemId.Text;
            string newitemName = txtbxItemname.Text;
            string newitemType = txtBxItemType.Text;
            decimal newquantity = numericSelector.Value;
            string newLocation = txtbxLocation.Text;

            int itemID = int.Parse(item);


            if (newitemName.Equals(""))
            {
                MessageBox.Show("Enter an Item name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxItemname.BackColor = Color.Pink;
                return;

            }

            else
            {
                string Query = "Update InventoryManagement SET ItemName= '" + @newitemName + "', ItemType = '" + @newitemType + "', Quantity= '" + @newquantity+ "', Location = '" + @newLocation+ "' Where ItemId = '" + itemID + "'";

                SqlCommand UpdateQuery = new SqlCommand(Query);


                UpdateQuery.Parameters.AddWithValue("@ItemName", newitemName);
                UpdateQuery.Parameters.AddWithValue("@ItemType", newitemType);
                UpdateQuery.Parameters.AddWithValue("@Quantity", newquantity);
                UpdateQuery.Parameters.AddWithValue("@Location", newLocation);



                int row = objDbAccess.executeQuery(UpdateQuery);

                if (row == 1)
                {
                    MessageBox.Show("Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    InventoryDataGrid.DataSource = null;


                    txtbxItemId.Text = null;
                    txtbxItemname.Text = null;
                    txtBxItemType.Text = null;
                    txtbxLocation.Text = null;
                    numericSelector.Value = 0;


                    s_Load(sender, e); // Reload the data

                }

                else
                {
                    MessageBox.Show("Record Failed to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
