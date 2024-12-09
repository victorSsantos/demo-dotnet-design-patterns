using demo_design_patterns.behavioral.Strategy.Interfaces;

namespace demo_design_patterns.behavioral.Strategy.Implementations
{
    public class CreditPayment : IPaymentStrategy
    {
        public string Pay()
        {
            return "Credit Payment processed";
        }
    }
}
