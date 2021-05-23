using System;
using CreditCardProblem.Data.Models;

namespace CreditCardProblem.Data.Interfaces
{
    public interface ICreditCardFactory
    {
        public CreditCard GenerateCreditCard(string cardNumber, string ownerName, DateTime expirationDate);
    }
}