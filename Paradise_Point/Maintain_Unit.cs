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
    public partial class Maintain_Unit : Form
    {

        // Creating the variables to use the sql in the program
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        bool bInsert = false;

        // Globally declaring the connectionstring to connect to the database
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ParadisePoint.mdf;Integrated Security=True";

        public Maintain_Unit()
        {
            InitializeComponent();
        }


        private void Maintain_Unit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string sqlName = "SELECT UnitNum,location FROM UNIT";
            command = new SqlCommand(sqlName, conn);

            dataReader = command.ExecuteReader();

            string sID = "";

            while (dataReader.Read())
            {
                sID = Convert.ToString(dataReader.GetValue(0));

                cmbID.Items.Add(sID);
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            cmbID.SelectedIndex = 0;
            displayInfo();

            nudNoBath.Enabled = false;
            nudNoBeds.Enabled = false;
            txtPrice.Enabled = false;
            cmbLocation.Enabled = false;
        }

        public void UpdateComboBox()
        {
            cmbID.Items.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string sqlName = "SELECT UnitNum,location FROM UNIT";
            command = new SqlCommand(sqlName, conn);

            dataReader = command.ExecuteReader();

            string sID = "";

            while (dataReader.Read())
            {
                sID = Convert.ToString(dataReader.GetValue(0));

                cmbID.Items.Add(sID);
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            cmbID.SelectedIndex = 0;
            displayInfo();

            nudNoBath.Enabled = false;
            nudNoBeds.Enabled = false;
            txtPrice.Enabled = false;
            cmbLocation.Enabled = false;
        }

        private void displayInfo()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string sqlName = "SELECT * FROM UNIT WHERE UnitNum = '" + cmbID.Text + "'";
            command = new SqlCommand(sqlName, conn);

            dataReader = command.ExecuteReader();

            int inoOfBeds = 0;
            int inoOfBathorooms = 0;
            double dPrice = 0;
            string sLocation = "";

            while (dataReader.Read())
            {
                inoOfBeds = Convert.ToInt32(dataReader.GetValue(1));
                inoOfBathorooms = Convert.ToInt32(dataReader.GetValue(2));
                dPrice = Convert.ToDouble(dataReader.GetDecimal(3));
                sLocation = dataReader.GetString(4);

            }

            nudNoBeds.Value = inoOfBeds;
            nudNoBath.Value = inoOfBathorooms;
            txtPrice.Text = dPrice.ToString("f2");
            cmbLocation.SelectedIndex = cmbLocation.Items.IndexOf(sLocation);

            dataReader.Close();
            command.Dispose();
            conn.Close();
        }

        public void InsertIntoTable()
        {
            if (MessageBox.Show("Are jou sure that you want to insert this Unit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                int inumOfBeds = Convert.ToInt32(nudNoBeds.Value);
                int inumOfBathtooms = Convert.ToInt32(nudNoBath.Value);
                string sPrice = txtPrice.Text;
                string sLocation = cmbLocation.SelectedItem.ToString();
                int iNumberUnit = 0;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlNumber = "SELECT Count(*) AS RecordCount FROM UNIT";
                command = new SqlCommand(sqlNumber, conn);
                iNumberUnit = (int)command.ExecuteScalar();
                command.Dispose();
                iNumberUnit += 1;

                string sqlName = $"INSERT INTO UNIT (UnitNum, noOfBeds, noOfBathrooms, price, location) VALUES (" + iNumberUnit + "," + inumOfBeds + "," + inumOfBathtooms + "," + sPrice + ",'" + sLocation + "')";
                command = new SqlCommand(sqlName, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.InsertCommand = command;
                dataAdapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                conn.Close();

                cmbID.Enabled = true;
                nudNoBath.Enabled = false;
                nudNoBeds.Enabled = false;
                cmbLocation.Enabled = false;
                txtPrice.Enabled = false;


                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = true;


                btnCancel.Visible = false;
                btnSave.Visible = false;


                UpdateComboBox();
                MessageBox.Show("The record was updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void UpdateTable()
        {
            if (MessageBox.Show("Are jou sure that you want to update this Unit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                int inumOfBeds = Convert.ToInt32(nudNoBeds.Value);
                int inumOfBathtooms = Convert.ToInt32(nudNoBath.Value);
                string sPrice = txtPrice.Text;
                string sLocation = cmbLocation.SelectedItem.ToString();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                string sqlName = $"UPDATE UNIT SET noOfBeds = " + inumOfBeds.ToString() + ", noOfBathrooms = " + inumOfBathtooms.ToString() + ", price = " + sPrice + ", location = '" + sLocation + "' WHERE UnitNum = " + cmbID.SelectedItem.ToString();
                command = new SqlCommand(sqlName, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.UpdateCommand = command;
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                command.Dispose();
                conn.Close();

                cmbID.Enabled = true;
                nudNoBath.Enabled = false;
                nudNoBeds.Enabled = false;
                cmbLocation.Enabled = false;
                txtPrice.Enabled = false;


                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = true;


                btnCancel.Visible = false;
                btnSave.Visible = false;


                UpdateComboBox();
                MessageBox.Show("The record was updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bInsert = true;
            nudNoBath.Enabled = true;
            nudNoBeds.Enabled = true;
            txtPrice.Enabled = true;
            cmbLocation.Enabled = true;

            nudNoBath.Value = 0;
            nudNoBeds.Value = 0;
            txtPrice.Text = "";
            cmbLocation.SelectedIndex = 0;

            btnCancel.Visible = true;
            btnSave.Visible = true;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;

            cmbID.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbID.Enabled = true;
            nudNoBath.Enabled = false;
            nudNoBeds.Enabled = false;
            cmbLocation.Enabled = false;
            txtPrice.Enabled = false;


            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;


            btnCancel.Visible = false;
            btnSave.Visible = false;

            displayInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bInsert == true)
            {
                InsertIntoTable();
            }
            else
            {
                UpdateTable();
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are jou sure that you want to Delete this Unit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string SqlD = "DELETE FROM UNIT WHERE UnitNum = "+cmbID.SelectedItem.ToString();

                    command = new SqlCommand(SqlD, conn);
                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.DeleteCommand = command;
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    command.Dispose();
                    conn.Close();

                    MessageBox.Show("The record was removed!", "Removed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateComboBox();
                    displayInfo();

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bInsert = false;

            nudNoBath.Enabled = true;
            nudNoBeds.Enabled = true;
            txtPrice.Enabled = true;
            cmbLocation.Enabled = true;

            btnCancel.Visible = true;
            btnSave.Visible = true;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;

            cmbID.Enabled = false;
        }

    }
}
