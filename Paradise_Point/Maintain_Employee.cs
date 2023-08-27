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
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;

        
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";
        public Maintain_Employee()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void Maintain_Employee_Load(object sender, EventArgs e)
        {

            //check if connection is valid, if no error appears it's connected succesfully
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                conn.Close();
            }
            catch (SqlException error){
                MessageBox.Show(error.Message);
            }
        }
    }
}
