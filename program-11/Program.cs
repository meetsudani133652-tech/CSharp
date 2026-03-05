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
            Console.WriteLine("Enter starting number :  ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number :  ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int i;
            int j;

            for ( i = n1; i <= n2 ; i++)
            {
                for(j=2; j<i;j++)
                {
                    if (i%j == 0)
                    { 
                        break;
                    }
                    else if (j==n1)
                    {
                        Console.WriteLine(i);
                        break;
                    }

                }
            }
           

        }
    }
}

