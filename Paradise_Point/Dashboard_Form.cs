using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            loginForm.ShowDialog();
            this.Hide();
        }

        private void btnMaintainAct_Click(object sender, EventArgs e)
        {
            Maintain_Activities maintain_Activities = new Maintain_Activities();
            maintain_Activities.ShowDialog();
            this.Hide();
        }

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Hide();
        }

        private void btnMaintainUnit_Click_1(object sender, EventArgs e)
        {
            Maintain_Unit maintain_Unit = new Maintain_Unit();
            maintain_Unit.ShowDialog();
            this.Hide();
        }

        private void btnMaintainEmployee_Click_1(object sender, EventArgs e)
        {
            Maintain_Employee maintain_employee = new Maintain_Employee();
            maintain_employee.ShowDialog();
            this.Hide();
        }
    }
}
