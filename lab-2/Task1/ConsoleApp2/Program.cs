using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Code\lab-2\inputTask1.txt"; //path to the input file

            string symbols = File.ReadAllText(filePath).ToString(); //reading file

            bool palindrome = true; 

            char[] charArray = symbols.ToCharArray(); //converting string into char array

            Array.Reverse(charArray); //reversing char array

            string reverse = new string(charArray); //making new string equal to the reversed array

            if (symbols != reverse) //if the original string is not equal with the reversed, then bool is false
            {
                palindrome = false;
            }

            if (palindrome)
            {
                Console.WriteLine("Yes");  //if...else in order to output either "Yes" or "No"
            }
            else
            {
                Console.WriteLine("No");
            }           

            Console.ReadLine();


        }
    }
}

