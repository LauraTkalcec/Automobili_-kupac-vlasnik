using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_objekt
{
    class Vlasnik
    {
        public string Ime;
        public string Prezime;
        public string Adresa;

        public void IspisVlasnika()
        {
            Console.WriteLine("Vlasnik vozila je:");
            Console.WriteLine("{0}   {1}  {3}", Ime, Prezime, Adresa);
        }
    }
}
