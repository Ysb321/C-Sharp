using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Date of File");
            string filePath = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\fileTxt.txt";

            FileInfo fileInfo = new FileInfo(filePath);
            DateTime createdDate = fileInfo.CreationTime;
            DateTime modifiedDate = fileInfo.LastAccessTime;
            DateTime lastWriteDate = fileInfo.LastWriteTime;


            Console.WriteLine("Created Date : " + createdDate);
            Console.WriteLine("Modified Date : " + createdDate);
            Console.WriteLine("Last Write Date : " + lastWriteDate);
            Console.ReadLine();



        }
    }
}
