using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skapa en lista av customers som är sorterad efter namn och efternamn. 
    /// /// </summary>
    public class Task6
    {
        public static List<Customer> GetCustomersSortedByFirstNameAndLastName(Context ctx)
        {
            var query = ctx.Customers.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList(); ;
            return query;
        }
    }
}
