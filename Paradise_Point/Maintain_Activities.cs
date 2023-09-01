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
    public partial class Maintain_Activities : Form
    {
        public Maintain_Activities()
        {
            InitializeComponent();
        }

        int actNum = 0;
        string actName = "";
        string supervisor = "";
        int timeDuration = 0;
        double price = 0;
        int iActNum = 0;

        bool bInsert = false;
        bool bUpdate = false;

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ParadisePoint.mdf;Integrated Security=True";

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

        public void displayData()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string display = "SELECT ActNum, timeDuration, price FROM ACTIVITY WHERE activityName = '" + cmbName.Text + "'";
                command = new SqlCommand(display, conn);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    actNum = reader.GetInt32(0);
                    timeDuration = reader.GetInt32(1);
                    price = Convert.ToDouble( reader.GetValue(2));

                    txtTimeDuration.Text = timeDuration.ToString();
                    txtPrice.Text = price.ToString();
                }

                reader.Close();
                command.Dispose();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void Insert()
        {
            try
            {
                actName = cmbName.Text;
                supervisor = cmbSupervisor.Text;
                timeDuration = Convert.ToInt32(txtTimeDuration.Text);
                price = Convert.ToDouble(txtPrice.Text);

                // Create a connection object
                conn = new SqlConnection(connString);
                // Open the connection
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlNum = "SELECT MAX(ActNum) AS ActNum FROM ACTIVITY";
                command = new SqlCommand(sqlNum, conn);
                iActNum = (int)command.ExecuteScalar();
                command.Dispose();
                iActNum += 1;
                
                // Create an insert command
                command = new SqlCommand("INSERT INTO ACTIVITY (ActNum, activityName, timeDuration, price) VALUES (@ActNum, @actName, @timeDuration, @price)", conn);
                // Add the parameters
                command.Parameters.AddWithValue("@ActNum", iActNum);
                command.Parameters.AddWithValue("@actName", actName);
                command.Parameters.AddWithValue("@timeDuration", timeDuration);
                command.Parameters.AddWithValue("@price", price);

                // Execute the command
                command.ExecuteNonQuery();

                MessageBox.Show("The record was Inserted successfully! ", "Updated successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void update()
        {
            try
            {
                conn = new SqlConnection(connString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string update = $"UPDATE ACTIVITY SET activityName = '" + cmbName.SelectedItem.ToString() + "', timeDuration = " + txtTimeDuration.Text + ", price = " + txtPrice.Text + " WHERE ActNum = " + actNum + "";
                command = new SqlCommand(update, conn);

                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("The record was updated! ", "Updated successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void populateName()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string populateName = "SELECT DISTINCT activityName FROM ACTIVITY";
                command = new SqlCommand(populateName, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbName.Items.Add(reader.GetValue(0));
                }

                reader.Close();
                command.Dispose();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void populateSupervisor()
        {
            try
            {
                conn = new SqlConnection(connString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string populateSup = "SELECT DISTINCT firstName FROM EMPLOYEE WHERE activityInvolvedIn = '" + cmbName.Text + "'";
                command = new SqlCommand(populateSup, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbSupervisor.Items.Add(reader.GetValue(0));
                    cmbSupervisor.SelectedIndex = 0;
                }

                reader.Close();
                command.Dispose();
                conn.Close();

                displayData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        public void delete()
        {
            try
            {
                conn = new SqlConnection(connString);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlDelete = "DELETE FROM ACTIVITY WHERE activityName = '" + cmbName.SelectedItem.ToString() + "'";
                command = new SqlCommand(sqlDelete, conn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("The record was Deleted! ", "Deleted successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbName.Items.Clear();
                cmbName.Text = "";
                cmbSupervisor.Items.Clear();
                cmbSupervisor.Text = "";
                txtTimeDuration.Text = "";
                txtPrice.Text = "";

                populateName();
                populateSupervisor();

                command.Dispose();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        private void Maintain_Activities_Load(object sender, EventArgs e)
        {
            txtTimeDuration.Enabled = false;
            txtPrice.Enabled = false;

            btnSave.Visible = false;
            btnCancel.Visible = false;

            populateName();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                populateSupervisor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                bInsert = true;

                cmbName.Items.Clear();
                cmbName.Text = "";
                cmbSupervisor.Items.Clear();
                cmbSupervisor.Text = "";
                txtTimeDuration.Text = "";
                txtPrice.Text = "";

                txtTimeDuration.Enabled = true;
                txtPrice.Enabled = true;

                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimeDuration.Enabled = true;
                txtPrice.Enabled = true;

                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                delete();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                cmbName.Items.Clear();
                cmbName.Text = "";
                cmbSupervisor.Items.Clear();
                cmbSupervisor.Text = "";
                txtTimeDuration.Text = "";
                txtPrice.Text = "";

                populateName();

                txtTimeDuration.Enabled = false;
                txtPrice.Enabled = false;

                btnSave.Visible = false;
                btnCancel.Visible = false;

                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                bInsert = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bInsert == true)
            {
                Insert();

                cmbName.Items.Clear();
                cmbName.Text = "";

                cmbSupervisor.Items.Clear();
                cmbSupervisor.Text = "";

                txtTimeDuration.Text = "";
                txtPrice.Text = "";

                populateName();
                populateSupervisor();
            }
            else
            {
                update();

                cmbName.Items.Clear();
                cmbName.Text = "";
                cmbSupervisor.Items.Clear();
                cmbSupervisor.Text = "";
                txtTimeDuration.Text = "";
                txtPrice.Text = "";

                populateName();
                populateSupervisor();
            }
        }
    }
}
