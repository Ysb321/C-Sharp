using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace test8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string folderPath = "D:\\new";
                string desPath = "D:\\new2";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string parentDirectory = Path.GetDirectoryName(desPath);
                if (!Directory.Exists(parentDirectory))
                {
                    Directory.CreateDirectory(parentDirectory);
                }
                Directory.Move(folderPath, desPath);
                Console.WriteLine($"Directory Content of {folderPath} moved to {desPath}");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
                
        }
    }
}
