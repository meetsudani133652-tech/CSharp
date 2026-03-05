using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age : ");
            int age = int.Parse(Console.ReadLine());

            if (age < 12 && age >0)
            {
                Console.WriteLine("You are Kid");
            }
            else if (age < 20 && age > 12)
            {
                Console.WriteLine("Your are Teenager");
            }
            else if (age <60 && age > 20)
            {
                Console.WriteLine("Your are adult");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Senior citizen");
            }
            else { Console.WriteLine("Invalid age"); }
            }
    }
}
