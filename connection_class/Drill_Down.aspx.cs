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
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Drill_Down : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                using (SqlConnection _con = new SqlConnection(con))
                {
                    _con.Open();
                    SqlCommand cmd = new SqlCommand("sp_BikeCollection", _con);
                    cmd.Parameters.AddWithValue("@brand", "");
                    cmd.Parameters.AddWithValue("@productName", "");
                    cmd.Parameters.AddWithValue("@flag", "1");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rd = cmd.ExecuteReader();

                    StringBuilder table = new StringBuilder();
                    table.Append("<table border='1' id='myTable'>");
                    int totalCount = rd.FieldCount;

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            for (int i = 0; i < totalCount; i++)
                            {
                                table.Append("<tr><th onclick='cellClicked(this)' colspan='1'>");
                                table.Append(rd[i].ToString());
                                table.Append("</tr></th>");
                            }
                        }
                    }
                    table.Append("</table>");
                    PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                    rd.Close();
                    _con.Close();
                }
            }
        }

        [WebMethod]
        public static List<string> addvalues(string input)
        {
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_BikeCollection", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brand", input);
                cmd.Parameters.AddWithValue("@productName", "");
                cmd.Parameters.AddWithValue("@flag", "2");
                SqlDataReader sdr = cmd.ExecuteReader();

                List<string> rows = new List<string>();
                while (sdr.Read())
                {
                    string cellValue = sdr.GetString(0);
                    rows.Add(cellValue);
                }

                sdr.Close();
                con.Close();

                return rows;
            }
        }
        [WebMethod]
        public static List<string> addsubvalues(string data)
        {
            int i = new int();
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_BikeCollection",con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brand","");
                cmd.Parameters.AddWithValue("@productName", data);
                cmd.Parameters.AddWithValue("@flag", 3);
                SqlDataReader sdr = cmd.ExecuteReader();
                List <string> rows = new List<string>();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        for (i = 0; i < sdr.FieldCount; i++)
                        {
                            rows.Add(sdr.GetValue(i).ToString());
                        }
                    }
                }
                sdr.Close();
                con.Close();
                return rows;

                //this is from lap
            }
        }
    }
}
