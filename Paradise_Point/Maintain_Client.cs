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

        public Maintain_Client()
        {
            InitializeComponent();
        }

        private void Maintain_Client_Load(object sender, EventArgs e)
        {

            try
            {
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";
                conn = new SqlConnection(ConnectionString);

                conn.Open();

                //sucess loaded
                MessageBox.Show("Database connection succesful");

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Adding to combo box
            conn.Open();

            reader = command.ExecuteReader();

            cmbSelectID.Items.Clear();

            while (reader.Read())
            {
                cmbSelectID.Items.Add(reader.GetValue(0));
            }
            conn.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Deleting
            try
            {
                conn.Open();
                //string where you delete from database that is in combobox
                string delete_query = "DELETE // FROM  WHERE // ='" + cmbSelectID.Text + "'";

                SqlCommand command1 = new SqlCommand(delete_query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command1;
                adapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Succesfuly Deleted");

                conn.Close();


            }//catch error for wrongs
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void cmbSelectID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
