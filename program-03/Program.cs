using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program of compound interest ");

            Console.WriteLine("Enter value of principle : ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of interest rate : ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of year(s) : ");
            double n = double.Parse(Console.ReadLine());

            double i = p*((1+r)/100);
        double ci =  Math.Pow(i, n);
            Console.WriteLine("Compound Interest is : " + ci);
        }
    }
}
