﻿using System;
using System.Collections.Generic;

namespace EFDemoLesson4
{
    class Program
    {
        //Uppgift 1: Visa i consolen namnet på den första kunden som heter Björn.
        static void Main(string[] args)
        {
            using var ctx = new Context();
            SeedDatabase(ctx);



        }

        private static void SeedDatabase(Context ctx)
        {
            ctx.RemoveRange(ctx.Customers);
            ctx.RemoveRange(ctx.Sales);

            var customers = new List<Customer>
            {
                new Customer{FirstName = "Björn", LastName = "Strömberg", BonusPoints = 45000, Gender = Gender.Male },
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