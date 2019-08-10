using CreateFolders.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFolders.Core
{
   public class Mains
    {
        public static void CreateFolder(string text)
        {
            MyFolder.Createfolder(text);
        }
        public static void CreateFolder()
        {
            MyFolder.Createfolder();
        }
    }
}
