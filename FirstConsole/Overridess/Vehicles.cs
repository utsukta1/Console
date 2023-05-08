using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstConsole.Overridess
{
    internal class Vehicles
    {
        public virtual void Wheels()
        {
            Console.WriteLine(" Vehicle has wheels!");
        }
    }
}
