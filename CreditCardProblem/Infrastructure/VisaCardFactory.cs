using System;
using CreditCardProblem.Data.Interfaces;
using CreditCardProblem.Data.Models;

namespace CreditCardProblem.Infrastructure
{
    public class VisaCardFactory : ICreditCardFactory
    {
        public CreditCard GenerateCreditCard(string cardNumber, string ownerName, DateTime expirationDate)
        {
            return new Visa(cardNumber,ownerName,expirationDate);
        }
    }
}