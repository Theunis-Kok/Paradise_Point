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
    public partial class Maintain_Client : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";

        int iClientNum = 0;
        bool Upsert = false;

        // Error providers for validation
    
        private ErrorProvider errorIDs = new ErrorProvider();
        private ErrorProvider errorCellPhones = new ErrorProvider();
        private ErrorProvider errorNames = new ErrorProvider();
        private ErrorProvider errorLastNames = new ErrorProvider();
        private ErrorProvider errorEmails = new ErrorProvider();


        public Maintain_Client()
        {
            InitializeComponent();
            // Initialize error providers
            
            errorID.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorCellPhone.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool ContainsNumbers(string value)
        {
            return value.Any(char.IsDigit);
        }

        public void PopulateComboBox()
        {
            try
            {

                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                // Populate ComboBox
                string select_query = "SELECT ClientNum FROM CLIENT";
                command = new SqlCommand(select_query, conn);
                reader = command.ExecuteReader();

                // Clear existing items
                cmbSelectID.Items.Clear();

                // Populate ComboBox with values from the reader
                while (reader.Read())
                {
                    cmbSelectID.Items.Add(reader["ClientNum"].ToString());
                }

                reader.Close();

                // Set the selected index to 0 (display the first value)
                if (cmbSelectID.Items.Count > 0)
                {
                    cmbSelectID.SelectedIndex = 0;
                }

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtCellPhone.Enabled = false;
            txtEmail.Enabled = false;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtID.Visible = true;
            txtCellPhone.Visible = true;
            txtEmail.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtID.Enabled = true;
            txtCellPhone.Enabled = true;
            txtEmail.Enabled = true;

            Upsert = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            cmbSelectID.Enabled = true;

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtCellPhone.Enabled = false;
            txtEmail.Enabled = false;

            btnCancel.Visible = false;
            btnSave.Visible = false;

            if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

            // Populate ComboBox
            string select_query = "SELECT ClientNum FROM CLIENT";
            command = new SqlCommand(select_query, conn);
            reader = command.ExecuteReader();

            // Clear existing items
            cmbSelectID.Items.Clear();

            // Populate ComboBox with values from the reader
            while (reader.Read())
            {
                cmbSelectID.Items.Add(reader["ClientNum"].ToString());
            }

            reader.Close();

            // Set the selected index to 0 (display the first value)
            if (cmbSelectID.Items.Count > 0)
            {
                cmbSelectID.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing error providers

                errorID.Clear();
                errorCellPhone.Clear();
                errorName.Clear();
                errorLastName.Clear();
                errorEmail.Clear();

                // Validate ID format (13 digits)
                if (!IsNumeric(txtID.Text) || txtID.Text.Length != 13)
                {
                    errorID.SetError(txtID, "Invalid ID format (must be 13 digits).");
                    return;
                }

                // Validate cellphone format (10 digits)
                if (!IsNumeric(txtCellPhone.Text) || txtCellPhone.Text.Length != 10)
                {
                    errorCellPhone.SetError(txtCellPhone, "Invalid cellphone number format (must be 10 digits).");
                    return;
                }

                // Validate first name (no numbers)
                if (ContainsNumbers(txtFirstName.Text))
                {
                    errorName.SetError(txtFirstName, "First name cannot contain numbers.");
                    return;
                }

                // Validate last name (no numbers)
                if (ContainsNumbers(txtLastName.Text))
                {
                    errorLastName.SetError(txtLastName, "Last name cannot contain numbers.");
                    return;
                }

                // Validate email (must contain @)
                if (!txtEmail.Text.Contains("@"))
                {
                    errorEmail.SetError(txtEmail, "Invalid email format (must contain '@').");
                    return;
                }

                if (Upsert == true)
                {

                    //insert text 
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string sqlNumber = "Select MAX(ClientNum) AS ClientNum FROM CLIENT";
                    SqlCommand command1 = new SqlCommand(sqlNumber, conn);
                    iClientNum = (int)command1.ExecuteScalar();
                    command1.Dispose();
                    iClientNum += 1;

                    string insert_query = "INSERT INTO CLIENT(ClientNum,firstName,lastName,id,cellphone,email) VALUES (" + iClientNum + ",'" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtID.Text + "','" + txtCellPhone.Text + "','" + txtEmail.Text + "')";

                    //inser string
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(insert_query, conn);

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                    //message that shows that data has been updated 
                    MessageBox.Show("Data has been inserted successfully");
                    conn.Close();

                    
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtID.Enabled = false;
                    txtCellPhone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnCancel.Visible = false;
                    btnSave.Visible = false;

                    btnDelete.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;

                    PopulateComboBox();
                    cmbSelectID.Enabled = true;
                    cmbSelectID.SelectedIndex = 0;


                }
                else {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string update_query = "UPDATE CLIENT SET firstName = @FirstName, lastName = @LastName, id = @ID, cellphone = @Cellphone, email = @Email WHERE ClientNum = @SelectedID";
                    SqlCommand updateCommand = new SqlCommand(update_query, conn);

                    updateCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    updateCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    updateCommand.Parameters.AddWithValue("@ID", txtID.Text);
                    updateCommand.Parameters.AddWithValue("@Cellphone", txtCellPhone.Text);
                    updateCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    updateCommand.Parameters.AddWithValue("@SelectedID", cmbSelectID.Text);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated");

                        // Refresh the ComboBox after update
                        cmbSelectID.Items.Clear();

                        // Populate ComboBox
                        string select_query = "SELECT ClientNum FROM CLIENT";
                        command = new SqlCommand(select_query, conn);
                        reader = command.ExecuteReader();

                        // Clear existing items
                        cmbSelectID.Items.Clear();

                        // Populate ComboBox with values from the reader
                        while (reader.Read())
                        {
                            cmbSelectID.Items.Add(reader["ClientNum"].ToString());
                        }

                        reader.Close();

                        // Set the selected index to 0 (display the first value)
                        if (cmbSelectID.Items.Count > 0)
                        {
                            cmbSelectID.SelectedIndex = 0;
                        }

                        /*// Clear textboxes
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtID.Clear();
                        txtCellPhone.Clear();
                        txtEmail.Clear();*/

                        // Disable textboxes and hide buttons
                        cmbSelectID.Enabled = true;
                        cmbSelectID.SelectedIndex = 0;
                        txtFirstName.Enabled = false;
                        txtLastName.Enabled = false;
                        txtID.Enabled = false;
                        txtCellPhone.Enabled = false;
                        txtEmail.Enabled = false;
                        btnCancel.Visible = false;
                        btnSave.Visible = false;

                        btnDelete.Enabled = true;
                        btnInsert.Enabled = true;
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to update.");
                    }

                    conn.Close();
                }

                PopulateComboBox();
                cmbSelectID.Enabled = true;
                cmbSelectID.SelectedIndex = 0;


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Maintain_Client_Load_1(object sender, EventArgs e)
        {
            PopulateComboBox();
            /*try
            {
                
                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                

                // Populate ComboBox
                string select_query = "SELECT ClientNum FROM CLIENT";
                command = new SqlCommand(select_query, conn);
                reader = command.ExecuteReader();

                // Clear existing items
                cmbSelectID.Items.Clear();

                // Populate ComboBox with values from the reader
                while (reader.Read())
                {
                    cmbSelectID.Items.Add(reader["ClientNum"].ToString());
                }

                reader.Close();

                // Set the selected index to 0 (display the first value)
                if (cmbSelectID.Items.Count > 0)
                {
                    cmbSelectID.SelectedIndex = 0;
                }

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtCellPhone.Enabled = false;
            txtEmail.Enabled = false;*/
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Deleting
            try
            {
                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string delete_query = "DELETE FROM CLIENT WHERE ClientNum = @SelectedID"; // Replace CLIENT with your actual table name
                SqlCommand command1 = new SqlCommand(delete_query, conn);

                command1.Parameters.AddWithValue("@SelectedID", cmbSelectID.Text);

                int rowsAffected = command1.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Deleted");

                    // Refresh the ComboBox after deletion
                    cmbSelectID.Items.Clear();
                    // Populate ComboBox
                    string select_query = "SELECT ClientNum FROM CLIENT";
                    command = new SqlCommand(select_query, conn);
                    reader = command.ExecuteReader();

                    // Clear existing items
                    cmbSelectID.Items.Clear();

                    // Populate ComboBox with values from the reader
                    while (reader.Read())
                    {
                        cmbSelectID.Items.Add(reader["ClientNum"].ToString());
                    }

                    reader.Close();

                    // Set the selected index to 0 (display the first value)
                    if (cmbSelectID.Items.Count > 0)
                    {
                        cmbSelectID.SelectedIndex = 0;
                    }

                    // Clear textboxes
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtID.Clear();
                    txtCellPhone.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("No matching record found to delete.");
                }

                conn.Close();

                PopulateComboBox();

            }//catch error for wrongs
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cmbSelectID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string select_query = "SELECT firstName, lastName, id, cellphone, email FROM CLIENT WHERE ClientNum = @SelectedID"; // Replace Column1, Column2, Column3, Column4, TableName
                command = new SqlCommand(select_query, conn);
                command.Parameters.AddWithValue("@SelectedID", cmbSelectID.Text);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Populate TextBoxes with corresponding information
                    txtFirstName.Text = reader["firstName"].ToString();
                    txtLastName.Text = reader["lastName"].ToString();
                    txtID.Text = reader["id"].ToString();
                    txtCellPhone.Text = reader["cellphone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                else
                {
                    // Clear TextBoxes if no matching record found
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtID.Clear();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmbSelectID.Enabled = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtID.Enabled = true;
            txtCellPhone.Enabled = true;
            txtEmail.Enabled = true;

            btnInsert.Enabled = false;

            // Clear textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtCellPhone.Clear();
            txtEmail.Clear();
            cmbSelectID.Items.Clear();
            cmbSelectID.Text = "";  

            Upsert = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }
    }
}
