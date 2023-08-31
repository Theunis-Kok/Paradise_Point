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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnMaintainAct_Click(object sender, EventArgs e)
        {
            Maintain_Activities maintain_Activities = new Maintain_Activities();
            maintain_Activities.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void btnMaintainUnit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Unit maintain_Unit = new Maintain_Unit();
            maintain_Unit.ShowDialog();
            this.Visible = true;
        }

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Visible = true;
        }


        private void btnMaintainEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Employee maintain_employee = new Maintain_Employee();
            maintain_employee.ShowDialog();
            this.Visible = true;
        }

=======
>>>>>>> 6042fe8a70964fda24f7601e502e80ffce04f1dd
    }
}
