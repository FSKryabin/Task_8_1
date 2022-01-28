using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:/Task8_1";
            if (Directory.Exists(dir))
            {
                string[] dirs = Directory.GetDirectories(dir);
                foreach (string s in dirs)
                {
                    Console.WriteLine("Подкоталоги:");
                    Console.Write(s);
                    string[] dirs1 = Directory.GetDirectories(s);
                    foreach (string s1 in dirs1)
                    {
                        Console.WriteLine("/t" + s1);
                    }
                    string[] files1 = Directory.GetFiles(s);
                    Console.WriteLine();
                    foreach (string sf1 in files1)
                    {
                        Console.WriteLine("\t" + sf1);
                    }
                    Console.WriteLine();

                }
                string[] files = Directory.GetFiles(dir);
                Console.WriteLine("Файлы:");
                foreach (string sf in files)
                {
                    Console.WriteLine("\t" + sf);
                }
            }
        }
    }
}
