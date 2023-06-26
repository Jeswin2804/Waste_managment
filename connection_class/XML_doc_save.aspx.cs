using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace connection_class
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        XmlDocument xmldoc = new XmlDocument();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         private void showData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("xml_dem1.xml"));
            if(ds.Tables.Count > 0 )
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            xmldoc.Load(Server.MapPath("xml_dem1.xml"));
            XmlElement parentElement = xmldoc.CreateElement("Users");
            XmlElement name = xmldoc.CreateElement("Name");
            name.InnerText = TextBox1.Text;
            XmlElement email = xmldoc.CreateElement("Email");
            email.InnerText = TextBox2.Text;
            XmlElement city = xmldoc.CreateElement("City");
            city.InnerText = TextBox3.Text;
            XmlElement date = xmldoc.CreateElement("Date");
            date.InnerText = DateTime.Now.ToString();
            
            parentElement.AppendChild(name);
            parentElement.AppendChild(email);
            parentElement.AppendChild(city);
            parentElement.AppendChild(date);
            xmldoc.DocumentElement.AppendChild(parentElement);

            xmldoc.Save(Server.MapPath("xml_dem1.xml"));
            showData();
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            //xpath:-
            XmlNode cityEnakulam = xmldoc.SelectSingleNode("/UserInformation/Users/City[text()='ernakulam']");

            TextBox4.Text = cityEnakulam.InnerText;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

         
        }
    }
}