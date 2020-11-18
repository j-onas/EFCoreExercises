using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMiniExercises
{
    class Seed
    {
        public  static void SeedDatabase(Context ctx)
        {
            ctx.RemoveRange(ctx.Customers);
            ctx.RemoveRange(ctx.Sales);

            var customers = new List<Customer>
            {
                new Customer{FirstName = "Björn", LastName = "Strömberg", BonusPoints = 45000, Gender = Gender.Male, Sales= new List<Sale>{ new Sale { DateOfPurchase= DateTime.Now } } },
                new Customer{FirstName = "Björn", LastName = "Andersson", BonusPoints = 660, Gender = Gender.Male},
                new Customer{FirstName = "Lisa", LastName = "Andersson", BonusPoints = 900, Gender = Gender.Female},
                new Customer{FirstName = "Klas", LastName = "Klasson", BonusPoints = 1000, Gender = Gender.Male},
                new Customer{FirstName = "Kalle", LastName = "Anka", BonusPoints = 0, Gender = Gender.Male},
                new Customer{FirstName = "Åsa", LastName = "Helgesson", BonusPoints = 10, Gender = Gender.Female},
                new Customer{FirstName = "Björn", LastName = "Svensson", BonusPoints = 9000, Gender = Gender.Male},
                new Customer{FirstName = "Åsa", LastName = "Lampa", BonusPoints = 70, Gender = Gender.Female},
                new Customer{FirstName = "Kajsa", LastName = "Anka", BonusPoints = 450, Gender = Gender.Female}
            };

            ctx.Customers.AddRange(customers);


            ctx.SaveChanges();
        }
    }
}
