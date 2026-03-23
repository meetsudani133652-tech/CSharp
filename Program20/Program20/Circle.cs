using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Circle
    {
        int r;
        double area;
        public void Getdata()
        {
            Console.WriteLine("Enter Radius:-");
            r = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            area = 3.16 * r * r;
        }
        public void Display()
        {
            Console.WriteLine("Area=  " + area);
        }
    }
}
