using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using folderLibrary;

namespace DirectoryExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "D:\\c and cpp\\C-Sharp\\folder";

            if (folder.CheckExist(folderPath))
            {
                folder.DeleteFolder(folderPath);
                Console.WriteLine("Directory is Deleted");
            }
            else
            {
                folder.CreateFolder(folderPath);
                Console.WriteLine("Directory is Created");
            }

            Console.ReadLine();
        }
    }
}
