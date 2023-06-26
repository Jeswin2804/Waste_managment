using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace connection_class
{

    public partial class serialize_deserialise : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cookieName"];
            if (cookie != null)
            {
                Label1.Text +="this data from another page using cookie in c#"; 
                Label1.Text += cookie.Value + "</br>";
               
            }
        }
        [WebMethod]
        public static string getData()
        {
            Details det1 = new Details
            {
                id = 1,
                name = "sunapi",
                job = "nill"
            };

            Details det2 = new Details
            {
                id = 2,
                name = "ebin",
                job = "nill"
            };
            List<Details> list = new List<Details>();
            list.Add(det1);
            list.Add(det2);
            JavaScriptSerializer jsc = new JavaScriptSerializer();
            string json = jsc.Serialize(list);
            return json;
        }
        [WebMethod]

        public static List<Details> getData1(string args)
        {
            string ret = args;
          //  ret =  args.Replace("\"", "/\"");
            List<Details> list = JsonConvert.DeserializeObject<List<Details>>(ret);
            return list;
        }
    }
     
    public  class Details
    {
        public int id { get; set; }
        public string name { get; set; }
        public string job { get; set; }

    
    }
}