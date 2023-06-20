using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class WebForm8 : System.Web.UI.Page, System.Web.UI.ICallbackEventHandler
    {
        private string _callback = null;
        private static Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            string callbackRef = Page.ClientScript.GetCallbackEventReference(this, "args", "getNumberServer", "context");
            string script = "function useCallback(args, context) { " + callbackRef + " }";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "useCallback", script, true);
        }

        public void RaiseCallbackEvent(string eventArgument)
        {
            _callback = random.Next(1,10).ToString();

        }

        public string GetCallbackResult()
        {
            return _callback;
        }
    }
}
