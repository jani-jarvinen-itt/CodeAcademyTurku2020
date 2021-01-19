using System;
using System.Text;
using System.Collections.Generic;

namespace LokiinKirjoitus
{
    class Program
    {
        private static List<string> lokimerkinnät = new List<string>();

        static void Main(string[] args)
        {
            KirjoitaLokiin("Moi!");

            /*
            Console.ReadLine();

            List<string> testi = new List<string>();
            for (int i = 0; i < 50000; i++)
            {
                testi.Add("Testtestitesti123");
            }

            Console.WriteLine("Valmis.");
            Console.ReadLine();
            */

            KirjoitaLokiin("Sovelluksen suoritus päättyy.");
        }

        /// <summary>
        /// Kirjoittaa annetun viestin tekstitiedostoon päivämäärän kanssa.
        /// </summary>
        /// <param name="viesti">Haluttu viesti.</param>
        public static void KirjoitaLokiin(string viesti)
        {
            string kellonaika = DateTime.Now.ToString();
            string rivi = kellonaika + ": " + viesti + "\r\n";
            lokimerkinnät.Add(rivi);

            const string TiedostoNimi = @"C:\Academy\Turku2020\GitTesti\DotNet\Loki.txt";

            /*
            FileStream loki = new FileStream(TiedostoNimi, FileMode.Append);
            byte[] tavut = Encoding.UTF8.GetBytes(rivi);
            loki.Write(tavut, 0, tavut.Length);
            loki.Flush();
            loki.Close();
            */

            using (System.IO.FileStream loki =
                new System.IO.FileStream(TiedostoNimi, System.IO.FileMode.Append))
            {
                byte[] tavut = Encoding.UTF8.GetBytes(rivi);
                loki.Write(tavut, 0, tavut.Length);
            }

            Console.WriteLine("Lokimerkintä kirjoitettu.");
        }
    }
}
