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
                nums[j] = int.Parse(Console.ReadLine());
            }

            int min = nums[0];
            for (i = 0; i < 5; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("Min number is : " + min);
        }
    }
}
