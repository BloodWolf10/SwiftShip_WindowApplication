using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
            FormLogin log =new FormLogin();
            log.ShowDialog();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            foreach (ToolStripMenuItem item in  HomeMenuStrip.Items)
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

        }

        private void vesselSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
