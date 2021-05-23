using System;
using CreditCardProblem.Data.Interfaces;
using CreditCardProblem.Data.Models;

namespace CreditCardProblem.Infrastructure
{
    public class FactoryCreator
    {
        private ICreditCardFactory _cardFactory;
        public CreditCard CreditCard { get; set; }

        public FactoryCreator(ICreditCardFactory cardFactory, string cardNumber, string ownerName, DateTime expirationDate)
        {
            this._cardFactory = cardFactory;
            this.CreditCard = this._cardFactory.GenerateCreditCard(cardNumber, ownerName, expirationDate);
        }
    }
}