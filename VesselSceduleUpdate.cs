using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class VesselSceduleUpdate : Form
    {
        public VesselSceduleUpdate()
        {
            InitializeComponent();
        }

        DBAccess objDbAccess = new DBAccess();
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            



            if (txtbxvesseltype.Text == "")
            {
                txtbxvesseltype.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxvesseltype.Focus();
                return;
            }

            else if (txtbxVesselName.Text == "")
            {
                txtbxVesselName.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxVesselName.Focus();
                return;
            }

            else
            {



                string Vid = txtBxVesselID.Text;
                int VesselId = Int32.Parse(Vid);

                string newVesselType = txtbxvesseltype.Text;
                string newVesseName = txtbxVesselName.Text;
                string newCargoType = CargoTypeList.SelectedItem.ToString();
                string NewSelectedIMO = txtBxSelectedVessel.Text;
                string newItemName = txtBxitemname.Text;

                string newEstimatedtime = txtbxEstimatedTime.Text;


                DateTime newDepartureDate = DepartureDatePicker.Value.ToUniversalTime().Date;

               



                string Query = "Update VesselSchedule SET VesselName= '" + @newVesseName + "', VesselType = '" + @newVesselType + "', DepartureDate= '" + @newDepartureDate + "', CargoType = '" + @newCargoType + "', EstimatedTime = '" + @newEstimatedtime + "',SelectedIMO= '" +@NewSelectedIMO + "',ItemName= '" + newItemName+ "' Where VesselId = '" + @VesselId + "'";

                SqlCommand UpdateQuery = new SqlCommand(Query);


                UpdateQuery.Parameters.AddWithValue("@VesselName", newVesseName);
                UpdateQuery.Parameters.AddWithValue("@VesselType", newVesselType);
                UpdateQuery.Parameters.AddWithValue("@DepartureDate", newDepartureDate);
                UpdateQuery.Parameters.AddWithValue("@CargoType", newCargoType);
                UpdateQuery.Parameters.AddWithValue("@Estimatedtime", newEstimatedtime);
                UpdateQuery.Parameters.AddWithValue("@SelectedIMO", NewSelectedIMO);
                UpdateQuery.Parameters.AddWithValue("@ItemName", newItemName);

                int row = objDbAccess.executeQuery(UpdateQuery);

                if (row == 1)
                {
                    MessageBox.Show("Vessel Info Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxEstimatedTime.Clear();
                    //txtbxVesselName.Clear();
                    txtbxvesseltype.Clear();
                    //CargoTypeList.ClearSelected();
                    txtBxVesselID.Clear();
                    txtBxitemname.Clear();

                    VesselSceduleUpdate_Load(sender, e); // Reload Datagrid Data
                }

                else if (row == 0)
                {
                    MessageBox.Show("Operation failed to Update");
                }

                connection.Close();
            



                
            }



        }

        private void VesselDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VesselDataGrid.Rows[e.RowIndex];
                txtBxVesselID.Text = row.Cells["VesselId"].Value.ToString();
                txtbxvesseltype.Text = row.Cells["VesselType"].Value.ToString();
                txtbxVesselName.Text = row.Cells["VesselName"].Value.ToString();
                CargoTypeList.Text = row.Cells["CargoType"].Value.ToString();
                DepartureDatePicker.Text = row.Cells["DepartureDate"].Value.ToString();
                txtbxEstimatedTime.Text = row.Cells["EstimatedTime"].Value.ToString();
                txtBxitemname.Text = row.Cells["ItemName"].Value.ToString();


                // Populate other TextBoxes with respective columns from the database table.
            }
        }

        private void VesselSceduleUpdate_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM VesselSchedule;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            VesselDataGrid.DataSource = dataTable;
        }

        private void CargoTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CargoTypeList.SelectedItem.ToString() == "General Cargo")
            {
                txtBxSelectedVessel.Text = "9574860";
                txtbxVesselName.Text = "FINCH ARROW";
            }


            if (CargoTypeList.SelectedItem.ToString() == "Vehicles")
            {
                txtBxSelectedVessel.Text = "9684988";
                txtbxVesselName.Text = "HOEGH TRIGGER";
            }


            if (CargoTypeList.SelectedItem.ToString() == "Refrigerated Goods")
            {
                txtBxSelectedVessel.Text = "9836878";
                txtbxVesselName.Text = "COOL EXPRESS";
            }


            if (CargoTypeList.SelectedItem.ToString() == "Chemicals / Oil")
            {
                txtBxSelectedVessel.Text = "9299111";
                txtbxVesselName.Text = "ELKA APOLLON";

            }

            if (CargoTypeList.SelectedItem.ToString() == "Bulk Cargo")
            {
                txtBxSelectedVessel.Text = "9806873";
                txtbxVesselName.Text = "YUAN HE HAI";
            }
        }
    }
}
