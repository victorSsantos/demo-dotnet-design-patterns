using demo_design_patterns.behavioral.Strategy.Interfaces;

namespace demo_design_patterns.behavioral.Strategy.Implementations
{
    public class PixPayment : IPaymentStrategy
    {
        public string Pay()
        {
            return "Pix Payment processed";
        }
    }
}
