using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class VesselScheduling : Form
    {
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
            if (txtbxvesseltype.Text == "")
            {
                txtbxvesseltype.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxvesseltype.Focus();
                return;
            }

            if (txtbxVesselName.Text == "")
            {
                txtbxVesselName.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Vessel Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxVesselName.Focus();
                return;
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
