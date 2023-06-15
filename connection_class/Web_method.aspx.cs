using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //[WebMethod]
        //public static List<ListItem> GetCustomers()
        //{

        //    string constr = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
        //    SqlConnection con = new SqlConnection(constr);

        //    SqlCommand cmd = new SqlCommand("spSelectForAjx", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    List<ListItem> customers = new List<ListItem>();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    con.Open();
        //    using (SqlDataReader sdr = cmd.ExecuteReader())
        //    {
        //        while (sdr.Read())
        //        {
        //            customers.Add(new ListItem
        //            {
        //                Value = sdr["id"].ToString(),
        //                Text = sdr["Name"].ToStrng()
        //            });
        //        }
        //    }
        //    con.Close();
        //    return customers;
        //}
    }

}
