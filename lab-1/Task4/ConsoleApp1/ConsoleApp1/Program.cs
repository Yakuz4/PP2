using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "[*]"; //the symbol itself

            int number = Convert.ToInt32(Console.ReadLine()); //number of lines

            int amountOfsymbols; //the counter I'm going to use for outputting the right amount of stars on each line

            for (int i = 1; i <= number; i++)
            {
                amountOfsymbols = 1;

                while (amountOfsymbols <= i)
                {

                    Console.Write(symbol);

                    amountOfsymbols++;

                }

                Console.WriteLine("\t"); //this is used to divide symbols into new lines
            }

            Console.ReadLine();
        }
    }
}
