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
            string fileName = "MoveFile.txt"; //filename

            string path = @"C:\Code\lab-2"; //origin path

            string movePath = @"C:\Code\lab-1"; //path to copy

            string sourceFile = Path.Combine(path, fileName); //combines filename and path 
            
            File.Create(sourceFile); //creating a file

            //File.Copy(sourceFile, movePath, true); //copying it

            File.Delete(sourceFile); //deleting a file

            Console.ReadLine();
        }
    }
}
