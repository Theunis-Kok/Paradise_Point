using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paradise_Point
{
    public partial class Secretary : Form
    {
        public Secretary()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
=======
        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Visible = true;
>>>>>>> 41d5ef0e02741830615aac87ecac9e0c6de10de1
        }
    }
}
