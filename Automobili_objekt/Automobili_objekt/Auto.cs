using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_objekt
{
    class Auto
    {
        public string Marka;
        public string Zemlja;
        public int kilometri;

        public void IspisAutomobila()
        {
            Console.WriteLine("{0}, {1}", Marka, Zemlja);
        }
    }
}
