using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int i;
            Console.WriteLine("Enter five numbers : ");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("NUmber" + (j + 1) + ": ");
                nums[j]=int.Parse(Console.ReadLine());
            }

            int max = 0;
            for ( i = 0; i < 5; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("MAx number is : " + max);
        }
    }
}
