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
                displayInfo();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.ToString());
            }
        }

        public void Update()
        {
            string empNum = cmbEmpNum.Text;
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string email = txtEmail.Text;
            string activityInvolved = cmbInvolved.Text;

           
            conn = new SqlConnection(connString);
            conn.Open();

            cmd = new SqlCommand("UPDATE EMPLOYEE SET ActNum =@actnum, firstName = @fName, lastName = @lName, email = @email, activityInvolvedIn = @activityInvolved WHERE EmployeeNum = @empNum", conn);

            cmd.Parameters.AddWithValue("@empNum", empNum);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@activityInvolved", activityInvolved);
            cmd.Parameters.AddWithValue("@actnum", actNum);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("The record was updated sucessfully!");
            populateEmployeeNum();
            populateActivity();
        }

        public void Delete()
        {
            //string empNum = cmbEmpNum.SelectedItem.ToString();

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

        public void displayInfo()
        {
            string firstname = "";
            string lastname = "";
            string email = "";
            string involvedAct = "";

            conn = new SqlConnection(connString);

            conn.Open();


            cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmployeeNum = @empNum", conn);
            cmd.Parameters.AddWithValue("@empNum", cmbEmpNum.Text);
            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                firstname = reader.GetString(1);
                lastname = reader.GetString(2);
                email = reader.GetString(3);
                involvedAct = reader.GetString(5);

                txtFirstName.Text = firstname;
                txtLastName.Text = lastname;
                txtEmail.Text = email;
                cmbInvolved.SelectedIndex = cmbInvolved.Items.IndexOf(involvedAct);
            }
            reader.Close();
            conn.Close();
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

            displayInfo();

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

            conn = new SqlConnection(connString);

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
            cmbEmpNum.SelectedIndex = -1;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;

            if (IUD == "Insert")
            {
                //SaveActNum();

                Insert();

                cmbEmpNum.Items.Clear();
                cmbInvolved.Items.Clear();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";

                populateEmployeeNum();
                populateActivity();
                displayInfo();
            }
            else if (IUD == "Update")
            {
                SaveActNum();
                Update();

                cmbEmpNum.Items.Clear();
                cmbInvolved.Items.Clear();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";

                populateEmployeeNum();
                populateActivity();
                displayInfo();
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

            displayInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            displayInfo();
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

            displayInfo();
        }

        private void cmbEmpNum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
                displayInfo();
            
        }
    }
}
