using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task3_Solution
    {
        public static List<Customer> GetCustomersNamedBjorn(Context ctx)
        {
            //ToList() kan användas för att att få tag på ett flertaligt resultat
            return ctx.Customers.Where(x => x.FirstName == "Björn").ToList();

            //Alternative
            //return (from c in ctx.Customers
            //        where c.FirstName == "Björn"
            //        select c).ToList();
        }
    }
}
