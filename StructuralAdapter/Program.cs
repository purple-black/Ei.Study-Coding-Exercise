// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
There are PayPal payment processor and anew processor called stripe. 
The interface provided by Stripe is different from that of PayPal. Adapter Pattern is used to create a class
that adapts the Stripe interface to the existing PayPal system
*/

using Adapters;
using Abstractions;
using ExternalLibraries;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paypalPayment = new PayPalPaymentProcessor();
            paypalPayment.ProcessPayment(100.0);

            IPaymentProcessor stripePayment = new StripeAdapter(new StripePaymentProcessor());
            stripePayment.ProcessPayment(200.0);

            Console.ReadLine();
        }
    }
}

