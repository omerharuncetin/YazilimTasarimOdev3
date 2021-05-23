using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using CreditCardProblem.Data.Interfaces;
using CreditCardProblem.Infrastructure;

namespace CreditCardProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cards = File.ReadLines("../../../cards.txt");
            
            foreach (string card in cards)
            {
                string[] informations = card.Split("&");
                string cardNumber = informations[0];
                string ownerName = informations[1];
                
                DateTime expirationDate = DateTime.Parse(informations[2]);
                ICreditCardFactory factory = GetCardType(cardNumber);
                if (factory == null)
                {
                    Console.WriteLine("Invalid card number.");
                    continue;
                }
                
                FactoryCreator factoryCreator = new FactoryCreator(factory, cardNumber, ownerName, expirationDate);
                Console.WriteLine(factoryCreator.CreditCard.ToString());
            }
        }
        
        static ICreditCardFactory GetCardType(string cardNumber)
        {
            Regex visaRegex = new Regex("^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$");
            Regex mastercardRegex = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
            Regex americanExpressRegex = new Regex("^3[47][0-9]{13}$");
            
            
            if (visaRegex.Match(cardNumber).Success)
            {
                return new VisaCardFactory();
            }
            
            if (mastercardRegex.Match(cardNumber).Success)
            {
                return new MasterCardFactory();
            }
            
            if (americanExpressRegex.Match(cardNumber).Success)
            {
                return new AmericanExpressCardFactory();
            }

            return null;
        }
    }
}