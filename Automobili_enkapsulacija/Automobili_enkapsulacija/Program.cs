using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_enkapsulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis osoba:");
            Console.WriteLine();

            Osoba o1 = new Osoba();
            o1.ZadajIme("Ana");
            o1.ZadajPrezime("Anić");
            o1.ispisOsoba();

            Osoba o2 = new Osoba();
            o2.ZadajIme("Iva");
            o2.ZadajPrezime("Ivic");
            o2.ispisOsoba();



            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(o1);
            osobe.Add(o2);
        }
    }
}

