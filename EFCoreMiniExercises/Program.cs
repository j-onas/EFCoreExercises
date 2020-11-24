using EFCoreMiniExercises.Explanations;
using EFCoreMiniExercises.Uppgifter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises
{
    public class Program
    {
        public static void Main()
        {
            using var ctx = new Context();
            Seed.SeedDatabase(ctx);

            // Task 1-4 har att göra med innehållet i artikeln nedan
            // https://www.learnentityframeworkcore5.com/dbset

            // Kör din task här för att testa att den fungerar som den ska

            //Console.WriteLine(Task1.GetFirstCustomerNamedBjorn(ctx));
            //Console.WriteLine(Task2.GetCustomerNamedBjornSvensson(ctx));
            Console.WriteLine(Task3.GetCustomersNamedBjorn(ctx));
            

        }
    }
}