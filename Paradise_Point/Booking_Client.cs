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

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Booking_Client()
        {
            InitializeComponent();
        }

        private void Booking_Client_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();

                //sucess loaded
                MessageBox.Show("Database connection succesful");

                conn.Close();

                conn.Open();

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

                conn.Close();

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
                    conn.Open();

                    // Insert a new booking
                    string insertQuery = "INSERT INTO BOOKCLIENT (bookIn, bookOut, ClientNum, UnitNum) " +"VALUES (@bookIn, @bookOut, @ClientNum, @UnitNum); "+"SELECT SCOPE_IDENTITY()";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, conn);

                    // Replace these placeholders with actual values
                    //insertCommand.Parameters.AddWithValue("@bookIn",);
                    //insertCommand.Parameters.AddWithValue("@bookOut",);
                    //insertCommand.Parameters.AddWithValue("@ClientNum", Convert.ToInt32(cmbID.SelectedItem));
                    //insertCommand.Parameters.AddWithValue("@UnitNum", Convert.ToInt32(());

                    // Execute the query and get the generated BookNum
                    int generatedBookNum = Convert.ToInt32(insertCommand.ExecuteScalar());

                    conn.Close();

                    // Now you have the generated BookNum for further use
                    MessageBox.Show("Booking added successfully. BookingNum: " + generatedBookNum);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }
    }
}
