using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreMiniExercises.Explanations
{
    public class LazyLoading
    {
        public void LearnLazyLoading(Context ctx)
        {
            //Här tar vi ut alla Costumers och includerar sales
            //liknande JOIN i sql.
            var q = ctx.Customers.Include(x => x.Sales).ToList();
            
            //Här tar vi tar ut sales men bara om customer har några.
            var sales = q.Where(x => x.Sales.Any()).Select(x => x.Sales);
        }
    }
}
