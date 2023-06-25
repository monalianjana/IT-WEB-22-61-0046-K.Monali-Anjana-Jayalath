using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click (object sender, EventArgs e)
        {
            string studentname;
            string city;
            string corseid;

            studentname = TextBox2.Text.ToString();
            city = TextBox3.Text.ToString();
            corseid = TextBox4.Text.ToString();


            string connectionstring;
            SqlConnection cnn;

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql;

            connectionstring = @"Data Source=DESKTOP-4S8JR71;Initial Catalog=studentmanagement;Integrated Security=True";

            cnn = new SqlConnection(connectionstring);

            cnn.Open();

            sql = "INSERT INTO student (studentname, city, corseid) VALUES ('" + studentname + "','" + city + "','" + corseid + "')";

            command = new SqlCommand(sql,cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);

            adapter.InsertCommand.ExecuteNonQuery();

            Response.Write("SUCCESSFULLY REGISTERED!!!");

            command.Dispose();

            cnn.Close();

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}