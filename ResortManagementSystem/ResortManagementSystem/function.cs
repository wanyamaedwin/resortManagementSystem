using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace ResortManagementSystem
{
    class function
    {
        protected SqlConnection getConnection()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-5JGM0B1\\SQLEXPRESSWES;database=myResort;integrated security = True";
            return con;

        }
        public DataSet getData(String query)    //get data from the database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

             da.Fill(ds);
            return ds;
        }

        internal SqlDataReader getForCombo(string query)
        {
            throw new NotImplementedException();
        }

        public void setData(String query, String message) //inserting, updating and deleting
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
