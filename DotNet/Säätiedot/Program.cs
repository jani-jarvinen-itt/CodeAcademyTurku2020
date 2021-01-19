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

            HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            Console.WriteLine("Sovelluksen suoritus päättyy.");
        }
    }
}
