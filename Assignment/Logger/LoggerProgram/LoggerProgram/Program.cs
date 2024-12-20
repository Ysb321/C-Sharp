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
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            Logg.Info("Hello World", folderPath);
            Logg.Debug("Hello World", folderPath);
            Logg.Error("Hello World", folderPath);
        }
    }
}
