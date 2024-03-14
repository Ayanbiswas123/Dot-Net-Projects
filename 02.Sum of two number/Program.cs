using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_of_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            Console.WriteLine("Enter The Value Of A & B = ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("The Sum of " + a + " And " + b + " is = " + c);
            Console.ReadLine();
        }
    }
}
