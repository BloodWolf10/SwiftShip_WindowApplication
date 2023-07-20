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
                SqlCommand insertCommand = new SqlCommand("insert into VesselSchedule(VesselType,VesselName,CargoType,DepartureDate,EstimatedTime) Values(@VesselType,@VesselName,@CargoType,@DepartureDate,@EstimatedTime)");

             
                insertCommand.Parameters.AddWithValue("@VesselType", VesselType);
                insertCommand.Parameters.AddWithValue("@VesselName", VesseName);
                insertCommand.Parameters.AddWithValue("@CargoType", CargoType);
                insertCommand.Parameters.AddWithValue("@DepartureDate", DepartureDate);
                insertCommand.Parameters.AddWithValue("@EstimatedTime", Estimatedtime);
              

               int row = ObjdBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Vessel Added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtbxEstimatedTime.Clear();
                    txtbxVesselName.Clear();
                    txtbxvesseltype.Clear();
                    CargoTypeList.ClearSelected();
                    
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
    }
}
