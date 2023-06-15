using System;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin log = new FormLogin();
            log.ShowDialog();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {



            foreach (ToolStripMenuItem item in HomeMenuStrip.Items)
            {

                if (item != menuToolStripMenuItem)
                {
                    item.Visible = !item.Visible;

                }


            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargoTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryManagement"] == null)
            {
                // Create a new instance of Form1
                InventoryManagment inven = new InventoryManagment();

                // Setting  the MDI parent of the form
                inven.MdiParent = this;

                // Showing  the form
                inven.Show();

                // Aligning the Form in the MDI Window
                inven.Dock = DockStyle.Left;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["InventoryManagement"].Activate();
            }

        }

        private void vesselSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["AddAccount"] == null)
            {
                // Create a new instance of Form1
                AddAccount acc = new AddAccount();

                // Setting  the MDI parent of the form
                acc.MdiParent = this;

                // Showing  the form
                acc.Show();

                // Aligning the Form in the MDI Window
                acc.Dock = DockStyle.Left;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["AddAccount"].Activate();
            }
            
            
           
        }


    }
}
