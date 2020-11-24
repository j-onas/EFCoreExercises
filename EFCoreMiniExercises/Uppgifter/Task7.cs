using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Uppgifter
{
    /// <summary>
    /// Skapa en lista av customers som har någon Sales 
    /// </summary>
    public class Task7
    {
        public static List<Sale> GetCustomersWithSales(Context ctx)
        {
            //var query = ctx.Customers.Where(x => x.Sales != null).ToList();
            //return query;
            // Spottar ut error
            /*
             *  Severity	Code	Description	Project	File	Line	Suppression State
             *  Error	CS0029	Cannot implicitly convert type 'System.Collections.Generic.List<EFCoreMiniExercises.Customer>' to 'System.Collections.Generic.List<EFCoreMiniExercises.Sale>'	EFCoreMiniExercises	E:\SKOLA\datalagring\exercises\EFCore\EFCoreMiniExercises\Uppgifter\Task7.cs	16	Active
             */

            return null;
        }
    }
}
