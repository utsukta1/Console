using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Constructor
{
    internal class Construct
    {
        int n = 0;
        int b;
        
         public void Abc()
        {
            Console.WriteLine(n);
        }
        public Construct()
        {
            n = 5;
        }

        public Construct(int e)
        {
            b = e;
        }
        public void Parcons()
        {
            Console.WriteLine(b);
        }



    }
}
