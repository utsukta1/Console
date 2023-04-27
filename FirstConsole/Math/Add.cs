using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Math
{
    internal class Add
    {   
        public void Addition()
        {
            Console.WriteLine("Enter a number a: ");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("The sum of " + a + "and" + b + "is: " + sum);       
        }

        public void Subtraction()
        {
            Console.WriteLine("Enter the first number: ");
            int c= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int d= Convert.ToInt32(Console.ReadLine());
            int diff = c - d;
            Console.WriteLine("The difference of " + c + "and " + d + "is: " + diff);
                
        }


    }
}
