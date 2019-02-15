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
            int numberOfitems = Convert.ToInt32(Console.ReadLine());

            //getting the numbr of elements

            numberOfitems = 2*numberOfitems;

            //doubling the number of elements

            int[] array = new int[numberOfitems]; 

            //creating new array with the number of elements we have got from the console

            for (int i = 0; i!=array.Length; i=i+2) //creating a loop that will go only through even indexes
            {
                string number = Console.ReadLine();

                //creating a variable we are going to use for cloning numbers in the array to the uneven indexes
            
                array[i] = Convert.ToInt32(number);
                
                array[i+1] = Convert.ToInt32(number);
            }

            for (int i = 0; i != array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
