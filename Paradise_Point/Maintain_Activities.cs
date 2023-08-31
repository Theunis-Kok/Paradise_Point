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

                string populateCmb = "SELECT activityName FROM ACTIVITY";
                command = new SqlCommand(populateCmb, conn);
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

        private void displayData()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string display = "SELECT timeDuration, price FROM ACTIVITY WHERE activityName = '" + cmbName.Text + "'";
                command = new SqlCommand(display, conn);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int timeDuration = reader.GetInt32(0);
                    decimal price = reader.GetDecimal(1);

                    txtTimeDuration.Text = timeDuration.ToString();
                    lblPrice.Text = price.ToString();
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

        private void Maintain_Activities_Load(object sender, EventArgs e)
        {
            estabConnection();

            txtTimeDuration.Enabled = false;
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string populateSup = "SELECT firstName FROM EMPLOYEE WHERE activityInvolvedIn = '" + cmbName.Text + "'";
                command = new SqlCommand(populateSup, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbSupervisor.Items.Add(reader.GetValue(0));
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                
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

            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occurred: " + ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }
    }
}
