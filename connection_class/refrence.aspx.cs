using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using details;


namespace connection_class
{
    public partial class refrence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            details.Class1 obj = new  details.Class1();
            double x = 10;
            double y = 20;
            double z= obj.Addition(x, y);
        }
    }
}