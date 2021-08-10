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
    public partial class UC_AddRoom : UserControl
    {

        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomNo = txtRoomNo.Text;
                String roomType = txtRoomType.Text;
                String bed = txtBed.Text;
                String price = txtPrice.Text;
                Int64 Price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms (roomNo,roomType,bed,price)values ('" + roomNo + "','" + roomType + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");
                UC_AddRoom_Load(this, null);
                ClearAll();





            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();


        }


        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            ClearAll();

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select* from rooms";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];

        }
    }
}
