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
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.rooNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid where checkout ='NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.rooNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid where cname like'" + txtName.Text + "%'and checkout ='NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtName1.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ;
                }

                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update customer set checkout ='YES',chekout='" + cdate + "' where cid =" + id + " update rooms set booked = 'No' where roomNo ='" + txtRoomNo.Text + "'";
                    fn.setData(query, "Checkout successfully.");
                    UC_CheckOut_Load(this, null);


                }

            }
            MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void clearAll()
        {
            txtName1.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
