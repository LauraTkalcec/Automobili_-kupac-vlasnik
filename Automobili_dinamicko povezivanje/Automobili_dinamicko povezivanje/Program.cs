using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_dinamicko_povezivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupac k1 = new Kupac("Ivan", "Ivanda", "21321312313");
            Vlasnik v1 = new Vlasnik("Hrvoje", "Horvat", "44444444", "Ured br. 1");

            Console.WriteLine();
            Console.WriteLine("Ospiši oznake: (1)");
            Console.WriteLine(k1.dohvatiIdentifikator());
            Console.WriteLine(v1.dohvatiIdentifikator());

            Osoba k2 = new Kupac("Ivan", "Ivanda", "21321312313", "101010101010");
            Osoba v2 = new Vlasnik("Hrvoje", "Horvat", "44444444", "Ured br. 1");

            Console.WriteLine();
            Console.WriteLine("Ospiši oznake: (2)");
            Console.WriteLine(k2.dohvatiIdentifikator());
            Console.WriteLine(v2.dohvatiIdentifikator());
        }
    }
}
