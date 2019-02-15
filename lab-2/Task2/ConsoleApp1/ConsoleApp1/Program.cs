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
            string filePath = @"C:\Code\lab-2\inputTask2.txt"; //path to the input file

            string output = @"C:\Code\lab-2\outputTask2.txt";

            string numbers = File.ReadAllText(filePath); //reading file

            //char[] charArray = numbers.ToCharArray(); //converting string into char array

            string[] numbrs = numbers.Split(' ').ToArray();

            
            
            //Console.WriteLine(numbers);

            bool prime = true;

            List<int> primes = new List<int>();

            
            
            for (int i=0; i<numbrs.Length; i++)
            {
                 int number = Convert.ToInt32(numbrs[i]);

                    for (int j=2; j<number; j++)
                    {
                         if(number%j == 0)
                         {
                            prime = false;             
                         }
                    }
                         if (prime)
                         {
                            primes.Add(number);
                         }
                         prime = true;
            }
            
           

            string str = "";

            foreach (int item in primes)
            {
              Console.WriteLine(item);

              File.WriteAllText(output, item + " " );

              str = str + Convert.ToString(item) + " ";
              
              
            }

           
            File.WriteAllText(output, str);

           

            Console.ReadLine();

        }
    }
}
