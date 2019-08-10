using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFolders.Helpers
{
   public class MyFolder
    {
        private static int yers = DateTime.Now.Year;
        private static int month = DateTime.Now.Month;
        private static int days = DateTime.Now.Day;


        public static DirectoryInfo Createfolder()
        {
            if(!Tools.YersExistis())
            {
              return  Directory.CreateDirectory(yers.ToString());
            }
            else if(!Tools.MonthExists())
            {
              return  Directory.CreateDirectory(yers.ToString()+"/"+month.ToString());
            }
            else 
            {
             return   Directory.CreateDirectory(yers.ToString() + "/" + month.ToString()+"/"+days.ToString());
            }
           
           
        }

        public static void Createfolder(string text)
        {
            if (!Tools.YersExistis())
            {
                 Directory.CreateDirectory(yers.ToString());
              
            }
            else if (!Tools.MonthExists())
            {
                 Directory.CreateDirectory(yers.ToString() + "/" + month.ToString());
            }
            else
            {
                string path = yers.ToString() + "/" + month.ToString() + "/" + days.ToString();
                 Directory.CreateDirectory(path);
                MyFiles.WriteFile(path, text);

            }


        }



    }
}
