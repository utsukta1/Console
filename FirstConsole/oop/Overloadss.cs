using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.oop
{
    internal class Overloadss
    {
        public void Areas(int h, int j)
        {
            Console.WriteLine("The area of rectangle is: " + (h*j));
        }
        public void Areas(int ra)
        {
            Console.WriteLine("The area of circle is: " + (2*3.14*ra*ra));
        }
    }
}
