using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connection = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand("spSelectall", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                table.Append(@"<table border='1'>");
                table.Append("<tr><th>id</th><th>name</th><th>subject</th><th>start</th><th>end</th><th>location</th></tr>");
                int totalRowCount = rdr.FieldCount;
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        table.Append("<tr>");
                        for (int i = 0; i < totalRowCount; i++)
                        {
                            if ("Science" == rdr[i].ToString())
                            {
                                table.Append("<td>");
                              
                                table.Append(rdr[i]);
                            }
                            else
                            {
                                table.Append("<td>");

                                table.Append(rdr[i]);
                            }
                            table.Append("</td>");
                          
                        }
                        table.Append("</tr>");
                    }
                   
                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rdr.Close();
            }
         }
    }
}

//add databse to html table