using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Logg
    {
        public static string fileType = "\\Log_";
        public static void Info(string message, string folderName)
        {
            if(Directory.Exists(folderName))
            {
                DateTime dateTime = DateTime.Now;
                string formattedDateTime = dateTime.ToString("yyyy-MM-dd");
                string filePath = Path.Combine(folderName + fileType + formattedDateTime + ".txt");
                string extraLines = fileType + DateTime.Now + "\n" + "\n" + message + "\n" + "\n";
                File.AppendAllText(filePath, extraLines);
                Console.WriteLine("Log File Created");
            }
            else
            {
                Console.WriteLine("Folder Doesn't Exist");
            }
        }

        public static void Debug(string message, string folderName)
        {
            fileType = "\\Debug_";
            Info(message, folderName);
            Console.WriteLine("This is Debug Message");
        }

        public static void  Error(string message, string folderName)
        {
            fileType = "\\Error_";
            Info(message, folderName);
            Console.WriteLine("This is Error Message");
        }
    }
}
