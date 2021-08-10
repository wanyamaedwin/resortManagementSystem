using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResortManagementSystem.All_User_Controls
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUserName.Text;
                String pass = txtPassword.Text;
                query = "insert into employee (eame,mobile,gender,emailid,username,pass) values('" + name + "','" + mobile + "','" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Employee Registered.");
                clearAll();
                getMaxID();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning.....!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
          if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();

            }

        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView4);

            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView6);


            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select* from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation....!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
                query = "delete from emplyee where eid =" + txtID.Text + "";
                fn.setData(query, "Record Deleted");
                tabEmployee_SelectedIndexChanged(this, null);

            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
