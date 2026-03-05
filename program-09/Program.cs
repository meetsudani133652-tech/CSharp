using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numner : ");
            int num = int.Parse(Console.ReadLine());
            double n1 = 0;
            double n2 = 1;
            Console.Write(n1 + " ");
            Console.Write(n2);
            double fibbo = 0;
            for (int i = 0; i < num;i++)
            {
                fibbo = n1 + n2;
                if (fibbo<=num)
                {
                    Console.Write(" " + fibbo);
                }
               
                n1 = n2;
                n2=fibbo;
            }
            Console.WriteLine("");
        }
    }
}
