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
    public partial class CargoDataView : Form
    {
        public CargoDataView()
        {
            InitializeComponent();
        }

        DBAccess ObjdBAccess = new DBAccess();
        SqlConnection connection = new SqlConnection(DBAccess.strConnString);

        private void updateCargoInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Variables

           
           


            string CargoId = txtBxCargoId.Text;
            string CargoWeight = textBxWeight.Text;
            string SenderName = txtBxSenderName.Text;
            int TrackingNumber = Int32.Parse(txtBxTrackingNumber.Text);
            string ReceiverName = txtBxReceiverName.Text;
            string Dimensions = txtBxDimensions.Text;
            string CargoLocation = txtBxLocation.Text;
            string CargoStatus = DropListCargoStatus.SelectedItem.ToString();
            DateTime ShippingDate = ShippingDatePicker.Value;
            DateTime DeliveryDate = DeliveryDatePicker.Value;
            string Notes = txtBxAddNotes.Text;


            if (txtBxCargoId.Text == "")
            {
                txtBxCargoId.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxCargoId.Focus();
                return;
            }

            else if (textBxWeight.Text == "")
            {
                textBxWeight.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBxWeight.Focus();
                return;
            }

            else
            {
                string Query = "Update CargoTracking SET CargoWeight = '" + @CargoWeight + "', SenderName = '" + @SenderName + "', TrackingNumber = '" + @TrackingNumber + "', ReceiverName = '" + @ReceiverName + "', Dimensions = '" + @Dimensions + "', CargoLocation = '" + @CargoLocation + "', CargoStatus = '" + @CargoStatus + "', ShippingDate = '" + @ShippingDate + "', DeliveryDate = '" + @DeliveryDate + "', Notes = '" + @Notes + "' Where CargoId = '" + @CargoId + "'";

                //string Query = "Update CargoTracking SET CargoWeight= '" + @CargoWeight + "', SenderName = '" + @SenderName + "', TrackingNumber= '" + @TrackingNumber + "', ReceiverName = '" + @ReceiverName + "', Dimensions = '" + @Dimensions + "',CargoLocation= '"+ @CargoLocation+"',CargoStatus= '"+@CargoStatus +"',ShippingDate = '" +@ShippingDate+ "',DeliveryDate= " +@DeliveryDate + "',Notes =" + @Notes+ "' Where CargoId = '" + @CargoId + "'";

                SqlCommand UpdateQuery = new SqlCommand(Query);


               
                UpdateQuery.Parameters.AddWithValue("@CargoWeight", CargoWeight);
                UpdateQuery.Parameters.AddWithValue("@SenderName", SenderName);
                UpdateQuery.Parameters.AddWithValue("@TrackingNumber", TrackingNumber);
                UpdateQuery.Parameters.AddWithValue("@ReceiverName", ReceiverName);
                UpdateQuery.Parameters.AddWithValue("@Dimensions", Dimensions);
                UpdateQuery.Parameters.AddWithValue("@CargoLocation", CargoLocation);
                UpdateQuery.Parameters.AddWithValue("@CargoStatus", CargoStatus);
                UpdateQuery.Parameters.AddWithValue("@ShippingDate", ShippingDate);
                UpdateQuery.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                UpdateQuery.Parameters.AddWithValue("@Notes", Notes);

                int row = ObjdBAccess.executeQuery(UpdateQuery);

                if (row == 1)
                {
                    MessageBox.Show("Cargo Tracking Info Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxCargoId.Clear();
                    txtBxAddNotes.Clear();
                    txtBxDimensions.Clear();
                    txtBxLocation.Clear();
                    txtBxSenderName.Clear();
                    txtBxReceiverName.Clear();
                    txtBxTrackingNumber.Clear();
                    DropListCargoStatus.SelectedIndex = -1;

                    CargoDataView_Load(sender, e); // Reload Datagrid Data
                }

                else if (row == 0)
                {
                    MessageBox.Show("Operation failed to Update");
                }

                connection.Close();
            }





        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargoTrackingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CargoTrackingDataGrid.Rows[e.RowIndex];
                txtBxCargoId.Text = row.Cells["CargoId"].Value.ToString();
                textBxWeight.Text = row.Cells["CargoWeight"].Value.ToString();
                txtBxSenderName.Text = row.Cells["SenderName"].Value.ToString();
                txtBxTrackingNumber.Text = row.Cells["TrackingNumber"].Value.ToString();
                txtBxReceiverName.Text = row.Cells["ReceiverName"].Value.ToString();
                txtBxDimensions.Text = row.Cells["Dimensions"].Value.ToString();
                txtBxLocation.Text = row.Cells["CargoLocation"].Value.ToString();
                DropListCargoStatus.Text = row.Cells["CargoStatus"].Value.ToString();
                ShippingDatePicker.Text = row.Cells["ShippingDate"].Value.ToString();
                DeliveryDatePicker.Text = row.Cells["DeliveryDate"].Value.ToString();
                txtBxAddNotes.Text = row.Cells["Notes"].Value.ToString();



                // Populate other TextBoxes with respective columns from the database table.
            }
        }

        private void CargoDataView_Load(object sender, EventArgs e)
        {
            // Code to Populate DataGrid
            string query = "SELECT * FROM CargoTracking;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            CargoTrackingDataGrid.DataSource = dataTable;
        }
    }
}
