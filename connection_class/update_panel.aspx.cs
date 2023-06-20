using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class update_panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkAvailability(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                SqlConnection _con = new SqlConnection(con);
                _con.Open();
                SqlCommand cmd = new SqlCommand("spCheckUserName", _con);
                cmd.Parameters.AddWithValue("@input", txt.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    Label1.Visible = true;
                    Image1.Visible = true;
                    Image1.ImageUrl = "approved.png";
                    Label1.Text = "user name already exist";
                }
                else
                {
                    Label1.Visible = true;
                    Image1.Visible = true;
                    Image1.ImageUrl = "checked.png";
                    Label1.Text = "Succefully created username";
                }

            }
            else
            {

            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            checkAvailability(TextBox1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            checkAvailability(TextBox1);
        }
    }
}