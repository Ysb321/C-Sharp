using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folderLibrary
{
    public static class folder
    {
        public static bool CheckExist(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CreateFolder(string folderPath)
        {
            if (!CheckExist(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                Console.WriteLine("Folder is Already Exist");
            }
        }

        public static void DeleteFolder(string folderPath)
        {
            if (CheckExist(folderPath))
            {
                Directory.Delete(folderPath);
            }
            else
            {
                Console.WriteLine("Folder is Not Exist to Delete.");
            }
        }
    }
}
