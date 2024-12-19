using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create File Example");
            string filePath = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\fileTxt.txt";
            string contentRead = File.ReadAllText(filePath);
            Console.WriteLine(contentRead);
            Console.WriteLine("File Create and Write");
            Console.ReadLine();
        }
    }
}
