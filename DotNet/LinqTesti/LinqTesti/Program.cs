using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // tapa 1, eli perinteinen ohjelmointi
            int[] luvut = { 1, 8, 4, 15, 13, 20, 7, 5, 17, 2, 11, 8, 16, 14 };
            Array.Sort(luvut);
            foreach (int luku in luvut)
            {
                if (luku > 10)
                {
                    Console.WriteLine(luku);
                }
            }

            // tapa 1b, eli perinteinen ohjelmointi
            Console.WriteLine();
            int[] luvut2 = { 1, 8, 4, 15, 13, 20, 7, 5, 17, 2, 11, 8, 16, 14 };
            List<int> suuretLuvut = new List<int>();
            foreach (int luku in luvut2)
            {
                if (luku > 10)
                {
                    suuretLuvut.Add(luku);
                }
            }
            suuretLuvut.Sort();
            foreach (int luku in suuretLuvut)
            {
                Console.WriteLine(luku);
            }

            // tapa 2, LINQ-kysely ns. kyselysyntaksilla
            Console.WriteLine();
            Console.WriteLine("--- LINQ ---");
            Console.WriteLine();
            int[] luvut3 = { 1, 8, 4, 15, 13, 20, 7, 5, 17, 2, 11, 8, 16, 14 };
            var suuretLuvut2 = from l in luvut3
                               where l > 10
                               orderby l
                               select l;
            foreach (int luku in suuretLuvut2)
            {
                Console.WriteLine(luku);
            }

            // tapa 2b, LINQ-kysely ns. metodisyntaksilla
            Console.WriteLine();
            int[] luvut4 = { 1, 8, 4, 15, 13, 20, 7, 5, 17, 2, 11, 8, 16, 14 };
            var suuretLuvut3 = luvut4.Where(l => l > 10).OrderBy(l => l);
            //var suuretLuvut3 = luvut4.Where(TäyttääEhdot).OrderBy(l => l);

            foreach (int luku in suuretLuvut3)
            {
                Console.WriteLine(luku);
            }

            int summa = luvut4.Sum();
        }

        private static bool TäyttääEhdot(int luku)
        {
            return luku > 10;
        }
    }
}
