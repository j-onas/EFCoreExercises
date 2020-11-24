using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skriv en metod som tar in contextet och returnerar ALLA kunder som heter Björn
    /// </summary>
    public class Task3
    {
        public static List<Customer> GetCustomersNamedBjorn(Context ctx)
        {
            var query = ctx.Customers.Where(c => c.FirstName == "Björn").ToList();    //OrderBy(c => c.FirstName == "Björn").ToList();
            return query;
        }
    }
}
