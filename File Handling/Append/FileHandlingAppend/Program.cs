using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAppend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\file.txt";
            File.AppendAllText(filePath, "Hello Yashraj");
            Console.WriteLine("File is Appended");
            Console.ReadLine();
        }
    }
}
