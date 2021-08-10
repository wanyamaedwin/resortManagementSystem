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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_Customer_Registration1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_Employee1.Visible = false;
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            uC_Customer_Registration1.Visible = true;
            uC_Customer_Registration1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
    }
}
