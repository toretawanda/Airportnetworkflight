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
    public partial class ViewFlightDetailsDelay : Form
    {
        public ViewFlightDetailsDelay()
        {
            InitializeComponent();
        }

        private void ViewFlightDetailsDelay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightdDataSet3.flightdelay' table. You can move, or remove it, as needed.
            this.flightdelayTableAdapter.Fill(this.flightdDataSet3.flightdelay);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM flightdelay";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM flightdelay where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
