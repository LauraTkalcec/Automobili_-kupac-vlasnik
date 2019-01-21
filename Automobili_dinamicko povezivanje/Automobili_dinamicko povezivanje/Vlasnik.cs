using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_dinamicko_povezivanje
{
    class Vlasnik: Osoba
    {
        internal string OIB;
        public string Auto { get; set; }

        public Vlasnik(string ime, string prezime, string OIB): base(ime,prezime, OIB)
        {

        }

        public Vlasnik(string ime, string prezime, string OIB, string Auto): base(ime, prezime, OIB)
        {
            this.Auto = Auto;
        }

        public override string dohvatiIdentifikator()
        {
            return "Oib: " + OIB + " Trazi auto:  " + Auto;;
        }
    }
}
