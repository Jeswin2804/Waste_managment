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
    public partial class Wep_method_dropdownlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("spSelect_name_id", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<ListItem> subject = new List<ListItem>();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                subject.Add(new ListItem
                {
                    Value = rd["id"].ToString(),
                    Text = rd["subject"].ToString()
                });
            }

        }
    }
}