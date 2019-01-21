using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_konstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vlasnici:");
            Console.WriteLine();
            Vlasnik  v1 = new Vlasnik("Ana", "Anić", "123456789012");
            v1.IspisiVlasnika();

            Vlasnik v2 = new Vlasnik("Antonio", "Mihiv", "12848449012");
            v2.IspisiVlasnika();

            List<Vlasnik> vlasnik = new List<Vlasnik>();
            vlasnik.Add(v2);
            vlasnik.Add(v2);
        }
    }
}
