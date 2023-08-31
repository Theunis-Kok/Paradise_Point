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
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Maintain_Client()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Enabled = false;

            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtID.Enabled = true;
            txtCellPhone.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtID.Enabled = false;
            txtCellPhone.Enabled = false;
            txtEmail.Enabled = false;

            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(connString);
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

                    // Clear textboxes
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtID.Clear();
                    txtCellPhone.Clear();
                    txtEmail.Clear();

                    // Disable textboxes and hide buttons
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtID.Enabled = false;
                    txtCellPhone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnCancel.Visible = false;
                    btnSave.Visible = false;
                }
                else
                {
                    MessageBox.Show("No matching record found to update.");
                }

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Maintain_Client_Load_1(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                //sucess loaded
                MessageBox.Show("Database connection succesful");

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
    }
}
