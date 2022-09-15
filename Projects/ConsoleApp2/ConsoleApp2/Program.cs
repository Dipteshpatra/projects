using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else statement question here i take the value of i from the user and j i already give a value; 
            //here i write a code to check i and j equal or greater or lesser 
            Console.WriteLine("enter the value of i");
            int i = Convert.ToInt32(Console.ReadLine());
              int  j = 20;

            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");
        }
    }
}
