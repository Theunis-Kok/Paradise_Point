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
        SqlDataReader reader, reader2;
        SqlDataAdapter adapter;



        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        String fName = "";
        String lName = "";
        String email = "";
        String ActivityInvolved = "";
        String IUD = "";
        int actNum = 0;
        int iEmployeeNum = 0;
        public Maintain_Employee()
        {
            InitializeComponent();
        }

        public void SaveActNum()
        {
            // Get the selected activity involved value
            string activityInvolved = cmbInvolved.Text;

            conn = new SqlConnection(connString);

            conn.Open();

            cmd = new SqlCommand("SELECT ActNum FROM ACTIVITY WHERE activityName = @activityInvolved", conn);

            cmd.Parameters.AddWithValue("@activityInvolved", activityInvolved);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                actNum = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();

        }

        public void CountEmployeeNum()
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();

                string sqlNumber = "SELECT MAX(EmployeeNum) AS Count FROM EMPLOYEE";
                cmd = new SqlCommand(sqlNumber, conn);
                iEmployeeNum = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                iEmployeeNum += 1;

                fName = txtFirstName.Text;
                lName = txtLastName.Text;
                email = txtEmail.Text;
                ActivityInvolved = cmbInvolved.Text;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.ToString());
            }
        }
        public void Insert()
        {
            SaveActNum();
            CountEmployeeNum();

            try
            {
                conn.Open();


                cmd = new SqlCommand("INSERT INTO EMPLOYEE (EmployeeNum,jobTitle, firstName, lastName, email, activityInvolvedIn,isAdmin,isSecretary,ActNum,password) VALUES (@empnum,@jobTitle, @fName, @lName, @email, @ActivityInvolved,@isAdmin,@isSecretary,@ActNum,@Password)", conn);

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

                cmd.ExecuteNonQuery();

                MessageBox.Show("The record was inserted sucessfully!");

                populateEmployeeNum();
                populateActivity();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.ToString());
            }
        }

        public void Update()
        { 
            try
            {
                // Get the values from the text boxes and combo boxes
                string empNum = cmbEmpNum.Text;
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                string email = txtEmail.Text;
                string activityInvolved = cmbInvolved.Text;


                // Create a connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // Open the connection
                    conn.Open();

                    // Create an update command
                    using (SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEE SET ActNum = @actnum, firstName = @fName, lastName = @lName, email = @email, activityInvolvedIn = @activityInvolved WHERE EmployeeNum = @empNum", conn))
                    {
                        // Add the parameters
                        cmd.Parameters.AddWithValue("@empNum", empNum);
                        cmd.Parameters.AddWithValue("@fName", fName);
                        cmd.Parameters.AddWithValue("@lName", lName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@activityInvolved", activityInvolved);
                        cmd.Parameters.AddWithValue("@actnum", actNum);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("The record was updated successfully!" + lName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }
        }


        public void Delete()
        {
            

            conn = new SqlConnection(connString);


            conn.Open();

            cmd = new SqlCommand("DELETE FROM EMPLOYEE WHERE EmployeeNum = @empNum", conn);
            cmd.Parameters.AddWithValue("@empNum", cmbEmpNum.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("The recored was removed!");

            populateEmployeeNum();
            populateActivity();
        }

        public void populateEmployeeNum()
        {
            try
            {
                cmbEmpNum.Items.Clear();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string populateSql = "SELECT EmployeeNum FROM EMPLOYEE";
                cmd = new SqlCommand(populateSql, conn);
                reader2 = cmd.ExecuteReader();


                while (reader2.Read())
                {
                    cmbEmpNum.Items.Add(reader2.GetValue(0));
                    cmbEmpNum.SelectedIndex = 0;
                }

                reader2.Close();
                conn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.ToString());
            }
        }

        public void populateActivity()
        {
            try
            {
                cmbInvolved.Items.Clear();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd = new SqlCommand("SELECT activityName FROM ACTIVITY", conn);

                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    cmbInvolved.Items.Add(reader.GetValue(0));
                    cmbInvolved.SelectedIndex = 0;
                }

                reader.Close();
                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.ToString());
            }
        }

        public void DisplayInfo()
        {
            try
            {
                // Create a connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // Open the connection
                    conn.Open();

                    // Create a select command
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmployeeNum = @empNum", conn))
                    {
                        // Add the parameter
                        cmd.Parameters.AddWithValue("@empNum", cmbEmpNum.Text);

                        // Execute the command and retrieve the data
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assign the values to the text boxes and combo boxes
                                txtFirstName.Text = reader.GetString(1);
                                txtLastName.Text = reader.GetString(2);
                                txtEmail.Text = reader.GetString(3);
                                cmbInvolved.SelectedIndex = cmbInvolved.Items.IndexOf(reader.GetString(5));
                                
                            }
                            reader.Close();
                            conn.Close ();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying the information: " + ex.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            cmbEmpNum.Enabled = false;
            cmbInvolved.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;

            IUD = "Insert";

           

        }

        private void Maintain_Employee_Load(object sender, EventArgs e)
        {
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

           

            populateEmployeeNum();
            populateActivity();

        }

       


       
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;

            cmbInvolved.Enabled = false;
            cmbEmpNum.Enabled = true;
            

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;

            if (IUD == "Insert")
            {
                
                Insert();

            }
            if (IUD == "Update")
            {
                
                Update();
         
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtFirstName.Text= "";
            txtLastName.Text = "";
            cmbInvolved.Text = "";

            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;


            cmbInvolved.Enabled = false;
            cmbEmpNum.Enabled = true;
            cmbEmpNum.SelectedIndex = -1;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;

            DisplayInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;


            cmbInvolved.Enabled = true;
            cmbEmpNum.Enabled = true;

            btnInsert.Enabled = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;

            IUD = "Update";

        }

        private void cmbEmpNum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                DisplayInfo();
            
        }
    }
}
