using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class AutoCompleteTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        [WebMethod]
        public static List<String> getNames(string Name)
        {
            List<String> emp = new List<String>();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con =  new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("spSuggesion", _con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sug", Name);
            _con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                emp.Add(rd.GetString(0));
            }
            return emp;

        }
    }
}