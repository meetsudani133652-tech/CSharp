using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
           double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is EVEN!");
            }
            else { Console.WriteLine("Number is ODD!"); }
        }
    }
}
