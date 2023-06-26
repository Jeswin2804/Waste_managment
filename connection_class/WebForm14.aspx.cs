using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/emp.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }catch (Exception ex)
            {
                exeptionLogging.sendError(ex);
                Label1.Text = "error";
            }
        }
    }
}