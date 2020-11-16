using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task2_Solution
    {
        public Customer GetCustomerNamedBjornSvensson(Context ctx)
        {
            return ctx.Customers.Single(x => x.FirstName == "Björn" && x.LastName == "Svensson");

            // eller
            //return customers.Where(x => x.FirstName == "Bjorn" && x.LastName == "Svensson").Single();
        }
    }
}
