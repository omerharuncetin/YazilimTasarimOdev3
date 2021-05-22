using System;
using CreditCardProblem.Data.Interfaces;

namespace CreditCardProblem.Infrastructure
{
    public interface ICreditCardFactory
    {
        public CreditCard GenerateCreditCard(string cardNumber, string ownerName, DateTime expirationDate);
    }
}