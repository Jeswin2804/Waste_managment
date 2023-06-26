using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace connection_class
{
    public partial class DataTable_to_JSON : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //cookie
            HttpCookie myCookie = new HttpCookie("cookieName");
            myCookie.Value = DataTableToJsonWithJsonNet();
            Response.Cookies.Add(myCookie);
            DataTableToJsonWithJsonNet();
            //session
            Session["sessionData"] = DataTableToJsonWithJsonNet();
        }
        [WebMethod]
        public static string call()
        {
            return JSONData(getData);
        }


        public static DataTable getData()
        {
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection con = new SqlConnection(_con);
            SqlCommand cmd = new SqlCommand("spSelectTable",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static string JSONData(Func<DataTable> dt)
        {
            DataTable _dt = dt();
            var jsonString = new StringBuilder();
            if (_dt.Rows.Count > 0)
            {
                jsonString.Append("[");
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    jsonString.Append("{");
                    for (int j = 0; j < _dt.Columns.Count; j++)
                    {
                        if (j < _dt.Columns.Count - 1)
                        {
                            jsonString.Append(
                                "\"" + _dt.Columns[j].ToString() + "\":" + "\"" + _dt.Rows[i][j].ToString() + "\","
                            );
                        }
                        else if (j == _dt.Columns.Count - 1)
                        {
                            jsonString.Append(
                                "\"" + _dt.Columns[j].ColumnName.ToString() + "\":" + "\"" + _dt.Rows[i][j].ToString() + "\""
                            );
                        }
                    }
                    jsonString.Append("}");
                    if (i != _dt.Rows.Count - 1)
                    {
                        jsonString.Append(",");
                    }
                }
                jsonString.Append("]");
            }

            return jsonString.ToString();
        }

        [WebMethod] 
        public static string javaScriptSerializer()
        {
            DataTable dt = getData();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            foreach (DataRow row in dt.Rows)
            {
                Dictionary<string, object> childRow = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return serializer.Serialize(parentRow);
        }

        [WebMethod]
        //json on net
        public static string DataTableToJsonWithJsonNet()
        {
    
            DataTable dt = getData();
            string jsonString;
            jsonString = JsonConvert.SerializeObject(dt);
            return jsonString;

        }
        //this data is in json format 
        [WebMethod]
        public static string datafromJson()
        {
            string _con = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
            SqlConnection con = new SqlConnection(_con);
            con.Open();
            SqlCommand cmd = new SqlCommand("spSelectAllDataInJSON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string json = cmd.ExecuteScalar().ToString();
            return json;
        }
    }
}
