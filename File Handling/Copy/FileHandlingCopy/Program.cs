using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\fileTxt.txt";
            string filePath2 = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\fileTxt2.txt";

            if (File.Exists(filePath))
            {
                File.Copy(filePath, filePath2, true);
                
                Console.WriteLine("File is Copied");
            }
            Console.ReadLine();


        }
    }
}
