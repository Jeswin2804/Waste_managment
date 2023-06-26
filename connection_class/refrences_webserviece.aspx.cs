using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.WebService3SoapClient client = new ServiceReference1.WebService3SoapClient();
            int res = client.add(1, 2);
            Label1.Text = res.ToString();

        }
    }
}