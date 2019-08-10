using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFolders.Helpers
{
   public class MyFiles
    {
        private static FileStream FileCreate(string path)
        {
            return File.Create(path+"/"+"Main.txt");

        }
        public static void WriteFile(string path,string text)
        {
            var stream= FileCreate(path);
            stream.Write(Tools.GetBytes(text), 0, text.Length);
            stream.Close();
        }
    }
}
