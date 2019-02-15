using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Code";

            string[] dirs = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string dir in dirs)
                {
                Console.WriteLine(Path.GetFullPath(dir));
                }
               
       

            Console.ReadLine();
        
        }
    }
}
