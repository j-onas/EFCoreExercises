using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDemoLesson4.Uppgifter
{
    class Task3_Solution
    {

        public List<Customer> GetCustomersNamedBjorn(Context cxt)
        {
            //ToList() för att exekvera custumers
            return cxt.Customers.Where(x => x.FirstName == "Björn").ToList();
        }
    }
}
