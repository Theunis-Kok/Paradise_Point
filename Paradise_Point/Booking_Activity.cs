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
    public partial class Booking_Activity : Form
    {
        public Booking_Activity()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ParadisePoint.mdf;Integrated Security=True";

        // Variables
        int bookingActNum = 0;
        int numPart = 0;
        int actNum = 0;
        int bookingNum = 0;
        string dateOfAct = "";
        double price = 0;

        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool ContainsNumbers(string value)
        {
            return value.Any(char.IsDigit);
        }


        private void estabConnection()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }
        
        public void populateActName()
        {
            try
            {
                //conn = new SqlConnection(connString);
                conn.Open();

                string populateAct = "SELECT DISTINCT activityName FROM ACTIVITY";
                command = new SqlCommand(populateAct, conn);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    cmbActivities.Items.Add(reader.GetValue(0));
                }

                reader.Close();
                command.Dispose();
                conn.Close();
                cmbActivities.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void insert()
        {
            try
            {
               // numPart = dudNumParticipants.SelectedIndex;

                dateOfAct = txtDate.Text + " " + txtTime.Text; 

                //conn = new SqlConnection(connString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                reader.Close();
                command.Dispose();

                string data = "SELECT ActNum, price FROM ACTIVITY WHERE activityName = '" + cmbActivities.SelectedItem.ToString() + "'";
                command = new SqlCommand(data, conn);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    actNum = reader.GetInt32(0);
                    price = Convert.ToDouble(reader.GetValue(1));
                }
                reader.Close();
                command.Dispose();
                conn.Close();

                conn.Open();

                string sqlNum = "SELECT MAX(BookingActNum) AS Count FROM BOOKINGACTIVITY";
                command = new SqlCommand(sqlNum, conn);
                object result = command.ExecuteScalar();
                command.Dispose();
                if (result != null && result != DBNull.Value)
                {
                    bookingActNum = (int)result;
                }
                else
                {
                    bookingActNum = 0;
                }
                bookingActNum += 1;
                conn.Close();

                getBookingNum();

                conn.Open();
                // Create an insert command
                command = new SqlCommand("INSERT INTO BOOKINGACTIVITY (BookingActNum, numParticipants, dateOfActivity, ActNum, BookingNum) VALUES (@bookingActNum, @numPart, @dateOfActivity, @actNum, @BookingNum)", conn);
                // Add the parameters
                command.Parameters.AddWithValue("@bookingActNum", bookingActNum);
                command.Parameters.AddWithValue("@numPart", numPart);
                command.Parameters.AddWithValue("@dateOfActivity", dateOfAct);
                command.Parameters.AddWithValue("@actNum", actNum);
                command.Parameters.AddWithValue("@BookingNum", bookingNum);

                // Execute the command
                command.ExecuteNonQuery();

                MessageBox.Show("The record was Inserted successfully! ", "Updated successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.Dispose();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void getBookingNum()
        {
            int clNum = 0;

            conn = new SqlConnection(connString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if(cmbActivities.SelectedItem != null)
            {
                string sqlClientNum = "SELECT ClientNum FROM CLIENT WHERE id = '" + cmbID.SelectedItem.ToString() + "'";
                command = new SqlCommand(sqlClientNum, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clNum = reader.GetInt32(0);
                }

                reader.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a Activity");
            }

            string sqlBookingNum = "SELECT BookingNum FROM BOOKINGCLIENT WHERE ClientNum = " + clNum + "";
            command = new SqlCommand(sqlBookingNum, conn);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                bookingNum = reader.GetInt32(0);
            }

            reader.Close();
            command.Dispose();

            conn.Close();
        }

        public void getClientIDs()
        {
            try
            {
                command.Dispose();
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlSelect = "SELECT id FROM CLIENT";
                command = new SqlCommand(sqlSelect, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string sID = reader.GetString(0);

                    cmbID.Items.Add(sID);

                }

                reader.Close();
                command.Dispose();
                conn.Close();

                cmbID.SelectedIndex = 0;
                
                


            }
            catch(SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void displayInformation()
        {
            DateTime currentDate = DateTime.Now;

            string currentDateAsString = currentDate.ToString("yyyy-MM-dd");
            txtDate.Text = currentDateAsString;

            txtTime.Text = "10:00";


            getPrice();
        }

        public void getPrice()
        {
            try
            {
                reader.Close();
                command.Dispose();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlPrice = "SELECT price FROM ACTIVITY WHERE activityName = '" + cmbActivities.SelectedItem.ToString() + "'";
                command = new SqlCommand(sqlPrice, conn);
                reader = command.ExecuteReader();

               // MessageBox.Show(sqlPrice);
                while (reader.Read())
                {
                    price = Convert.ToDouble(reader.GetValue(0));
                }

               // MessageBox.Show(price.ToString());

                price = (price * (Convert.ToInt32(nudNumPartisipants.Value)));

                lblPrice.Text =  price.ToString("c2");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public bool Errors()
        {

            bool hasError = false;

            if (cmbID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an ID ");
                hasError = true;
            }
            if (cmbActivities.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Activity ");
                hasError = true;
            }
            if (String.IsNullOrWhiteSpace(txtDate.Text))
            {
                //error provider
                errDate.SetError(txtDate, "Date is required.");
                hasError = true;
            }
            if (String.IsNullOrWhiteSpace(txtTime.Text))
            {
                //error provider
                errorTime.SetError(txtTime, "time is required.");
                hasError = true;
            }


            return hasError;

        }

        private void Booking_Activity_Load(object sender, EventArgs e)
        {
            estabConnection();
            populateActName();
            getClientIDs();
            displayInformation();
            //insert();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void cmbActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void nudNumPartisipants_ValueChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbID.SelectedIndex = 0;
            cmbActivities.SelectedIndex = 0;
            nudNumPartisipants.Value = 1;
            
            displayInformation();
            cmbID.Focus();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            if (Errors())
            {
                // An error occurred, exit early
                return;
            }
            else
            {
                insert();
                cmbID.SelectedIndex = 0;
                cmbActivities.SelectedIndex = 0;
                nudNumPartisipants.Value = 1;

                displayInformation();
                cmbID.Focus();
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDate.Text))
            {
                // Clear the error message
                errDate.SetError(txtDate, "");
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTime.Text))
            {
                // Clear the error message
                errorTime.SetError(txtTime, "");
            }
        }
    }
}
