using System;
using System.IO;
using System.Text;

namespace LokiinKirjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            KirjoitaLokiin("Moi!");
            KirjoitaLokiin("Sovelluksen suoritus päättyy.");
        }

        public static void KirjoitaLokiin(string viesti)
        {
            string kellonaika = DateTime.Now.ToString();
            string rivi = kellonaika + ": " + viesti + "\r\n";

            const string TiedostoNimi = @"C:\Academy\Turku2020\GitTesti\DotNet\Loki.txt";
            FileStream loki = new FileStream(TiedostoNimi, FileMode.Append);

            byte[] tavut = Encoding.UTF8.GetBytes(rivi);
            loki.Write(tavut, 0, tavut.Length);
            loki.Flush();
            loki.Close();

            Console.WriteLine("Lokimerkintä kirjoitettu.");
        }
    }
}
