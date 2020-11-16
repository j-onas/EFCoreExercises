using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDemoLesson4.Uppgifter
{
    class Task4_Solution
    {
        public void WriteBjornCustomers(Context ctx)
        {
            var c = ctx.Customers.Where(x => x.FirstName == "Björn");
            foreach (var customer in c)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }
}
