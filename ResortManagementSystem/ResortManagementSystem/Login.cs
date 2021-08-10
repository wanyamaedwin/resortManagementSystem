using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResortManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "wes" && txtpassword.Text == "wes")
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();


            }
            else
            {
                labelError.Visible = true;
                txtpassword.Clear();
            }
        }
    }
}
