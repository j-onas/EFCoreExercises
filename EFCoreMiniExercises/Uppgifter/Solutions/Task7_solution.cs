using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task7_Solution
    {
        public List<Customer> GetCustomersWithSales(Context ctx)
        {
            //return ctx.Customers.Where(x => x.Sales.Any()).ToList();

            //Alternative
            //return (from c in ctx.Customers
            //        //where c.Sales.Any()
            //        //where c.Sales.Count > 0
            //        select c).ToList();
        }
    }
}
