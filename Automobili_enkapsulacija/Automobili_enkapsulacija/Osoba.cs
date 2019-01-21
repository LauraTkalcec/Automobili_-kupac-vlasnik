using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_enkapsulacija
{
    class Osoba
    {
        private string Ime;
        private string Prezime;
        private string OIB;

        
        public void ZadajIme(string Ime)
        {
            this.Ime = Ime;
        }

        public string VratiIme()
        {
            return Ime;
        }

      
        public void ZadajPrezime(string Prezime)
        {
            this.Prezime = Prezime;
        }

        
        public string VratiPrezime()
        {
            return Prezime;
        }

        
        public void ZadajOIB(string OIB)
        {
            this.OIB = OIB;
        }

        public string VratiOIB()
        {
            return OIB;
        }

        public void ispisOsoba()
        {
            Console.WriteLine("{0}, {1}", Ime, Prezime);
        }
    }
}

