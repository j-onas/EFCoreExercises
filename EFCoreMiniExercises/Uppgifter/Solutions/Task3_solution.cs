using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task3_Solution
    {
        public static List<Customer> GetCustomersNamedBjorn(Context cxt)
        {
            //ToList() kan användas för att att få tag på ett flertaligt resultat
            return cxt.Customers.Where(x => x.FirstName == "Björn").ToList();
        }
    }
}
