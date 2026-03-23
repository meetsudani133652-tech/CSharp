using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Getdata();
            r.Calculate();
            r.Display();

            
            Circle c = new Circle();
            c.Getdata();
            c.Calculate();
            c.Display();
        }
    }
}
