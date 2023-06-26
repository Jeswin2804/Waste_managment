using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace connection_class
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            detais newdet = new detais()
            {
                name = "jeswin",
                description = "dev",
                id = 1
            };
            XmlSerializer serObj = new XmlSerializer(typeof(detais));
            StreamWriter newWrit = new StreamWriter(@"D:\\Waste_management\newxml.xml");
            serObj.Serialize(newWrit, newdet);
            newWrit.Close();    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serObj = new XmlSerializer(typeof(detais));
            StreamReader rdr = new StreamReader(@"D:\\Waste_management\newxml.xml");
            detais bckdet = (detais)serObj.Deserialize(rdr);
            TextBox1.Text = bckdet.id.ToString();
            TextBox2.Text = bckdet.name.ToString();
            TextBox3.Text = bckdet.description.ToString();

        }
    }
    public  class detais
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }
    }
}