using CefSharp.DevTools.DOM;
using LINQPad.ObjectModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SwiftShip_WindowApplication
{
    public partial class CargoTracking : Form
    {
        public CargoTracking()
        {
            InitializeComponent();
        }

        DBAccess ObjdBAccess = new DBAccess();
        

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Variables

            string CargoId = txtBxCargoId.Text;
            string CargoWeight = textBxWeight.Text;
            string SenderName  = txtBxSenderName.Text;
            int TrackingNumber = Int32.Parse(txtBxTrackingNumber.Text);
            string ReceiverName = txtBxReceiverName.Text;
            string Dimensions = txtBxDimensions.Text;
            string CargoLocation = txtBxLocation.Text;
             string CargoStatus = DropListCargoStatus.SelectedItem.ToString();
            DateTime ShippingDate = ShippingDatePicker.Value;
            DateTime DeliveryDate = DeliveryDatePicker.Value;
            string Notes = txtBxAddNotes.Text;
            string ItemName = ItemNameComboBox.SelectedItem.ToString();








            // Cargo Id Validation
            if (txtBxCargoId.Text == "")
            {
                txtBxCargoId.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Cargo ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxCargoId.Focus();
                return;
            }

            // Cargo Weight Validation
            else if(textBxWeight.Text == "")
            {
                textBxWeight.BackColor = Color.LightPink;
                MessageBox.Show ("Please Enter Weight of Cargo","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBxWeight.Focus();
                return;
            }

            // Cargo Sender Name Validation

            else if (txtBxSenderName.Text == "")
            {
                txtBxSenderName.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Sender's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxSenderName.Focus();
                return;
            }

            // Cargo Tracking Number Validation

            else if (txtBxTrackingNumber.Text == "")
            {
                txtBxTrackingNumber.BackColor= Color.LightPink;
                MessageBox.Show("Please Enter Cargo Tracking Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxTrackingNumber.Focus();
                return;
            }

            // Cargo Receiver Name Validation

            else if (txtBxReceiverName.Text == "")
            {
                txtBxReceiverName.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Receiver's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxReceiverName.Focus();
                return;
            }

            // Dimensions Validation

            else if (txtBxDimensions.Text == "")
            {
                txtBxDimensions.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Cargo's Dimensions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxDimensions.Focus();
                return;
            }

            //  Location Validation
            else if (txtBxLocation.Text == "")
            {
                textBxWeight.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Cargo's current Location path ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBxWeight.Focus();
                return;
            }

            // Cargo Status Validation

            else if (DropListCargoStatus.SelectedIndex == -1)
            {
                DropListCargoStatus.BackColor = Color.LightPink;
                MessageBox.Show("Please choose a Cargo Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBxWeight.Focus();
                return;
            }
           



            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into CargoTracking (CargoId,CargoWeight,SenderName,TrackingNumber,ReceiverName,Dimensions,CargoLocation,CargoStatus,ShippingDate,DeliveryDate,Notes,ItemName) Values(@CargoId,@CargoWeight,@SenderName,@TrackingNumber,@ReceiverName,@Dimensions,@CargoLocation,@CargoStatus,@ShippingDate,@DeliveryDate,@Notes,@ItemName)");


                insertCommand.Parameters.AddWithValue("@CargoId", CargoId);
                insertCommand.Parameters.AddWithValue("@CargoWeight", CargoWeight);
                insertCommand.Parameters.AddWithValue("@SenderName", SenderName);
                insertCommand.Parameters.AddWithValue("@TrackingNumber", TrackingNumber);
                insertCommand.Parameters.AddWithValue("@ReceiverName", ReceiverName);
                insertCommand.Parameters.AddWithValue("@Dimensions", Dimensions);
                insertCommand.Parameters.AddWithValue("@CargoLocation", CargoLocation);
                insertCommand.Parameters.AddWithValue("@CargoStatus", CargoStatus);
                insertCommand.Parameters.AddWithValue("@ShippingDate", ShippingDate);
                insertCommand.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                insertCommand.Parameters.AddWithValue("@Notes", Notes);
                insertCommand.Parameters.AddWithValue("@ItemName", ItemName);

                int row = ObjdBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Cargo Manifest Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxAddNotes.Clear();
                    txtBxCargoId.Clear();
                    txtBxDimensions.Clear();
                    txtBxLocation.Clear();
                    txtBxReceiverName.Clear();
                    txtBxSenderName.Clear();
                    txtBxTrackingNumber.Clear();
                    textBxWeight.Clear();
                    DropListCargoStatus.SelectedIndex = -1;
                    ShippingDatePicker.Value = DateTime.Now;
                    DeliveryDate = DateTime.Now;



                }

                else if (row == 0)
                {
                    MessageBox.Show("Failed to Add Cargo Data");
                }
            }
































        }

        private void CargoTracking_Load(object sender, EventArgs e)
        {
            string query = "SELECT ItemName FROM VesselSchedule";

            using (SqlConnection connection = new SqlConnection(DBAccess.strConnString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItemNameComboBox.Items.Add(reader["ItemName"].ToString()); // To Pull day from Vessel Scedule data table into combo box
                        }
                    }
                }
            }
        }
    }
}
