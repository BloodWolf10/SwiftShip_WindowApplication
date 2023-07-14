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
    public partial class InventoryManagment : Form
    {
        public InventoryManagment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtbxItemname.Text == "")
            {
                txtbxItemname.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxItemname.Focus();
                return;
            }


            if (txtBxItemType.Text == "")
            {
                txtBxItemType.BackColor = Color.LightPink;
                MessageBox.Show("Please Enter Item Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxItemType.Focus();
                return;
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
    }
}
