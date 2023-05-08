using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Overridess
{
    internal class Bike : Vehicles
    {
        public override void Wheels()
        {
            Console.WriteLine("Bike has wheels.");
        }
    }
}
