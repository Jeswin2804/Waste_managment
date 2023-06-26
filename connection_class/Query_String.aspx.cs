using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Query_String : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/welcome_page.aspx?first=" + TextBox1.Text + "&last=" + TextBox2.Text);

        }
    }
}