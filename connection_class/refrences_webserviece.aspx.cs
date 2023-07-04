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
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.WebService3SoapClient client = new ServiceReference1.WebService3SoapClient();
                int t1 = int.Parse(TextBox1.Text);
                int t2 = int.Parse(TextBox2.Text);
                int res = client.add(t1, t2);
                Label1.Text = res.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

//BUTTON_CLICK-------->WEB_SERIVICE_3------>WEB_REFRENCES-*