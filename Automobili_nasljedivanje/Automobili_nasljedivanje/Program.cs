using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kupac k1 = new Kupac();
            k1.ime = "Goran";
            k1.prezime = "Grabar";
            k1.OIB="12121213213";

            Vlasnik v1 = new Vlasnik();
            v1.ime = "Hrvoje";
            v1.prezime = "Horvat";
            v1.Trazi = "auto";
        }
    }
}
