using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class recursive_function_call_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        
        }

        private int add(int i)
        {
            if (i <= 0) { 

            return 0;

            }
            else
            {
                int num = new int();
                if (i > num)
                {
                    return i + add(i - 1);
                }
                else
                {
                    return i;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = add(int.Parse(TextBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message+ " Enter an integer";
            }
        }
    }
}