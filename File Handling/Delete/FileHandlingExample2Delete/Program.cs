using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingExample2Delete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delete the File");
            File.Delete("D:\\c and cpp\\Class-Programs-Yashraj\\DotNet\\C#\\Console\\FilesHandlingExample\\FileExample\\firstFile.txt"); // This will Delete File if Exit
            Console.WriteLine("File is Deleted");
            Console.ReadLine();
        }
    }
}
