using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class AddCorse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string corsename;
            string lecturename;

            corsename = TextBox1.Text.ToString();
            lecturename = TextBox2.Text.ToString();


            string connectionstring;
            SqlConnection cnn;

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql;

            connectionstring = @"Data Source=DESKTOP-4S8JR71;Initial Catalog=studentmanagement;Integrated Security=True";

            cnn = new SqlConnection(connectionstring);

            cnn.Open();

            sql = "INSERT INTO corses (corsename, lecturename) VALUES ('" + corsename + "','" + lecturename + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);

            adapter.InsertCommand.ExecuteNonQuery();

            Response.Write("SUCCESSFULLY ADDED!!!");

            command.Dispose();

            cnn.Close();

        }
    }
}