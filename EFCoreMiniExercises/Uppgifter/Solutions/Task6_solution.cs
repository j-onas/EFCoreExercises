using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task6_Solution
    {
        public List<Customer> GetCustomersSortedByFirstNameAndLastName(Context ctx)
        {
            return ctx.Customers
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();
        }
    }
}
