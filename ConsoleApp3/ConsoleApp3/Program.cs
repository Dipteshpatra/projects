using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[10];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
          
            Console.WriteLine("secod largest number in the array:"+arr[1]);
        }
    }
}
