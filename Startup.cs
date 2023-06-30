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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StartupTimer_Tick(object sender, EventArgs e)
        {
            StartupTimer.Stop();
            Hide();
            Loadingscreen load = new Loadingscreen();
            load.ShowDialog();
        }
    }
}
