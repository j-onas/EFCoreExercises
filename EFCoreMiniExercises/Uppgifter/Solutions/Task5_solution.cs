using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task5_Solution
    {
        public List<Customer> GetCustomersSortedByFirstName(Context ctx)
        {
            return ctx.Customers.OrderBy(x => x.FirstName).ToList();

            //Alternative
            //return (from c in ctx.Customers
            //        orderby c.FirstName
            //        select c).ToList();
        }
    }
}
