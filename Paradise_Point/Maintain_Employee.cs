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


        String fName = "";
        String lName = "";
        String email = "";
        String ActivityInvolved = "";
        String IUD = "";
        int actNum = 1;
        int iEmployeeNum = 0;
        public Maintain_Employee()
        {
            InitializeComponent();
        }


        public void Insert()
        {

            SaveActNum();

            MessageBox.Show(actNum.ToString());

            conn = new SqlConnection(connString);

            conn.Open();

            string sqlNumber = "SELECT Count (*) AS RecordCount FROM EMPLOYEE";
            cmd = new SqlCommand(sqlNumber, conn);
            iEmployeeNum = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            iEmployeeNum += 1;

            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            email = txtEmail.Text;
            ActivityInvolved = cmbInvolved.Text;

            conn.Close();


            // Open the connection
            conn.Open();

            // Create an insert command
            cmd = new SqlCommand("INSERT INTO EMPLOYEE (EmployeeNum,jobTitle, firstName, lastName, email, activityInvolvedIn,isAdmin,isSecretary,ActNum,password) VALUES (@empnum,@jobTitle, @fName, @lName, @email, @ActivityInvolved,@isAdmin,@isSecretary,@ActNum,@Password)", conn);

            // Add the parameters

            cmd.Parameters.AddWithValue("@empnum", iEmployeeNum);
            cmd.Parameters.AddWithValue("@jobTitle", "Instructor");
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@ActivityInvolved", ActivityInvolved);
            cmd.Parameters.AddWithValue("@isAdmin", false);
            cmd.Parameters.AddWithValue("@isSecretary", false);
            cmd.Parameters.AddWithValue("@ActNum", actNum);
            cmd.Parameters.AddWithValue("@Password", "NONE");





            // Execute the command
            cmd.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }

        public void Update()
        {
            // Get the values from the text boxes and combo boxes
            string empNum = cmbEmpNum.Text;
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string email = txtEmail.Text;
            string activityInvolved = cmbInvolved.Text;

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create an update command
            cmd = new SqlCommand("UPDATE EMPLOYEE SET ActNum =@actnum, firstName = @fName, lastName = @lName, email = @email, ActivityInvolved = @activityInvolved WHERE EmployeeNum = @empNum", conn);

            // Add the parameters
            cmd.Parameters.AddWithValue("@empNum", empNum);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@activityInvolved", activityInvolved);
            cmd.Parameters.AddWithValue("@actnum", actNum);

            // Execute the command
            cmd.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }

        public void Delete()
        {
            // Get the selected employee number
            string empNum = cmbEmpNum.SelectedItem.ToString();

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create a delete command
            cmd = new SqlCommand("DELETE FROM EMPLOYEE WHERE EmployeeNum = @empNum", conn);

            // Add the parameter
            cmd.Parameters.AddWithValue("@empNum", empNum);

            // Execute the command
            cmd.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }

        public void SaveActNum()
        {
            // Get the selected activity involved value
            string activityInvolved = cmbInvolved.Text;

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create a select command
            cmd = new SqlCommand("SELECT ActNum FROM ACTIVITY WHERE activityName = @activityInvolved", conn);

            // Add the parameter
            cmd.Parameters.AddWithValue("@activityInvolved", activityInvolved);

            // Execute the command and get the data reader
            reader = cmd.ExecuteReader();

            // Declare a variable to store the ActNum value
            //actNum = 0;

            // Check if the data reader has rows
            if (reader.HasRows)
            {
                // Read the first row
                reader.Read();

                // Get the ActNum value
                actNum = Convert.ToInt32(reader["ActNum"]);
            }

            // Close the data reader and the connection
            reader.Close();
            conn.Close();

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            cmbInvolved.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;

            IUD = "Insert";



        }

        private void Maintain_Employee_Load(object sender, EventArgs e)
        {
            //disable
            btnCancel.Visible = false;
            btnSave.Visible = false;
            cmbInvolved.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;


            //check if connection is valid, if no error appears it's connected succesfully
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


            //load employee numbers to combobox

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create a select command
            cmd = new SqlCommand("SELECT EmployeeNum FROM EMPLOYEE", conn);

            // Execute the command and get the data reader
            reader = cmd.ExecuteReader();

            // Clear the combo box
            cmbEmpNum.Items.Clear();

            // Loop through the data reader and add items to the combo box
            while (reader.Read())
            {
                cmbEmpNum.Items.Add(reader["EmployeeNum"].ToString());
            }

            // Close the data reader and the connection
            reader.Close();
            conn.Close();



            //Insert into Activity Involved in

            // Create a connection object
            conn = new SqlConnection(connString);

            // Open the connection
            conn.Open();

            // Create a select command
            cmd = new SqlCommand("SELECT activityName FROM ACTIVITY", conn);

            // Execute the command and get the data reader
            reader = cmd.ExecuteReader();

            // Clear the combo box
            cmbInvolved.Items.Clear();

            // Loop through the data reader and add items to the combo box
            while (reader.Read())
            {
                cmbInvolved.Items.Add(reader["activityName"].ToString());
            }

            // Close the data reader and the connection
            reader.Close();
            conn.Close();






        }

        private void cmbEmpNum_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbEmpNum.SelectedIndex == -1)
            {
                //disable
                btnCancel.Visible = false;
                btnSave.Visible = false;
                cmbInvolved.Enabled = false;
                txtEmail.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;

            }
            else
            {
                // Get the selected employee number
                string empNum = cmbEmpNum.SelectedItem.ToString();

                // Create a connection object
                conn = new SqlConnection(connString);

                // Open the connection
                conn.Open();

                // Create a select command
                cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmployeeNum = @empNum", conn);

                // Add the parameter
                cmd.Parameters.AddWithValue("@empNum", empNum);

                // Execute the command and get the data reader
                reader = cmd.ExecuteReader();

                // Check if the data reader has rows
                if (reader.HasRows)
                {
                    // Read the first row
                    reader.Read();

                    // Set the text box values
                    txtFirstName.Text = reader["firstName"].ToString();
                    txtLastName.Text = reader["lastName"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    cmbInvolved.Text = reader["activityInvolvedIn"].ToString();
                }

                // Close the data reader and the connection
                reader.Close();
                conn.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;

            IUD = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";

            cmbInvolved.Text = "";
            cmbEmpNum.Text = "";
            cmbEmpNum.SelectedIndex = -1;
            cmbInvolved.SelectedIndex = -1;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";

            cmbInvolved.Text = "";
            cmbEmpNum.Text = "";
            cmbEmpNum.SelectedIndex = -1;
            cmbInvolved.SelectedIndex = -1;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;

            if (IUD == "Insert")
            {
                //SaveActNum();

                Insert();
            }
            else if (IUD == "Update")
            {
                SaveActNum();

                Update();
            }
        }

        private void cmbInvolved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
