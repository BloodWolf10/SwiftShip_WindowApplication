using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace SwiftShip_WindowApplication
{
    public partial class Dashboard : Form
    {

        class DashUser : LoggedPerson
        {
            public LoggedPerson loged = new LoggedPerson();
            public string UserID;

            public DashUser()
            {
                loged.LoggedName = UserID;
            }

        }

        public Dashboard()
        {
            InitializeComponent();

            DashUser dashUser = new DashUser();
            lblUserlog.Text = dashUser.UserID;
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
            lblUserlog.Text = FormLogin.userlog;

            if(FormLogin.role!="admin" )
            {
                accountManagementToolStripMenuItem.Enabled = false;
                accountManagementToolStripMenuItem.Visible= false;
            }

            else
            {
                accountManagementToolStripMenuItem.Enabled = true;
                accountManagementToolStripMenuItem.Visible= true;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Home"] == null)
            {
                // Create a new instance of Home Form
                Home home = new Home();

                // Setting  the MDI parent of the form
                home.MdiParent = this;

                // Showing  the form
                home.Show();

                // Aligning the Form in the MDI Window
                home.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["Home"].Activate();
            }

        }

        private void cargoTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Controls CargoTracking Drop Down List
        }

        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // Controls Inventory Management Drop Down List

        }

        private void vesselSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // For Vessel Schedule Drop Down list

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
                // Create a new instance of Delete Account Form
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

        private void lblUserlog_Click(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryManagement"] == null)
            {
                // Create a new instance of Inventory Management form
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

        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryManagementUpdateForm"] == null)
            {
                // Create a new instance of Inventory Management form
                InventoryManagementUpdateForm inven1 = new InventoryManagementUpdateForm();

                // Setting  the MDI parent of the form
                inven1.MdiParent = this;

                // Showing  the form
                inven1.Show();

                // Aligning the Form in the MDI Window
                inven1.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["InventoryManagementUpdateForm"].Activate();
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryDelete"] == null)
            {
                // Create a new instance of Inventory Management form
                InventoryDelete inven2 = new InventoryDelete();

                // Setting  the MDI parent of the form
                inven2.MdiParent = this;

                // Showing  the form
                inven2.Show();

                // Aligning the Form in the MDI Window
                inven2.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["InventoryDelete"].Activate();
            }
        }

        private void addVesselSceduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VesselScheduling"] == null)
            {
                // Create a new instance of Vessel Scheduling Form
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

        private void updateVesselScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VesselSceduleUpdate"] == null)
            {
                // Create a new instance of Vessel Scheduling Form
                VesselSceduleUpdate vesselupd = new VesselSceduleUpdate();

                // Setting  the MDI parent of the form
                vesselupd.MdiParent = this;

                // Showing  the form
                vesselupd.Show();

                // Aligning the Form in the MDI Window
                vesselupd.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["VesselSceduleUpdate"].Activate();
            }


        }

        private void deleteVesselScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VesselSceduleDelete"] == null)
            {
                // Create a new instance of Vessel Scheduling Form
               VesselScheduleDelete vesseldel = new VesselScheduleDelete();

                // Setting  the MDI parent of the form
                vesseldel.MdiParent = this;

                // Showing  the form
                vesseldel.Show();

                // Aligning the Form in the MDI Window
                vesseldel.Dock = DockStyle.Fill;
            }
            else
            {
                // If the form is already open, activate it
                Application.OpenForms["VesselSceduleDelete"].Activate();
            }
        }

        private void trackCargoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void updateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CargoDataView"] == null)
            {
                // Create a new instance of CargoTracking Form
                CargoDataView tracker = new CargoDataView();

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
                Application.OpenForms["CargoDataView"].Activate();
            }
        }

        private void deleteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CargoTrackingDelete"] == null)
            {
                // Create a new instance of CargoTracking Form
                CargoTrackingDelete tracker = new CargoTrackingDelete();

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
                Application.OpenForms["CargoTrackingDelete"].Activate();
            }
        }
    }
}
