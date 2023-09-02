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
    public partial class VesselScheduling : Form
    {

        DBAccess ObjdBAccess = new DBAccess();
        public VesselScheduling()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxVesselName_TextChanged(object sender, EventArgs e)
        {
            txtbxVesselName.BackColor = Color.White;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string VesselType = txtbxvesseltype.Text;
            string VesseName = txtbxVesselName.Text;
            string CargoType = CargoTypeList.SelectedItem.ToString();  
            DateTime DepartureDate = DepartureDatePicker.Value;
            string Estimatedtime = txtbxEstimatedTime.Text;
            string SelectedIMO = txtBxSelectedVessel.Text;
            string ItemName = txtBxitemname.Text;


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
                SqlCommand insertCommand = new SqlCommand("insert into VesselSchedule(VesselType,VesselName,CargoType,DepartureDate,EstimatedTime,SelectedIMO,ItemName) Values(@VesselType,@VesselName,@CargoType,@DepartureDate,@EstimatedTime,@SelectedIMO,@ItemName)");

             
                insertCommand.Parameters.AddWithValue("@VesselType", VesselType);
                insertCommand.Parameters.AddWithValue("@VesselName", VesseName);
                insertCommand.Parameters.AddWithValue("@CargoType", CargoType);
                insertCommand.Parameters.AddWithValue("@DepartureDate", DepartureDate);
                insertCommand.Parameters.AddWithValue("@EstimatedTime", Estimatedtime);
                insertCommand.Parameters.AddWithValue("@SelectedIMO", SelectedIMO);
                insertCommand.Parameters.AddWithValue("@ItemName", ItemName);


                int row = ObjdBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Vessel Added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtbxEstimatedTime.Clear();
                    //txtbxVesselName.Clear();
                    txtbxvesseltype.Clear();
                    //txtBxSelectedVessel.Clear();
                    //CargoTypeList.ClearSelected();
                    

                }

                else if(row==0)
                {
                    MessageBox.Show("Operation failed");
                }
            }

        }

        private void VesselScheduling_Load(object sender, EventArgs e)
        {

        }

        private void txtbxvesseltype_TextChanged(object sender, EventArgs e)
        {
            txtbxvesseltype.BackColor = Color.White;
        }

        private void CargoTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CargoTypeList.SelectedItem.ToString() == "General Cargo")
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

        private void txtBxSelectedVessel_MouseHover(object sender, EventArgs e)
        {
            fieldInfo.Text = "The Selected Vessel IMO can be used to search for the vessel in the LiveTracking Option from the left Navigation";
        }

        private void txtBxSelectedVessel_MouseLeave(object sender, EventArgs e)
        {
            fieldInfo = null;
        }
    }
}
