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
    public partial class Maintain_Employee : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;

        
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";

        String jobTitle = "";
        String fName = "";
        String lName = "";
        String email = "";
        String password = "";
        public Maintain_Employee()
        {
            InitializeComponent();
        }


        public void Insert()
        {
            jobTitle = cmbJobTitle.Text;
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create an insert command
            cmd = new SqlCommand("INSERT INTO EMPLOYEE (jobTitle, firstName, lastName, email, password) VALUES (@jobTitle, @fName, @lName, @email, @password)", conn);

            // Add the parameters
            cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            // Execute the command
            cmd.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void Maintain_Employee_Load(object sender, EventArgs e)
        {

            //check if connection is valid, if no error appears it's connected succesfully
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                conn.Close();
            }
            catch (SqlException error){
                MessageBox.Show(error.Message);
            }
        }
    }
}
