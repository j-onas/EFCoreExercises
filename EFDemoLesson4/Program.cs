using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFDemoLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context ctx = new Context())
            {
                Customer c = new Customer { FirstName = "Berg", LastName = "Bergson", Gender = Gender.Female, BonusPoints = 40000};
                ctx.Customers.Add(c);

                Customer b = ctx.Customers.Single(c => c.FirstName == "Björn");
                b.BonusPoints = 0;
                ctx.Customers.Update(b);

                var sales = ctx.Sales.ToList();

                sales[0].Customer = c;
                ctx.Update(sales[0]);

                ctx.SaveChanges();

                foreach (var sale in sales)
                    Console.WriteLine("Id: " + sale.Id +
                        "\nDatum: " + sale.DateOfPurchase +
                        "\nCustomer Id: "+ sale.CustomerId +
                        "\nCustomer Name: " + sale.Customer.FirstName + " " + sale.Customer.LastName + 
                        "\nCustomer Gender: " + sale.Customer.Gender);
            }
        }
    }
}
