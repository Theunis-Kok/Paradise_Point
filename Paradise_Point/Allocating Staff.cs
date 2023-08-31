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
    public partial class Allocating_Staff : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";

        public static int arraySize = 6;
        public string[] arrActivityName = new string[arraySize];
        public string[] arrEmployeeName = new string[arraySize];
        public int numberOfActivties = 0;

        public Allocating_Staff()
        {
            InitializeComponent();
        }

        
        public void displayInfo()
        {
            if(numberOfActivties >= 1 )
            {
                lblAct1.Visible = true;
                cmbStaff1.Visible = true;
                lblAct1.Text = arrActivityName[0];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '"+lblAct1.Text+"'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff1.SelectedIndex = cmbStaff1.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();

                
            }
            if (numberOfActivties >= 2)
            {
                lblAct2.Visible = true;
                cmbStaff2.Visible = true;
                lblAct2.Text = arrActivityName[1];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '" + lblAct2.Text + "'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff2.SelectedIndex = cmbStaff2.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            if (numberOfActivties >= 3)
            {
                lblAct3.Visible = true;
                cmbStaff3.Visible = true;
                lblAct3.Text = arrActivityName[2];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '" + lblAct3.Text + "'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff3.SelectedIndex = cmbStaff3.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            if (numberOfActivties >= 4)
            {
                lblAct4.Visible = true;
                cmbStaff4.Visible = true;
                lblAct4.Text = arrActivityName[3];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '" + lblAct4.Text + "'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff4.SelectedIndex = cmbStaff4.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            if (numberOfActivties >= 5)
            {
                lblAct5.Visible = true;
                cmbStaff5.Visible = true;
                lblAct5.Text = arrActivityName[4];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '" + lblAct5.Text + "'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff5.SelectedIndex = cmbStaff5.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            if (numberOfActivties >= 6)
            {
                lblAct6.Visible = true;
                cmbStaff16.Visible = true;
                lblAct6.Text = arrActivityName[5];

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sqlReadN = "SELECT activityInvolvedIn, firstName, lastName FROM EMPLOYEE WHERE activityInvolvedIn = '" + lblAct6.Text + "'";
                command = new SqlCommand(sqlReadN, conn);

                dataReader = command.ExecuteReader();
                string sNameN = "";
                string sSurname = "";


                while (dataReader.Read())
                {
                    sNameN = dataReader.GetString(1);
                    sSurname = dataReader.GetString(2);

                }

                cmbStaff16.SelectedIndex = cmbStaff16.Items.IndexOf(sNameN + " " + sSurname);

                dataReader.Close();
                command.Dispose();
                conn.Close();
            }

            btnCancel.Visible = false;
        }

        public void getActivityName()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sqlRead = "SELECT activityName FROM ACTIVITY";
            command = new SqlCommand(sqlRead, conn);

            dataReader = command.ExecuteReader();
            string sActivity = "";
            string sName = "";

            int k = 0;
            numberOfActivties = 0;
            while (dataReader.Read())
            {
                sActivity = dataReader.GetString(0);

                arrActivityName[k] = sActivity;
                k++;
                numberOfActivties++;
                
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();
        }

        public void getEmployeeName()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sqlReadN = "SELECT isAdmin, isSecretary, EmployeeNum, firstName, lastName FROM EMPLOYEE";
            command = new SqlCommand(sqlReadN, conn);

            dataReader = command.ExecuteReader();
            string sNameN = "";
            string sSurname = "";

            int i = 0;

            while (dataReader.Read())
            {
                bool isAdmin = dataReader.GetBoolean(0);
                bool isSecretary = dataReader.GetBoolean(1);

                if(isAdmin == false && isSecretary == false)
                {
                    sNameN = dataReader.GetString(3);
                    sSurname = dataReader.GetString(4);

                    arrEmployeeName[i++] = sNameN + " " + sSurname;

                    cmbStaff1.Items.Add(sNameN + " " + sSurname);
                    cmbStaff2.Items.Add(sNameN + " " + sSurname);
                    cmbStaff3.Items.Add(sNameN + " " + sSurname);
                    cmbStaff4.Items.Add(sNameN + " " + sSurname);
                    cmbStaff5.Items.Add(sNameN + " " + sSurname);
                    cmbStaff16.Items.Add(sNameN + " " + sSurname);
                }
                
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();
        }

        private void Allocating_Staff_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);

            getActivityName();
            getEmployeeName();
            displayInfo();

        }

        private void cmbStaff1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btnCancel.Visible = true;
        }

        private void cmbStaff2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void cmbStaff3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void cmbStaff4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void cmbStaff5_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void cmbStaff16_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard_Form dashboard_Form = new Dashboard_Form();
            dashboard_Form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            getActivityName();
            getEmployeeName();
            displayInfo();

            btnCancel.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstDisplay.Visible = true;
            lstDisplay.Items.Clear();
            DateTime currentDate = DateTime.Now;
            string currentDateAsString = currentDate.ToString("yyyy-MM-dd");
            btnCancel.Visible = false;
            btnSave.Visible = false;

            string sName1 = "";

            arrEmployeeName[0] = cmbStaff1.Text;
            arrEmployeeName[1] = cmbStaff2.Text;
            arrEmployeeName[2] = cmbStaff3.Text;
            arrEmployeeName[3] = cmbStaff4.Text;
            arrEmployeeName[4] = cmbStaff5.Text;
            arrEmployeeName[5] = cmbStaff16.Text;


            lstDisplay.Items.Add("Roster for week: " + currentDateAsString);
            for (int k = 0; k < numberOfActivties;k++)
            {
                sName1 = $"{arrActivityName[k].PadRight(30)} : {arrEmployeeName[k]}";
                lstDisplay.Items.Add(sName1);
            }

           

           // MessageBox.Show("Roster for week: "+currentDateAsString+"\n"+sName1+"\n"+sName2 + "\n" + sName3 + "\n" + sName4 + "\n" + sName5 + "\n" + sName6);

        }
    }
}
