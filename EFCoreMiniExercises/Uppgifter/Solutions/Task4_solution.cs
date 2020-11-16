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
        }
    }
}
