using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Grid_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grind_Data("spSelectall");
            }

        }
        private SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString);
            con.Open();
            return con;
        }
        private void grind_Data(string query)
        {
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        private void grind_Data(string query, string parameter)
        {
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parameter, TextBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            if (dt1.Rows.Count != 0)
            {
                GridView1.DataSource = dt1;
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "no found! ";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                grind_Data("spSelectall");//select all data
            }
            else
            {
                grind_Data("spSearch_Grid", "@searchelement");//select data based on text bo
            }
        }
    }
}
