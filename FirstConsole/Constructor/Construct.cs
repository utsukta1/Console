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
        int c;
        public Construct()
        {
            n = 5;
        }
        
         public void Defcons()
        {
            Console.WriteLine(n);
        }

        public Construct(int e, int f)
        {
            b = e;
            c = f;
        }
        public void Parcons()
        {
            int sum = b + c;
            Console.WriteLine(sum);
        }



    }
}
