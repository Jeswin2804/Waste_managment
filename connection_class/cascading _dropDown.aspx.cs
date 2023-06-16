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
    public partial class cascading__dropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DropDownList1.Items.Add("SELECT YOUR COUNTRY");
                DropDownList2.Items.Add("SELECT YOUR STATE");
                DropDownList3.Items.Add("SELECT YOUR CITY");

                string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                SqlConnection _con =  new SqlConnection(con);
                _con.Open();
                SqlCommand cmd = new SqlCommand("spSelect_Country",_con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetString(0));
                }

            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            string dropdownlist = DropDownList2.SelectedItem.ToString();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con = new SqlConnection(con);
            _con.Open();
            SqlCommand cmd = new SqlCommand("spSelect_Cities", _con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@State", dropdownlist);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList3.Items.Add(dr.GetString(0));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();    
            string dropdownlist = DropDownList1.SelectedItem.ToString();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con = new SqlConnection(con);
            _con.Open();
            SqlCommand cmd = new SqlCommand("spSelect_State", _con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@country",dropdownlist);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList2.Items.Add(dr.GetString(0));
            }
        }
        private void trying(DropDownList ddl,string Stored,string query )
        {

        }
    }
}