using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using CefSharp.WinForms;

namespace SwiftShip_WindowApplication
{
    public partial class Home : Form
    {
       
        public Home()
        {
             
            InitializeComponent();
            
        }


        private void Home_Load(object sender, EventArgs e)
        {

            InitializeComponent();

            

          
            /*
            string googleMapsUrl = "https://www.google.com/maps/@17.9549955,-77.5848642,14z?entry=ttu";
            webBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser(googleMapsUrl);
            this.Controls.Add(webBrowser1);
            */

            /*
            string vesselFinderUrl = "https://www.vesselfinder.com/";
            webBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser(vesselFinderUrl);
            this.Controls.Add(webBrowser1);
            webBrowser1.Dock = DockStyle.Fill;
            */

            string vesselFinderUrl = "https://www.vesselfinder.com/";
            webBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser(vesselFinderUrl);

            // Set the desired location
            int x = 100; // X-coordinate
            int y = 180; // Y-coordinate
            webBrowser1.Location = new Point(x, y);

            // Add the control to the form
            this.Controls.Add(webBrowser1);


        }
    }
}
