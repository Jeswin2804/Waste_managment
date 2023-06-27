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
            try
            {
                string directoryPath = Server.MapPath("~/Waste_management");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                detais newdet = new detais()
                {
                    name = TextBox1.Text,
                    description = TextBox2.Text,
                    id = int.Parse(TextBox3.Text)
                };

                XmlSerializer serObj = new XmlSerializer(typeof(detais));
                string xmlFilePath = Path.Combine(directoryPath, "newxml.xml");
                using (StreamWriter newWrit = new StreamWriter(xmlFilePath))
                {
                    serObj.Serialize(newWrit, newdet);
                }

                string xmlCont = File.ReadAllText(xmlFilePath);
                xmlCont = Server.HtmlEncode(xmlCont); // change to xml Struct
                xmlCont = "<pre>" + xmlCont + "</pre>"; 
                XmlLiteral.Text = xmlCont;
            }
            catch (Exception ex)
            {
              
            }
        }




        protected void Button2_Click(object sender, EventArgs e)
        {
            string xmlFilePath = Server.MapPath("~/Waste_management/newxml.xml");
            if (File.Exists(xmlFilePath))
            {
                XmlSerializer serObj = new XmlSerializer(typeof(detais));
                using (StreamReader rdr = new StreamReader(xmlFilePath))
                {
                    detais bckdet = (detais)serObj.Deserialize(rdr);
                    TextBox1.Text = bckdet.id.ToString();
                    TextBox2.Text = bckdet.name.ToString();
                    TextBox3.Text = bckdet.description.ToString();
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "AlertScript", "File invalid", true);
            }
        }


    }
    public class detais
    {
        public string name { get; set; }
        public string description { get; set; }
        public int id { get; set; }
    }
}