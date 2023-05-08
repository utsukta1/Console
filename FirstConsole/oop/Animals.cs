using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstConsole.oop
{
    internal class Animals : Mammals, Reptiles
    {
       public string Utsukta(string name)
        {
            return "The name is: " + name;
        }
        public string Snake(string family)
        {
            return "The family is: " + family;
        } 
    }
}
