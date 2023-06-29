using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Text;

namespace connection_class
{
    public partial class recursive_function : System.Web.UI.Page
    {
        string childName;
        string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateTreeView();
            }
        }
        private void PopulateTreeView()
        {
            try
            {
                childName = "frank";
                connectionString = ConfigurationManager.ConnectionStrings["localConnection1"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("sp_getAncestors", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@child", childName);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                TreeNode rootNode = null;
                if (reader.Read())
                {
                    string ancestorName = reader["p"].ToString();
                    rootNode = new TreeNode(ancestorName);
                    treeView.Nodes.Add(rootNode);

                    PopulateChildNodes(rootNode, reader);
                }
                reader.Close();
            }catch (Exception ex)
            {

            }
            finally
            {
                childName = null;
                connectionString = null;
            }
        }

        private void PopulateChildNodes(TreeNode parentNode, SqlDataReader reader)
        {
            if (reader.Read())
            {
                
                string ancestorName = reader["p"].ToString();
                TreeNode node = new TreeNode(ancestorName);
                parentNode.ChildNodes.Add(node);
                PopulateChildNodes(node, reader);
            }
        }

    }
}

