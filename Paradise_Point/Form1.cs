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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Paradise_Point
{
    public partial class Form1 : Form
    {

        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT isAdmin, isSecretary FROM EMPLOYEE WHERE firstName = @firstName AND password = @password";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@firstName", txtUserName.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                reader = command.ExecuteReader();

                bool userFound = false;

                while (reader.Read())
                {
                    bool isAdmin = reader.GetBoolean(0);
                    bool isSecretary = reader.GetBoolean(1);

                    if (isAdmin || isSecretary)
                    {
                        userFound = true;
                        Dashboard_Form dashboardForm = new Dashboard_Form();
                        dashboardForm.Show();
                        this.Hide();
                    }
                }

                reader.Close();

                if (!userFound)
                {
                    MessageBox.Show("Access Denied! Incorrect username or password.");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
