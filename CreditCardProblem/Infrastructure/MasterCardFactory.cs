using System;
using CreditCardProblem.Data.Interfaces;
using CreditCardProblem.Data.Models;

namespace CreditCardProblem.Infrastructure
{
    public class MasterCardFactory : ICreditCardFactory
    {
        public CreditCard GenerateCreditCard(string cardNumber, string ownerName, DateTime expirationDate)
        {
            return new MasterCard(cardNumber,ownerName,expirationDate);
            
        }
    }
}