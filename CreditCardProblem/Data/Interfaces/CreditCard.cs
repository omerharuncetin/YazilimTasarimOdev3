using System;

namespace CreditCardProblem.Data.Interfaces
{
    public abstract class CreditCard
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime ExpirationDate { get; set; }

        public abstract override string ToString();
    }
}