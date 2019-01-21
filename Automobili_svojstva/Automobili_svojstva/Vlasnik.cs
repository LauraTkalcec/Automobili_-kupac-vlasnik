using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_svojstva
{
    class Vlasnik
    {
        private string Ime;
        private string Prezime;
        private string OIB;

        public string ime
        {
            get
            { return Ime; }

            set
            { ime = value; }
        }

        public string prezime { get => Prezime; set => Prezime = value; }

        public void ZadajIme(string ime)
        {
            Ime = ime;
        }


        public string VratiIme()
        {
            return Ime;
        }

        public void ZadajPrezime(string prezime)
        {
            Prezime = prezime;
        }

        public string VratiPrezime()
        {
            return Prezime;
        }

        public void IspisiVlasnika()
        {
            Console.WriteLine("{0}, {1}", Prezime, Ime);
        }
    }
}

