using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of circle");

            Console.WriteLine("Enter value of radius");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.1416;
            double area = pi * r * r;
            Console.WriteLine("Area of circle is : " + area);
        }
    }
}
