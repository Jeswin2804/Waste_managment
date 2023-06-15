using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Page_Method : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        [WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static List<Countries> getCountries()
        {
            List<Countries> countries = new List<Countries>();
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection con = new SqlConnection(_con);
            con.Open();
            SqlCommand cmd = new SqlCommand("spSelectCountry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                countries.Add(new Countries() { Value = rd.GetValue(0).ToString() }); 
            }
            return countries;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = DropDownList1.SelectedValue.ToString();
          
        }
        public static List<Countries> getCountry(string contry)
        {
            List<Countries> cities = new List<Countries>();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con  =  new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("spSElectCities", _con);
            cmd.Parameters.AddWithValue("@country", contry);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
            cities.Add(new Countries() { Value=dr.GetValue(0).ToString() });
            }
            return cities;
        }
    }
}