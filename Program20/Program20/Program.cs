using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Rectangle
    {
        int l, w, area;
        public void Getdata()
        {
            Console.WriteLine("Enter Length:-");
            l =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:-");
            w =int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            area = l * w;
        }
        public void Display()
        {
            Console.WriteLine("Area= "+area);
        }
    }
}
