using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOfitems = Console.ReadLine();

            int arraysize = Convert.ToInt32(numberOfitems);

            int[] numbrs = new int[arraysize];

            for (int i=0; i<arraysize; i++)
            {
                numbrs[i] = Convert.ToInt32(Console.ReadLine());
            }

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
            

           foreach (int item in primes)
            {
              Console.WriteLine(item);
              
              
            }
            

            Console.ReadLine();


        }
    }
}
