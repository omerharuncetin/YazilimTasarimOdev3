using System;
using CreditCardProblem.Data.Interfaces;
using CreditCardProblem.Data.Models;

namespace CreditCardProblem.Infrastructure
{
    public class AmericanExpressCardFactory : ICreditCardFactory
    {
        public CreditCard GenerateCreditCard(string cardNumber, string ownerName, DateTime expirationDate)
        {
            return new AmericanExpress(cardNumber,ownerName,expirationDate);
            
        }
    }
}