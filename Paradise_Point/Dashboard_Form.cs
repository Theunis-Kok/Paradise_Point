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
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Paradise_Point
{
    public partial class Dashboard_Form : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Hide();
        }

        private void btnMaintainAct_Click(object sender, EventArgs e)
        {
            Maintain_Activities maintain_Activities = new Maintain_Activities();
            maintain_Activities.ShowDialog();
            this.Hide();
        }

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Hide();
        }

        private void btnMaintainUnit_Click_1(object sender, EventArgs e)
        {
            Maintain_Unit maintain_Unit = new Maintain_Unit();
            maintain_Unit.ShowDialog();
            this.Hide();
        }

        private void btnMaintainEmployee_Click_1(object sender, EventArgs e)
        {
            Maintain_Employee maintain_employee = new Maintain_Employee();
            maintain_employee.ShowDialog();
            this.Hide();
        }

<<<<<<< HEAD
=======
        private void btnBookAct_Click(object sender, EventArgs e)
        {
            Booking_Activity booking = new Booking_Activity();
            booking.Show();
            this.Hide();
        }
>>>>>>> 646322fb337574aff88e68126eaecf9baaa0b046

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                string query = "SELECT FirstName, LastName FROM EMPLOYEE WHERE isAdmin = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();

                            lblUserName.Text = $"Welcome, Admin {firstName} {lastName}!";
                        }
                        else
                        {
                            MessageBox.Show("No admin found.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

<<<<<<< HEAD
        private void btnAllocateStaff_Click(object sender, EventArgs e)
=======
        private void btnAllocateStaff_Click_1(object sender, EventArgs e)
>>>>>>> 646322fb337574aff88e68126eaecf9baaa0b046
        {
            Allocating_Staff allocating_Staff = new Allocating_Staff();
            allocating_Staff.ShowDialog();
            this.Hide();
<<<<<<< HEAD

        }

        private void btnReqReport_Click(object sender, EventArgs e)
        {
            Request_Report reqReport = new Request_Report();
            reqReport.ShowDialog();
            this.Close();
=======
        }

        private void btnBookClient_Click(object sender, EventArgs e)
        {
            Booking_Client booking_Client = new Booking_Client();
            booking_Client.ShowDialog();
            this.Hide();
>>>>>>> 646322fb337574aff88e68126eaecf9baaa0b046
        }
    }
}
