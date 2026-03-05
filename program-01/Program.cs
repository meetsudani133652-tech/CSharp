using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program of arithmetis!");
            double a= double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());

            double c = a*b;
            double d = a+b;
            double e = a-b;
            double f = a/b;

            Console.WriteLine("Addition is : "+ d);
            Console.WriteLine("Substraction is : " + e);
            Console.WriteLine("Multiplication is : " + c);
            Console.WriteLine("Division is :  " + f);

        }
    }
}
