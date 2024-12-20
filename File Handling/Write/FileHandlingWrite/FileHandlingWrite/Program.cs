using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\file.txt";
            File.WriteAllText(filePath, "Hello World");
            Console.WriteLine("File Write Sucessfully");
            Console.ReadLine();
        }
    }
}
