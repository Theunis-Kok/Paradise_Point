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

namespace Paradise_Point
{
    public partial class Secretary : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Secretary()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.Show();
            this.Hide();
        }

        private void Secretary_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                string query = "SELECT FirstName, LastName FROM EMPLOYEE WHERE isSecretary = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();

                            lblUserName.Text = $"Welcome, Secretary {firstName} {lastName}!";
                        }
                        else
                        {
                            MessageBox.Show("No secretary found.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnBookClient_Click(object sender, EventArgs e)
        {
            Booking_Client book_Client = new Booking_Client();
            book_Client.Show();
            this.Hide();
            
        }

        private void btnBookAct_Click(object sender, EventArgs e)
        {
            Booking_Activity booking = new Booking_Activity();
            booking.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help_Form help = new Help_Form();
            help.ShowDialog();
            this.Hide();
        }
    }
}
