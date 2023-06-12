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
    public partial class Grid_paging : System.Web.UI.Page
    {
        string con;
        DataTable dt;
        string DESCENDING = " DESC";
        string ASCENDING = " ASC";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindgrind();
            }
        }
        //databind
        protected void Bindgrind()
        {
            con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select_details", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            ViewState["paging"] = ds;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        //paging
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = ViewState["paging"];
            GridView1.DataBind();
        }
        //sorting
        protected SortDirection CurrentSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                {
                    ViewState["sortDirection"] = SortDirection.Ascending;
                }
                return (SortDirection)ViewState["sortDirection"];
            }
            set
            {
                ViewState["sortDirection"] = value;
            }
        }
        //sorting
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string ColumnTosort = e.SortExpression;

            if (CurrentSortDirection == SortDirection.Ascending)
            {
                CurrentSortDirection = SortDirection.Descending;
                sortGridview(ColumnTosort, ASCENDING);
            }
            else
            {
                CurrentSortDirection = SortDirection.Ascending;
                sortGridview(ColumnTosort, DESCENDING);

            }
        }

        private void sortGridview(string sortExpression, string direction)
        {
            dynamic dt = ViewState["paging"];
            DataTable dtsort = dt;
            DataView dtv = new DataView(dtsort);
            dtv.Sort = sortExpression + direction;
            GridView1.DataSource = dtv;
            GridView1.DataBind();

        }
    }
}