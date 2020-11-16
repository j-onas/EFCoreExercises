using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMiniExercises.Uppgifter
{
    public class Task1_Solution
    {
        public static Customer GetFirstCustomerNamedBjorn(Context ctx)
        {
            // Om du kollar SQL debug outputen så kan du se att lambda metoden 'x => x.FirstName == "Björn"'
            // också lyckat laddas om till meningsfull SQL kod
            return ctx.Customers.First(x => x.FirstName == "Björn");

            // Alternativ lösning som också fungerar men är lite överflödig
            //return customers.Where(x => x.FirstName == "Björn").First();
        }
    }
}
