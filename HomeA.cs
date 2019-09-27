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
    public partial class HomeA : Form
    {
        public HomeA()
        {
            InitializeComponent();
        }

        private void addFlightDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlighDetails obj = new AirportNetworkFlightScheduleCSharp.FlighDetails();
            obj.ShowDialog();
        }

        private void airportAdminInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirportAdminInfo obj1 = new AirportNetworkFlightScheduleCSharp.AirportAdminInfo();
            obj1.ShowDialog();
        }

        private void viewFlightDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFlightDetails obj2 = new AirportNetworkFlightScheduleCSharp.ViewFlightDetails();
            obj2.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj3 = new Form1();
            obj3.ShowDialog();
        }
    }
}
