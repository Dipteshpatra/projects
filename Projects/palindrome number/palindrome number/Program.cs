using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r,t, s = 0;
            Console.WriteLine("enter the number to check");
            n=Convert.ToInt32(Console.ReadLine());
            t = n;
            while(n>0)
            {
                r = n % 10;
                s=s+r;
                n = n % 10;
            }
            if (t == s)
                Console.WriteLine("the number is pallindrome");
            else
                Console.WriteLine("the number is not pallindrome");

        }
    }
}
