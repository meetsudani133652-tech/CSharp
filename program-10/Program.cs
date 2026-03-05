using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check prime : ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for ( i = 2; i < n; i++)
            {
                if (n == 0 || n==1 )
                {
                   Console.WriteLine("Enter number again");
                }
                else
                {
                    if (n% i == 0)
                    {
                        Console.WriteLine("NUmber is Not prime");
                        return;
                    }
                   
                }

            }
            
            if (i== n)
            {
                Console.WriteLine("Number is prime");
            }
        }
    }
}
