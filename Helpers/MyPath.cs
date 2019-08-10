using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFolders.Helpers
{
   public class MyPath
    {
        public static string GetFolderPath()
        {
           
            return Path.GetFullPath(Environment.CurrentDirectory + "../../");
        }
        public static string GetFolderNameWithPath(string folders)
        {
           
            return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../", folders));
        }
    }
}
