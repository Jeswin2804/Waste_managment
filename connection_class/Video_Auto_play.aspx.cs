using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace connection_class
{
    public partial class Video_Auto_play : System.Web.UI.Page
    {
        string[] allowedExtensions = { ".mp4", ".webm", ".mpeg" };
        protected void Page_Load(object sender, EventArgs e)
        {

            videoContainer.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                Label1.Text = "";
                string fname = FileUpload1.FileName;
                string extension = Path.GetExtension(fname);
                if (allowedExtensions.Contains(extension.ToLower()))
                {
                    videoContainer.Visible = true;
                    string file = Server.MapPath("~/uploads/");
                    string filePath = Path.Combine(file, fname);
                    FileUpload1.SaveAs(file + fname);
                    myVideo.Src = "\\uploads\\" + fname;
                }
                else
                {
                    FileUpload1.Dispose();
                    Label1.Text = "invalid upload";
                }
            }
        }
    }
}