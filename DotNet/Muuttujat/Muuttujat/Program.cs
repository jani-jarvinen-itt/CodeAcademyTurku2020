using System;

namespace Muuttujat
{
    class Program
    {
        static void Main(string[] args)
        {
            float liukuluku = 10.3f;
            int luku = 123;

            if (liukuluku == luku)
            {
                Console.WriteLine("Luvut ovat samat!");
            }

            if (luku != 0)
            {
                Console.WriteLine("Luku on eri kuin nolla!");
            }

            bool positiivinenLuku = (luku > 0);

            int[] suuriTaulukko = new int[10000000];

            string merkkijono = "ABC";
            if (merkkijono == "ABC")
            {

            }


            /*
            int muuttuja = 123;

            if (muuttuja == 123)
            {
                Console.WriteLine("Luku on 123!");
            }
            else
            {
                Console.WriteLine("Luku on jotain muuta kuin 123.");
            }

            // muuttuja = true;
            Console.WriteLine(muuttuja);
            */

            /*
            int[] taulukko = { 1, 2, 3 };
            Console.WriteLine(taulukko);

            taulukko[10] = 100;   // aiheuttaa virheen!
            Console.WriteLine(taulukko);
            */
        }
    }
}
