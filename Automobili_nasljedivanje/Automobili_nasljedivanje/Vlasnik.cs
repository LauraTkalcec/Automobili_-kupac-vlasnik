using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_nasljedivanje
{
    class Vlasnik : Osoba
    {
        internal string Trazi;

        public string JMBAG { get; set; }

        public Vlasnik(): base()
        {
            
        }

        public Vlasnik(string ime, string prezime, string oib) : base()
        {

        }

        public Vlasnik(string ime, string prezime, string oib, string JMBAG) : base()
        {
            this.JMBAG = JMBAG;
        }
    }
}
