using System;
using Abstractions;

namespace ExternalLibraries
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
