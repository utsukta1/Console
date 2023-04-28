using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstConsole.Math
{
    internal class Area
    {
        
        
        double area;
        public void Aofcircle()
        {
            Console.WriteLine("Enter the radius of the circle:");
            int r = Convert.ToInt32(Console.ReadLine());
            area = 2 * 3.14 * r*r;
            Console.WriteLine("The area of circle is: " +area);
        }

        public void Aofrect()
        {
            Console.WriteLine("Enter the length and breadth of the rectangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("The area of rectangle is: " + area);
        }
    }
}
