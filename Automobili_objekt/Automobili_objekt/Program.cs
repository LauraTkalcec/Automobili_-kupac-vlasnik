using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_objekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Marka1 = "Audi";
            string Zemlja1 = "Njemacka";

            string Marka2 = "BMW";
            string Zemlja2 = "Njemačka";

            string Marka3 = "Ford";
            string Zemlja3 = "Sad";

            int i;

            Auto a1 = new Auto();
            a1.Marka = "Audi";
            a1.Zemlja = "Njemacka";
            a1.IspisAutomobila();

            Auto a2 = new Auto();
            a2.Marka = "Ford";
            a2.Zemlja = "Sad";
            a2.IspisAutomobila();

            Console.WriteLine("Automobili:");
            Console.WriteLine();
            List<Auto> auto = new List<Auto>();

            auto.Add(a1);
            auto.Add(a2);
        }
    }
}
