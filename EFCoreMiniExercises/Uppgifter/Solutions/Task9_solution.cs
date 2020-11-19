using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task9_Solution
    {
        public List<string> GetCustomersWithSales1(Context ctx)
        {
            return ctx.Customers.Select(x => x.LastName).ToList();
        }
    }
}
