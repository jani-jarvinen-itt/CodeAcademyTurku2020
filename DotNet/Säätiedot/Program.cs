using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Säätiedot
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Säätietojen haku alkaa.");

            string kaupunki = "Turku";
            string apiAvain = "f9463bc94dd7f584483b04a3a49f18ba";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={kaupunki}&appid={apiAvain}&units=metric";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            Console.WriteLine("Sovelluksen suoritus päättyy.");
        }
    }
}
