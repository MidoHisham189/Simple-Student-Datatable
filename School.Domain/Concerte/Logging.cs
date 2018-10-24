using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace School.Domain.Concerte
{
   public class Logging
    {
        public static void log(Exception ex)
        {

            string strPath = System.Web.HttpContext.Current.Server.MapPath("myLog.txt");

            FileStream fs = new FileStream(strPath, FileMode.Append, FileAccess.Write);
            StreamWriter swr = new StreamWriter(fs);
            swr.Write("Enter ur Exception Here");
            swr.Close();
        }
    }
}
