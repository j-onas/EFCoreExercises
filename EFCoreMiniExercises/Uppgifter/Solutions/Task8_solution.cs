using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task8_Solution
    {
        public List<Customer> GetTopThreeCustomersWithHighestPoints(Context ctx)
        {
            return ctx.Customers.OrderByDescending(x => x.BonusPoints).Take(3).ToList();

            //Alternative
            //return (from c in ctx.Customers
            //        orderby c.FirstName descending
            //        select c).Take(3).ToList();
        }
    }
}
