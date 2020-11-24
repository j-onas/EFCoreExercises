using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// skapa en lista som inhåller alla customers efternamn
    /// </summary>
    public class Task9
    {
        public static List<string> GetCustomersLastName(Context ctx)
        {
            var query = ctx.Customers.Select(c => c.LastName).ToList();
            return query;
        }
    }
}
