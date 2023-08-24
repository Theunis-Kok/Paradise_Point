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

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
