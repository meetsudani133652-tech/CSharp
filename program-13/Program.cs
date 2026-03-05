using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm;
            Console.Write("Enter name : ");
             nm = Console.ReadLine();

            string rvnm = "";
            int i;
            for ( i = nm.Length -1; i >=0; i--)
            {
                rvnm += nm[i];
            }
            if(nm == rvnm)
            {
                Console.WriteLine(" is palindrome !");
            }
            else
            {
                Console.WriteLine("not a palindrome!");
            }

        }
    }
}
