using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skriv en metod som tar in contextet och returnerar första kunden som heter Björn
    /// 
    /// Nyckelord: .First(), lamda-funktioner 'c => c.XXX'
    /// 
    /// Rätt svar: {FirstName = "Björn", LastName = "Strömberg", BonusPoints = 45000, Gender = Gender.Male }
    /// </summary>
    public class Task1
    {
        public static Customer GetFirstCustomerNamedBjorn(Context ctx)
        {
            var query = ctx.Customers.FirstOrDefault(c => c.FirstName == "Björn");
            
            return query;
        }
    }
}
