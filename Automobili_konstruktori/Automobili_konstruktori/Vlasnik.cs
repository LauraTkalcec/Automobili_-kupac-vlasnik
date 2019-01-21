using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_konstruktori
{
    class Vlasnik
    {
        private string Ime;
        private string Prezime;
        private string Oib;

        public Vlasnik(string ime, string prezime, string Oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = Oib;
        }
                       
        public string ime
        {
            get
            { return ime; }

            set
            { ime = value; }
        }

        public string prezime { get => prezime; set => prezime = value; }

        public void ZadajIme(string ime)
        {
            Ime = ime;
        }


        public string VratiIme()
        {
            return ime;
        }

        public void ZadajPrezime(string prezime)
        {
            Prezime = prezime;
        }

        public string VratiPrezime()
        {
            return prezime;
        }

        public void IspisiVlasnika()
        {
            Console.WriteLine("{0}, {1}", prezime, ime);
        }
    }
}
