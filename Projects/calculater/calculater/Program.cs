using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dig;
            int first, second;
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for substraction");
            Console.WriteLine("Enter 3 for multiplicaton");
            Console.WriteLine("Enter 4 for divison");
            dig = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two operands: ");
            first=Convert.ToInt32(Console.ReadLine());
            second=Convert.ToInt32(Console.ReadLine()); 

            switch (dig)
            {
                case 1:
                    Console.WriteLine("addition:"+(first + second));
                    break;
                case 2:
                    Console.WriteLine("substraction:"+(first - second));
                    break;
                case 3:
                    Console.WriteLine("Multiplication:"+(first * second));
                    break;
                case 4:
                    Console.WriteLine("divison:" +(first / second));
                    break;
                // operator doesn't match any case constant
                default:
                   Console.WriteLine("Error! operator is not correct");
                    break;
           
        }
    }
    }
}
