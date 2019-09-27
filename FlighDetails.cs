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
    public partial class FlighDetails : Form
    {
        public FlighDetails()
        {
            InitializeComponent();
        }

        private void FlighDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightdDataSet1.flightd' table. You can move, or remove it, as needed.
            this.flightdTableAdapter.Fill(this.flightdDataSet1.flightd);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM flightd";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from flightd;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO flightd(source,destination,airlines,departure,arrival,halt_station,halt_time) VALUES('"+comboBox1.Text +"','"+comboBox2.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from flightd;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Flight Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "--Select--";
                    comboBox2.Text = "--Select--";
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
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select source,destination,airlines,departure,arrival,halt_station,halt_time from flightd where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        comboBox1.Text = dr.GetValue(0).ToString();
                        comboBox2.Text = dr.GetValue(1).ToString();
                        textBox2.Text = dr.GetValue(2).ToString();
                        textBox3.Text = dr.GetValue(3).ToString();
                        textBox4.Text = dr.GetValue(4).ToString();
                        textBox5.Text = dr.GetValue(5).ToString();
                        textBox6.Text = dr.GetValue(6).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Flight Details Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AirportNetworkFlightScheduleCSharp\AirportNetworkFlightScheduleCSharp\flightd.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = " Update flightd set source='"+ comboBox1.Text +"',destination='"+ comboBox2.Text +"',airlines='" + textBox2.Text + "',departure='" + textBox3.Text + "',arrival='" + textBox4.Text + "',halt_station='" + textBox5.Text + "',halt_time='" + textBox6.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from flightd;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "--Select--";
                    comboBox2.Text = "--Select--";
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
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
    }
}
