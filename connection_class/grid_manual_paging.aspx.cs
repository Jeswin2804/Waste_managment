using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace connection_class
{
    public partial class grid_manual_paging : System.Web.UI.Page
    {
        int _totalcount;
        protected void Page_Load(object sender, EventArgs e)
        {
            bind(1, 10, out _totalcount);
            addingButton();
        }
        private void bind(int pageNO, int row, out int _totalcount)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spPagination", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageno", pageNO);
                cmd.Parameters.AddWithValue("@noofRecord", row);
                cmd.Parameters.AddWithValue("@RowCount", 0);
                SqlParameter totalcount = new SqlParameter("@totalCount", SqlDbType.Int);
                totalcount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(totalcount);
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    int toctalcount = Convert.ToInt16(int.TryParse(ds.Tables[1].Rows[0]["totalcount"].ToString(), out _totalcount));

                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                }
                else
                {
                    _totalcount = 0;
                }
            }

            catch (Exception ex)
            {
                _totalcount = 0;
            }

        }
        private void addingButton()
        {
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.ID = "btn_" + (i + 1);
                btn.CommandArgument = (i + 1).ToString(); ;
                btn.Click += new EventHandler(btn_Click);
                Panel1.Controls.Add(btn);
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            string pageNo = ((Button)sender).CommandArgument;
            bind(Convert.ToInt32(pageNo), 10, out _totalcount);
        }
    }

}