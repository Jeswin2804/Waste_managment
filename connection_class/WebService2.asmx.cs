using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Web.Services.Protocols;

namespace connection_class
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        public class Customer
        {
            public string Value { get; set; }
           
        }

        [WebMethod]
       

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection con2 = new SqlConnection(con);
            con2.Open();
            SqlCommand cmd = new SqlCommand("spSelectForAjx",con2);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                customers.Add(new Customer() { Value = reader.GetValue(0).ToString()});
            }
 
            return customers;
        }
    }
}

