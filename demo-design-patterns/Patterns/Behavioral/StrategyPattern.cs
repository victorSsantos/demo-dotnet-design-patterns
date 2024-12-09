using demo_design_patterns.behavioral.Strategy;
using demo_design_patterns.behavioral.Strategy.Implementations;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Behavioral
{
    public class StrategyPattern : IPattern
    {
        public void ExecutePattern()
        {
            var processor = new PaymentProcessor(new CreditPayment());
            processor.ProcessPayment();

            processor = new PaymentProcessor(new PixPayment());
            processor.ProcessPayment();
        }
    }
}
