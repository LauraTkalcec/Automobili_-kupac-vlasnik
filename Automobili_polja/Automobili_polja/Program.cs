using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili_polja
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


            Console.WriteLine("Popis automobila:");
            Console.WriteLine("1. {0}, {1}", Marka1, Zemlja1);
            Console.WriteLine("2. {0}, {1}", Marka2, Zemlja2);
            Console.WriteLine("3. {0}, {1}", Marka3, Zemlja3);
            Console.WriteLine();


            string[] Marka = { "Audi", "Ford", "Toyota", "Peogeot" };
            string[] Zemlja= { "Njemačka", "Sad", "Japan","Francuska"  };

            Console.WriteLine("Popis automobila:");
            for (int i = 0; i < Marka.Length; i++)
            {
                Console.WriteLine("{0}. {1}, {2}", i, Marka[i], Zemlja[i]);
            }
        }
    }
}
