using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paradise_Point
{
    public partial class Request_Report : Form
    {

        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Request_Report()
        {
            InitializeComponent();
        }

        public void fillChart()
        {
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT A.activityName, B.numParticipants " +
                              "FROM ACTIVITY A " +
                              "JOIN BOOKINGACTIVITY B ON A.ActNum = B.ActNum", conn); 

            adapter.Fill(dt);

            chtActivities.DataSource = dt;
            conn.Close();

            chtActivities.Series[0].XValueMember = "activityName";
            chtActivities.Series[0].YValueMembers = "numParticipants";

            chtActivities.Titles.Add("Number of Participants for each Activity");
        }

        public void fillChartTopThree()
        {
            conn = new SqlConnection(connString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT TOP 3 A.activityName, B.numParticipants " +
                "FROM ACTIVITY A " +
                "JOIN BOOKINGACTIVITY B ON A.ActNum = B.ActNum " +
                "ORDER BY B.numParticipants DESC", conn);

            adapter.Fill(dt);

            chtPopularTimes.DataSource = dt;
            conn.Close();

            chtPopularTimes.Series[0].XValueMember = "activityName";
            chtPopularTimes.Series[0].YValueMembers = "numParticipants";

            chtPopularTimes.Titles.Add("Top 3 Activities with the Most Participants");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Form dashboard_Form = new Dashboard_Form();
            dashboard_Form.Show();
            this.Close();
        }

        private void Request_Report_Load(object sender, EventArgs e)
        {
            fillChart();
            fillChartTopThree();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //fillChartTopThree();
        }
    }
}
