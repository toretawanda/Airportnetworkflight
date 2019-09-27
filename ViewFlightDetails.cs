using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirportNetworkFlightScheduleCSharp
{
    public partial class ViewFlightDetails : Form
    {
        public ViewFlightDetails()
        {
            InitializeComponent();
        }

        private void ViewFlightDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightdDataSet2.flightd' table. You can move, or remove it, as needed.
            this.flightdTableAdapter.Fill(this.flightdDataSet2.flightd);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM flightd";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
