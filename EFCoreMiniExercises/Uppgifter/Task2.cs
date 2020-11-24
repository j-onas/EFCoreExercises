using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skriv en metod som tar in contextet och returnerar EN specifik kund som heter Björn Svensson
    /// </summary>
    public class Task2
    {
        public static Customer GetCustomerNamedBjornSvensson(Context ctx)
        {
            var query = ctx.Customers.FirstOrDefault(c => c.FirstName == "Björn" && c.LastName == "Svensson");
            return query;
        }
    }
}
