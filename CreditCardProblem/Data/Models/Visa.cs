using System;
using CreditCardProblem.Data.Interfaces;

namespace CreditCardProblem.Data.Models
{
    public class Visa : CreditCard
    {
        public Visa(string cardNumber, string ownerName, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            ExpirationDate = expirationDate;
        }


        public override string ToString()
        {
            return $"Card Type: Visa | Card Number: {CardNumber} | Owner Name: {OwnerName} | Expiration Date: {ExpirationDate.ToString("MM-yy")}";
        }
    }
}