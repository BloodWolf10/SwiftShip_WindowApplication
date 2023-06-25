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
            if (Application.OpenForms["CargoTracking"] == null)
            {
                // Create a new instance of CargoTracking Form
                CargoTracking tracker = new CargoTracking();

                // Setting  the MDI parent of the form
                tracker.MdiParent = this;

                // Showing  the form
                tracker.Show();

                // Aligning the Form in the MDI Window
                tracker.Dock = DockStyle.Left;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["CargoTracking"].Activate();
            }
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
                inven.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["InventoryManagement"].Activate();
            }

        }

        private void vesselSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VesselScheduling"] == null)
            {
                // Create a new instance of Form1
                VesselScheduling vessel = new VesselScheduling();

                // Setting  the MDI parent of the form
                vessel.MdiParent = this;

                // Showing  the form
                vessel.Show();

                // Aligning the Form in the MDI Window
                vessel.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["VesselScheduling"].Activate();
            }

        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Control Drop down list for Account Management options
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["AddAccount"] == null)
            {
                // Create a new instance of Add Account Form
                AddAccount acc = new AddAccount();

                // Setting  the MDI parent of the form
                acc.MdiParent = this;

                // Showing  the form
                acc.Show();

                // Aligning the Form in the MDI Window
                acc.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["AddAccount"].Activate();
            }
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UpdateAccount"] == null)
            {
                // Create a new instance of Update Account Form
                UpdateAccount Uacc = new UpdateAccount();

                // Setting  the MDI parent of the form
                Uacc.MdiParent = this;

                // Showing  the form
                Uacc.Show();

                // Aligning the Form in the MDI Window
                Uacc.Dock = DockStyle.Left;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["UpdateAccount"].Activate();
            }
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DeleteAccount"] == null)
            {
                // Create a new instance of Update Account Form
                DeleteAccount Dacc = new DeleteAccount();

                // Setting  the MDI parent of the form
                Dacc.MdiParent = this;

                // Showing  the form
                Dacc.Show();

                // Aligning the Form in the MDI Window
                Dacc.Dock = DockStyle.Left;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["DeleteAccount"].Activate();
            }
        }
    }
}
