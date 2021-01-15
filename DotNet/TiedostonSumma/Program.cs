using System;
using System.IO;

namespace TiedostonSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostoNimi = @"..\Numerot.txt";
            int summa = 0;

            string[] rivit = File.ReadAllLines(tiedostoNimi);
            foreach (string rivi in rivit)
            {
                int luku = int.Parse(rivi);
                summa += luku;
            }

            Console.WriteLine("Tiedoston rivien summa on: " + summa);
        }
    }
}
