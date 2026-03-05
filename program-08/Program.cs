using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = i * fact;
            }
            Console.WriteLine("Factorial of given number : " + fact);
        }
    }
}
