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
    public partial class Secretary : Form
    {

        SqlConnection conn;

        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ParadisePoint.mdf;Integrated Security=True";


        public Secretary()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Hide();
        }

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Hide();
        }

        private void Secretary_Load(object sender, EventArgs e)
        {
      
        }

        private void btnBookAct_Click(object sender, EventArgs e)
        {
            Booking_Activity booking = new Booking_Activity();
            booking.Show();
            this.Hide();
        }
    }
}
