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
    public partial class Help_Form : Form
    {

        public bool AdminDashBord = false;

        public Help_Form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (AdminDashBord == true)
            {
                Dashboard_Form dash = new Dashboard_Form();
                dash.Show();
                this.Hide();
            }
            else
            {
                Secretary secretary = new Secretary();
                secretary.Show();
                this.Hide();
            }
        }
    }
}
