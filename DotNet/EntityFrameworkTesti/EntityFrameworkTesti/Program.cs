using EntityFrameworkTesti.Models;
using System;

namespace EntityFrameworkTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NorthwindContext context = new NorthwindContext();
            foreach (Customer customer in context.Customers)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
    }
}
