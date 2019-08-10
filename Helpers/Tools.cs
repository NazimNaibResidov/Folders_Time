using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFolders.Helpers
{
   public class Tools
    {
        private static int yers = DateTime.Now.Year;
        private static int month = DateTime.Now.Month;
        private static int days = DateTime.Now.Day;
        public static bool YersExistis()
        {
            return Directory.Exists(MyPath.GetFolderPath());
        }
        public static bool MonthExists()
        {
            return Directory.Exists(MyPath.GetFolderPath());
        }
        public static bool DaysExists()
        {
            return Directory.Exists(MyPath.GetFolderPath());
        }
        public static byte[] GetBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

    }
}
