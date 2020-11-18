using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Explanations
{
    public class Queries
    {
        public void HowToGenerateQueriesDifferentWays(Context ctx)
        {
            // Linq (Language Integrated Query)
            //Skapar en fråga(query)
            var query1 = (from customer in ctx.Customers
                         where customer.BonusPoints > 1000
                         select customer);

            //Man kan sig av funktioner
            var query2 = ctx.Customers.Where(PointsGreaterThanThousand);
            
            //Även använda sig av Lambda
            var query3 = ctx.Customers.Where(x => x.BonusPoints > 1000);

            //resulterna blir detsamma
            //använd ToList för att köra frågorna.
            var result1 = query1.ToList();
            var result2 = query2.ToList();
            var result3 = query3.ToList();
        }

        private bool PointsGreaterThanThousand(Customer customer) => customer.BonusPoints > 1000;
        
    }
}
