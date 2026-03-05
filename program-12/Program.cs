using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            int m;
            int sum = 0;
            while (n>=0)
            {
                m = n % 10;
                n = n / 10;
                sum = sum + m;
            }
            Console.WriteLine("Sum : " + sum);
        }
    }
}
