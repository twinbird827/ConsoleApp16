using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //var s2 = Path.Combine(s1, "test");
            //var s3 = Path.Combine(s2, "test.txt");

            //Directory.CreateDirectory(s2);

            //while (true)
            //{
            //    File.AppendAllText(s3, "a");
            //    Console.ReadLine();
            //}
            var file = @"C:\Temp\test\test.txt";
            File.Delete(file);
        }
    }
}
