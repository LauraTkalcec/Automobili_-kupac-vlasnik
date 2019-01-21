using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_objekt
{
    class Kupac: Vlasnik
    {
        public string IBAN;

        public void IspisKupca()
        {
            Console.WriteLine("Kupac vozila je:");
            Console.WriteLine("{0}   {1}  {3}   {4}  ", Ime, Prezime, Adresa, IBAN);
        }
    }
}
