using demo_design_patterns.behavioral.Strategy.Interfaces;

namespace demo_design_patterns.behavioral.Strategy
{
    public class PaymentProcessor(IPaymentStrategy payment)
    {
        private readonly IPaymentStrategy _paymentStrategy = payment;

        public void ProcessPayment()
        {
            Console.WriteLine(_paymentStrategy.Pay());
        }
    }
}
