using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Loop
{
    internal class Loop
    {

        public int i { get; set; }
        public int j { get; set; }
        public void Floop()
    {
        for( i = 1; i <= 2; ++i)
        {
            Console.WriteLine("Outer loop:" + i);
                for(j =1; j<=3; j++)
                {
                    Console.WriteLine("Inner loop :" + j);
                }
        } 
    }
        public void Wloop()
        {
            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void Dwloop()
        {
            do
            {
                Console.WriteLine(i);
                i++;
            } while(i <= 5);
        }
    }
   
}
