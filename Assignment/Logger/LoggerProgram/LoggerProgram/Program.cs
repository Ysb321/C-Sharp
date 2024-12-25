using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace LoggerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "D:\\c and cpp\\C-Sharp\\example";
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                Logg.Info("Hello World", folderPath);
            }catch (Exception ex)
            {
                Logg.Error(ex.Message, folderPath);
            }
            finally
            {
                Console.ReadLine();
            }            
        }
    }
}
