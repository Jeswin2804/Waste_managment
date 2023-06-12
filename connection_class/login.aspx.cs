using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class login : System.Web.UI.Page
    {
        string query;
        //connection db = new connection();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con;
            con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;//using connection string in web config
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_insert", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@username", TextBox_username.Text);
            sqlCommand.Parameters.AddWithValue("@password", TextBox_password.Text);
            sqlCommand.ExecuteNonQuery();
        }
    }
}