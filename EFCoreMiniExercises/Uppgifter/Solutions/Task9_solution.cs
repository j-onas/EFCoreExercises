using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task9_Solution
    {
        public List<string> GetCustomersLastName(Context ctx)
        {
            return ctx.Customers.Select(x => x.LastName).ToList();

            //Alternative
            //return (from c in ctx.Customers
            //        select c.LastName).ToList();
        }
    }
}
