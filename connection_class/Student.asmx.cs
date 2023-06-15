 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace connection_class
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
         [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public student getStudents(int id)
        {
            student std = new student();
            string con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection _con = new SqlConnection(con);
            _con.Open();
            SqlCommand cmd = new SqlCommand("spSelectAllStudent", _con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter para = new SqlParameter("@inputid", id);
            cmd.Parameters.Add(para);
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                std.Id = Convert.ToInt32(reader["id"]);
                std.Name = Convert.ToString(reader["name"]);
                std.Gender = reader["Gender"].ToString();
                std.TotalMarks = Convert.ToInt32(reader["TotalMarks"]);
            }
            return std;
        }
    }
}
