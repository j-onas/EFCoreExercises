using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    class Task4_Solution
    {
        public static int CountFemaleCustomers(Context ctx)
        {
            return ctx.Customers.Count(c => c.Gender == Gender.Female);

            //Alternative
            //return (from c in ctx.Customers
            //        where c.Gender == Gender.Female
            //        select c).Count();
        }
    }
}
