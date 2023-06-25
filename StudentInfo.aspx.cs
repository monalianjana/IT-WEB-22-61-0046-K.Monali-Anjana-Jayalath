using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            SqlCommand command;
            SqlDataReader datareader;
            string sql, output = "";


            connectionString = @"Data Source=DESKTOP-4S8JR71;Initial Catalog=studentmanagement;Integrated Security=True";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            sql = "SELECT * From student";
            command = new SqlCommand(sql, cnn);

            datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                output = output + datareader.GetValue(0) + "-" + datareader.GetValue(1) + "-" + datareader.GetValue(2) + "-" + datareader.GetValue(3) + "<br/>" ;
            }

            Response.Write(output);
            datareader.Close();


            cnn.Close();
        }
    }
}