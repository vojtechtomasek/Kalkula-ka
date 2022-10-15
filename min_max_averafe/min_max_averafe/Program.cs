using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = int.Parse(Console.ReadLine());
            int max = -1, min = Int32.MaxValue, soucet = 0;

            Console.WriteLine();

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Číslo: " + (i + 1));
                int vstup = int.Parse(Console.ReadLine());
                soucet += vstup;

                if (vstup > max)
                {
                    max = vstup;
                }
                else if (vstup < min)
                {
                    min = vstup;
                }

            }
            Console.WriteLine("Nejmenší číslo je: " + min);
            Console.WriteLine("Největší číslo je: " + max);
            Console.WriteLine("Aritmetický průměr čísel je: " + soucet/pocet);

            Console.ReadKey();
        }
    }
}
