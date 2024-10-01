using Abstractions;
using ExternalLibraries;

namespace Adapters
{
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly StripePaymentProcessor _stripePaymentProcessor;

        public StripeAdapter(StripePaymentProcessor stripePaymentProcessor)
        {
            _stripePaymentProcessor = stripePaymentProcessor;
        }

        public void ProcessPayment(double amount)
        {
            _stripePaymentProcessor.MakePayment(amount);
        }
    }
}
