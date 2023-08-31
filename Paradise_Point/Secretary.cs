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

        private void btnMaintainClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Client maintain_Client = new Maintain_Client();
            maintain_Client.ShowDialog();
            this.Visible = true;
        }
    }
}
