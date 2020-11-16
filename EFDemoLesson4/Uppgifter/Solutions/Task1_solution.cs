using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDemoLesson4.Uppgifter
{
    public class Task1_Solution
    {

        public Customer GetFirstCustomerNamedBjorn(Context ctx)
        {
            return ctx.Customers.First(x => x.FirstName == "Björn");
            //return customers.Where(x => x.FirstName == "Björn").First();

        }
    }
}
