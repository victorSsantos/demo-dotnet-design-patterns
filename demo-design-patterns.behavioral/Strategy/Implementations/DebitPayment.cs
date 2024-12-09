using demo_design_patterns.behavioral.Strategy.Interfaces;

namespace demo_design_patterns.behavioral.Strategy.Implementations
{
    public class DebitPayment : IPaymentStrategy
    {
        public string Pay()
        {
            return "Debit Payment processed";
        }
    }
}
