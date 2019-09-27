using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportNetworkFlightScheduleCSharp
{
    public partial class HomeS : Form
    {
        public HomeS()
        {
            InitializeComponent();
        }

        private void addFlightDelayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightDelayDetails obj = new AirportNetworkFlightScheduleCSharp.FlightDelayDetails();
            obj.ShowDialog();
        }

        private void viewDelayFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFlightDetailsDelay obj1 = new ViewFlightDetailsDelay();
            obj1.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new AirportNetworkFlightScheduleCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
