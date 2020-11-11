using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFDemoLesson4
{
    class Program
    {
        static void SeedDatabase(Context ctx)
        {
            ctx.RemoveRange(ctx.Customers);
            ctx.RemoveRange(ctx.Sales);

            Customer c = new Customer
            {
                FirstName = "Björn",
                LastName = "Strömberg",
                BonusPoints = 45000,
                Gender = Gender.Male
            };

            ctx.Customers.Add(c);

            ctx.Sales.Add(new Sale
            {
                DateOfPurchase = DateTime.Now,
                Customer = c,
            });

            ctx.SaveChanges();
        }
        static void Main(string[] args)
        {
            using(Context ctx = new Context())
            {
                SeedDatabase(ctx);

                ctx.Customers.RemoveRange(ctx.Customers);
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
                        "\nCustomer Id: "+ sale.Customer.Id +
                        "\nCustomer Name: " + sale.Customer.FirstName + " " + sale.Customer.LastName + 
                        "\nCustomer Gender: " + sale.Customer.Gender);
            }
        }
    }
}
