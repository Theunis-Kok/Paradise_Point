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
    public partial class Booking_Client : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter1;
        SqlDataReader reader;
        DataSet ds;
        DateTime dateLeaving;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Booking_Client()
        {
            InitializeComponent();
        }

        public void pupulateUnits()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // Populate ComboBox
            string select_query2 = "SELECT UnitNum FROM UNIT";
            command = new SqlCommand(select_query2, conn);
            reader = command.ExecuteReader();

            // Clear existing items
            cmbUnitNum.Items.Clear();

            // Populate ComboBox with values from the reader
            while (reader.Read())
            {
                cmbUnitNum.Items.Add(reader["UnitNum"].ToString());
            }
            reader.Close();
            command.Dispose();
            conn.Close();

            MessageBox.Show(cmbUnitNum.Items.Count.ToString());
            if (cmbUnitNum.Items.Count > -1)
            {
                cmbUnitNum.SelectedIndex = 0;
            }
        }

        public void displayUnit()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            command.Dispose();
            reader.Close();

            // Populate ComboBox
            string select_query2 = "SELECT location FROM UNIT where UnitNum = " + cmbUnitNum.SelectedItem.ToString();
            command = new SqlCommand(select_query2, conn);
            reader = command.ExecuteReader();

          
            string sLocation = "";

            // Populate ComboBox with values from the reader
            while (reader.Read())
            {
                sLocation = reader.GetString(0);
            }

            lblUnitName.Text = sLocation;

            reader.Close();
            command.Dispose();
            conn.Close();
        }

        private void Booking_Client_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();

                //sucess loaded
                //MessageBox.Show("Database connection succesful");

                conn.Close();

                pupulateUnits();
                displayUnit();

                conn.Open();

                // Populate ComboBox
                string select_query = "SELECT ClientNum FROM CLIENT";
                command = new SqlCommand(select_query, conn);
                reader = command.ExecuteReader();

                // Clear existing items
                cmbID.Items.Clear();

                // Populate ComboBox with values from the reader
                while (reader.Read())
                {
                    cmbID.Items.Add(reader["ClientNum"].ToString());
                }

                reader.Close();
                command.Dispose();
                

                // Set the selected index to 0 (display the first value)
                if (cmbID.Items.Count > 0)
                {
                    cmbID.SelectedIndex = 0;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string show_query = "SELECT firstName, lastName, cellphone, email FROM CLIENT WHERE ClientNum = @SelectedID"; // Replace Column1, Column2, Column3, Column4, TableName
                command = new SqlCommand(show_query, conn);
                command.Parameters.AddWithValue("@SelectedID", cmbID.Text);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Populate TextBoxes with corresponding information
                    txtName.Text = reader["firstName"].ToString();
                    txtSurname.Text = reader["lastName"].ToString();
                    txtCellPhone.Text = reader["cellphone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                else
                {
                    // Clear TextBoxes if no matching record found
                    txtName.Clear();
                    txtSurname.Clear();
                    txtCellPhone.Clear();
                    txtEmail.Clear();
                }

                reader.Close();

                conn.Close();

                DateTime currentDate = DateTime.Now;
                dateLeaving = currentDate.AddDays(1);
                string sdateLeaving = dateLeaving.ToString("yyyy-MM-dd");
                lblDateLeave.Text = sdateLeaving;

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string show_query = "SELECT firstName, lastName, cellphone, email FROM CLIENT WHERE ClientNum = @SelectedID"; // Replace Column1, Column2, Column3, Column4, TableName
                command = new SqlCommand(show_query, conn);
                command.Parameters.AddWithValue("@SelectedID", cmbID.Text);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Populate TextBoxes with corresponding information
                    txtName.Text = reader["firstName"].ToString();
                    txtSurname.Text = reader["lastName"].ToString();
                    txtCellPhone.Text = reader["cellphone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                else
                {
                    // Clear TextBoxes if no matching record found
                    txtName.Clear();
                    txtSurname.Clear();
                    txtCellPhone.Clear();
                    txtEmail.Clear();
                }

                reader.Close();

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if(conn.State == ConnectionState.Closed)
                    { 
                        conn.Open();
                    }

                    /*string display = "SELECT ClientNum FROM CLIENT WHERE id = " + cmbID.SelectedItem.ToString();
                    command = new SqlCommand(display, conn);
                    reader = command.ExecuteReader();
                    

                    while(reader.Read())
                    {
                        sClientNum = reader.GetString(0);
                    }

                    reader.Close();*/
                    command.Dispose();
                    string sClientNum = cmbID.SelectedItem.ToString();

                    int iNumber = 0;
                    string sqlNumber = "SELECT MAX(BookingNum) AS RecordCount FROM BOOKINGCLIENT";
                    command = new SqlCommand(sqlNumber, conn);
                    object result = command.ExecuteScalar();
                    command.Dispose();
                    if (result != null && result != DBNull.Value)
                    {
                        iNumber = (int)result;
                    }
                    else
                    {
                        iNumber = 0;
                    }
                    iNumber++;

                    DateTime currentDate = DateTime.Now;

                    string currentDateAsString = currentDate.ToString("yyyy-MM-dd");
                    string leaveDateAsString = lblDateLeave.Text;

                    
                    // Insert a new booking
                    string insertQuery = $"INSERT INTO BOOKINGCLIENT (BookingNum, bookIn, bookOut, ClientNum, UnitNum) VALUES ("+iNumber+",'"+currentDateAsString+"','"+leaveDateAsString+"',"+sClientNum+","+cmbUnitNum.SelectedItem.ToString()+")";
                    command = new SqlCommand(insertQuery, conn);
                    adapter1 = new SqlDataAdapter();
                    adapter1.InsertCommand = command;
                    adapter1.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    conn.Close();

                    // Now you have the generated BookNum for further use
                    MessageBox.Show("Booking added successfully. BookingNum: " + iNumber);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbUnitNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //waar lable moet kom
            displayUnit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            dateLeaving = currentDate.AddDays(Convert.ToInt32(nudDays.Value));
            string sdateLeaving = dateLeaving.ToString("yyyy-MM-dd");
            lblDateLeave.Text = sdateLeaving;
        }
    }
}
