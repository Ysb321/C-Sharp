using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInfo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Drive Info Program");
            DriveInfo[] Drives = DriveInfo.GetDrives();
            int drivesCount = Drives.Count();
            Console.WriteLine(drivesCount);
            int numDirs=0;

            foreach (DriveInfo drive in Drives)
            {
                numDirs++;
                Console.WriteLine();
                string[] dirs = Directory.GetDirectories(drive.ToString());
                int dirCount = dirs.Count();
                Console.WriteLine($"Drive Number {numDirs} is {drive}");
                Console.WriteLine($"Number of Directories are {dirCount}");
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
