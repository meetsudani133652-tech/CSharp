using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program of simple interest ");
            Console.WriteLine("Enter value of principle : ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of interest rate : ");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of year(s) : ");
            double n = double.Parse(Console.ReadLine());

            double si = (p * rate * n)/100;

            Console.WriteLine("Simple Interest is : " + si);
        }
    }
}
