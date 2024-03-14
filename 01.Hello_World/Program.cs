using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
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
