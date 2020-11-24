using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skriv en metod som tar in contextet och returnerar antalet kvinnliga kunder 
    /// /// </summary>
    public class Task4
    {
        public static int CountFemaleCustomers(Context ctx)
        {
            var query = ctx.Customers.Count(c => c.Gender > 0);
            return query;
        }
    }
}
