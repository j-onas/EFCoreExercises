using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDemoLesson4.Uppgifter
{
    class Task2_Solution
    {

        public Customer GetCustomerNamedBjornSvensson(Context ctx)
        {
            return ctx.Customers.Single(x => x.FirstName == "Björn" && x.LastName == "Svensson");
            //return customers.Where(x => x.FirstName == "Bjorn" && x.LastName == "Svensson").Single();

        }
    }
}
