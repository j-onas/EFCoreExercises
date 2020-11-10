using System;
using System.Collections.Generic;

namespace EFDemoLesson4
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BonusPoints { get; set; }
        public Gender Gender { get; set; }
        public virtual List<Sale> Sales { get; set; } // One to Many mellan Customer och Sale tabellerna
    }
    public class Sale
    {
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }


        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
