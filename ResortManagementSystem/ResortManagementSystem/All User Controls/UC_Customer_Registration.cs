using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResortManagementSystem.All_User_Controls
{
    public partial class UC_Customer_Registration : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer_Registration()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from where bed ='" + txtBed.Text + "' and roomType ='" + txtRoomType.Text + "' and booked='NO'";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        int rid;

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo ='" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllocateRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;

                String dob = txtDob.Text;
                String idProof = txtIDProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;
                query = "insert into customer (cname,mobile,nationality,gender,dob,idProof,address,checkin,roomid)values ('" + name + "','" + mobile + "','" + nationality + "','" + gender + "','" + dob + "','" + idProof + "','" + address + "','" + checkin + "'," + rid + ") update rooms set bppked ='YES ' where roomNo ='" + txtRoomNo.Text + "'";
                fn.setData(query, "Room No" + txtRoomNo.Text + "Allocation successfull");
                clearAll();



            }
            else
            {
                MessageBox.Show("fill all fields", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();


        }

        private void UC_Customer_Registration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
