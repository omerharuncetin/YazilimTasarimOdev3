using System;
using CreditCardProblem.Data.Interfaces;

namespace CreditCardProblem.Data.Models
{
    public class MasterCard : CreditCard
    {
        public MasterCard(string cardNumber, string ownerName, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            ExpirationDate = expirationDate;
        }
        
        public override string ToString()
        {
            return $"Card Type: MasterCard | Card Number: {CardNumber} | Owner Name: {OwnerName} | Expiration Date: {ExpirationDate.ToString("MM-yy")}";
        }
    }
}