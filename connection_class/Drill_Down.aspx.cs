using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Drill_Down : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder table = new StringBuilder();
            if (!IsPostBack)
            {
                string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString; 
                SqlConnection _con = new SqlConnection(con);
                _con.Open();
                SqlCommand cmd = new SqlCommand("sp_BikeCollection", _con);
                cmd.Parameters.AddWithValue("@brand","KTM");
                cmd.Parameters.AddWithValue("@productName", "");
                cmd.Parameters.AddWithValue("@flag", "1");
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border='1'>");
                int totalCount = rd.FieldCount;
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        for(int i = 0; i < totalCount; i++)
                        {
                            table.Append("<tr><th onclick='cellClicked(this)'>");
                            table.Append(rd[i].ToString());
                            table.Append("</tr></th>");
                        }
                    }

                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            } 
    
        }

        [WebMethod]
        public static void addvalues(string input)
        {
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection con = new SqlConnection(_con);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_BikeCollection", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brand",input);
            cmd.Parameters.AddWithValue("@productName", "");
            cmd.Parameters.AddWithValue("@flag", "2");

        }
    }
}