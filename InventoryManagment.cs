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
    public partial class InventoryManagment : Form
    {
        public InventoryManagment()
        {
            InitializeComponent();
        }

        DBAccess objDbAccess = new DBAccess();
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName = txtbxItemname.Text;
            string itemType = txtBxItemType.Text;
            decimal quantity = numericSelector.Value;
            string Location = txtbxLocation.Text;


            if (txtbxItemname.Text == "")
            {
                txtbxItemname.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxItemname.Focus();
                return;
            }


          else if (txtBxItemType.Text == "")
            {
                txtBxItemType.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Item Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxItemType.Focus();
                return;
            }

            else if(numericSelector.Value==0)
            {
                numericSelector.BackColor = Color.LightPink;
                MessageBox.Show("Quantity of an item cannot be zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into InventoryManagement(Itemtype,ItemName,Quantity,Location) Values(@itemType,@itemName,@quantity,@Location)");


                insertCommand.Parameters.AddWithValue("@itemType", itemType);
                insertCommand.Parameters.AddWithValue("@itemName", itemName);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@Location", Location);


                int row = objDbAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Item Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxItemname.Clear();
                    txtBxItemType.Clear();
                    txtbxLocation.Clear();
                    numericSelector.Value = 0;

                    InventoryDataGrid.DataSource = null;
                    InventoryManagment_Load(sender, e); // Reload the data

                    connection.Close();
                }

                else if (row == 0)
                {
                    MessageBox.Show("Operation failed");
                }
            }





        }

        private void txtbxItemname_TextChanged(object sender, EventArgs e)
        {
            txtbxItemname.BackColor = Color.White;
        }

        private void txtBxItemType_TextChanged(object sender, EventArgs e)
        {
            txtBxItemType.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryManagment_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM InventoryManagement;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            InventoryDataGrid.DataSource = dataTable;
        }
    }
}
