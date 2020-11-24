using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skapa en lista av de 3 första customers med mest bonus poäng.
    /// </summary>
    public class Task8
    {
        public static List<Customer> GetTopThreeCustomersWithHighestPoints(Context ctx) {

            var query = ctx.Customers.OrderByDescending(c => c.BonusPoints).Take(3).ToList();
            return query;
        }
    }
}
