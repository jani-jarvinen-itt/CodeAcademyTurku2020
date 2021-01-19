using EntityFrameworkTesti.Models;
using System;
using System.Linq;

namespace EntityFrameworkTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NorthwindContext context = new NorthwindContext();

            // suomalaiset asiakkaat, ratkaisu 1
            /*
            foreach (Customer customer in context.Customers)
            {
                if (customer.Country == "Finland")
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            */

            // suomalaiset asiakkaat, ratkaisu 2, LINQ-kysely
            var suomalaiset = from c in context.Customers
                              where c.Country == "Finland"
                              select c;

            foreach (Customer customer in suomalaiset)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
    }
}
