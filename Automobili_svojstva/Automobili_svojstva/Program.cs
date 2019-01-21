using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_svojstva
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ispis osoba:");
            Console.WriteLine();

            Vlasnik o1 = new Vlasnik();
            o1.ZadajIme("Ana");
            o1.ZadajPrezime("Anić");
            o1.IspisiVlasnika();

            Vlasnik o2 = new Vlasnik();
            o2.ZadajIme("Iva");
            o2.ZadajPrezime("Ivic");
            o2.IspisiVlasnika();


            Vlasnik o3 = new Vlasnik();
            o3.ZadajIme("Martina");
            o3.ZadajPrezime("Martic");
            o3.IspisiVlasnika();

            Vlasnik o4 = new Vlasnik();
            o4.ZadajIme("Andrija");
            o4.ZadajPrezime("Anovic");
            o4.IspisiVlasnika();


            List<Vlasnik> osobe = new List<Vlasnik>();
            osobe.Add(o1);
            osobe.Add(o2);
            osobe.Add(o3);
            osobe.Add(o4);




        }
    }


}