using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rev=0;
            Console.Write("enter number : ");
            int num  = int.Parse(Console.ReadLine());
            
            while (num>0)
            {
               int m = num % 10;
                rev = rev * 10 + m;
                num = num / 10;
            }
            Console.WriteLine(rev);
            if(num == rev)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("Not");
            }

        }
    }
}
