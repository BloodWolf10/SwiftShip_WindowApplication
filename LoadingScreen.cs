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
    public partial class Loadingscreen : Form
    {
        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void timerStartup_Tick(object sender, EventArgs e)
        {
           
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
            this.Hide(); // this will hide the loading screen
            FormLogin login = new FormLogin(); // creating object of the login class to show login form
            login.ShowDialog();
            this.Close();
        }
    }
}
