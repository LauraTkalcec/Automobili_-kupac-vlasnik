using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_dinamicko_povezivanje
{
    class Kupac: Osoba
    {
        internal string OIB;

        public Kupac(string ime, string prezime,string OIB):base(ime,prezime,OIB)
        {
           
        }

        public Kupac(string ime, string prezime, string OIB, string Trazi) : base(ime, prezime, OIB)
        {
            this.OIB = OIB;
            this.Trazi = Trazi;
        }

        string Trazi { get; set; }

        public override string dohvatiIdentifikator()
        {
            return "Oib: " + OIB + " Trazi auto:  "+Trazi;
        }
    }
}
