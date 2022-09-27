using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = int.Parse(Console.ReadLine());
            int cislo1 = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            double vysledek = 0;
            double zbytek = 0;
            bool spravnaOperace = false;

            if (operace == "+")
            {
                vysledek = cislo + cislo1;
                spravnaOperace = true;
            }
            else if (operace == "-")
            {
                vysledek = cislo - cislo1;
                spravnaOperace = true;
            }
            else if (operace == "*")
            {
                vysledek = cislo * cislo1;
                spravnaOperace = true;
            }
            else if (operace == "/")
            {
                vysledek = cislo / cislo1;
                spravnaOperace = true;

            }
            else if (operace == "%")
            {
                vysledek = cislo / cislo1;
                zbytek = cislo % cislo1;
                Console.WriteLine("Výsledek je: " + vysledek + " se zbytkem: " + zbytek);
            }
            else
            {
                Console.WriteLine("Špatná operace");
            }


            if (spravnaOperace == true)
            {
                Console.WriteLine("Výsledek: " + vysledek);
            }

            Console.ReadKey();
            
            
            
            
            //int soucet = cislo + cislo1;
            //double odmocnina = Math.Round(Math.Sqrt(cislo1), 3);

            //Console.WriteLine(cislo1 + cislo);
            //Console.WriteLine(Math.Pow(cislo1, cislo));
            //Console.WriteLine(Math.Sqrt(cislo));
        }
    }
}
