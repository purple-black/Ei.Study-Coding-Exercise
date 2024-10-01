using System;

namespace ExternalLibraries
{
    public class StripePaymentProcessor
    {
        public void MakePayment(double value)
        {
            Console.WriteLine($"Processing Stripe payment of ${value}");
        }
    }
}
