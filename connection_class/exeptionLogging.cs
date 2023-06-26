using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using connection_class;
using context = System.Web.HttpContext;

namespace connection_class
{
    
    public class exeptionLogging
    {
        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;
        public static  void sendError(Exception ex)
        {
            var line = Environment.NewLine + Environment.NewLine;
            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
            Errormsg = ex.GetType().Name.ToString();
            exurl = context.Current.Request.Url.ToString();
            ErrorLocation = ex.Message.ToString();

            try
            {
                string filepath = context.Current.Server.MapPath("~/study/exeption");
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath += DateTime.Today.ToString("dd/mm/yyyy");
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    string error = "Log Written Date:" + " " + DateTime.Now.ToString() + line + "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line + "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation + line + " Error Page Url:" + " " + exurl + line + "User Host IP:" + " " + hostIp + line;
                    sw.WriteLine("Exception Details on " + " " + DateTime.Now.ToString() );
                    sw.WriteLine(line);
                    sw.WriteLine(error);
                    sw.WriteLine(line);
                    sw.Flush();
                    sw.Close();

                }

            }
            catch(Exception e)
            {
                e.ToString();
            }

        }
    }
}