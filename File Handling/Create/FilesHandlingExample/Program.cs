using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // we have to use this namespace

namespace FilesHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File path is manditory
            Console.WriteLine("File Create Example");
            File.Create("D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\firstFile.txt");
            Console.WriteLine("File Created");
            Console.ReadLine();
        }
    }
}
