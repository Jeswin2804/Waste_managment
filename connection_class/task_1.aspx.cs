    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class task_1 : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                i = 0;

                
                DropDownList1.Items.Add("SELECT YOUR COUNTRY");
                DropDownList2.Items.Add("SELECT YOUR STATE");
                DropDownList3.Items.Add("SELECT YOUR CITY");

                string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                SqlConnection _con = new SqlConnection(con);
                _con.Open();
                SqlCommand cmd = new SqlCommand("spSelectDiffQuery", _con);
                cmd.Parameters.AddWithValue("@input", " ");
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetString(0));
                }

            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            string dropdownlist = DropDownList1.SelectedItem.ToString();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con = new SqlConnection(con);
            _con.Open();
            SqlCommand cmd = new SqlCommand("spSelectDiffQuery", _con);
            cmd.Parameters.AddWithValue("@input",dropdownlist);
            cmd.Parameters.AddWithValue("@flag", 2);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList2.Items.Add(dr.GetString(0));
            }
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            string dropdownlist = DropDownList2.SelectedItem.ToString();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con = new SqlConnection(con);
            _con.Open();
            SqlCommand cmd = new SqlCommand("spSelectDiffQuery", _con);
            cmd.Parameters.AddWithValue("@input", dropdownlist);
            cmd.Parameters.AddWithValue("@flag", 3);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList3.Items.Add(dr.GetString(0));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}