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

            
            string sqlName = "SELECT UnitNum FROM UNIT";
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

        }
    }
}
