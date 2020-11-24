using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skapa en lista av customers som är sorterad på förnamn. 
    /// /// </summary>
    public class Task5
    {
        public static List<Customer> GetCustomersSortedByFirstName(Context ctx)
        {
            var query = ctx.Customers.OrderBy(c => c.FirstName).ToList();
            return query;
        }
    }
}
