using demo_design_patterns.Interfaces;
using demo_design_patterns.structural.LookAtTable;

namespace demo_design_patterns.Patterns.Structural
{
    public class LookAtTablePattern : IPattern
    {
        public void ExecutePattern()
        {
            Console.WriteLine(MathOperations.Calculate(Operation.Add, 5, 5));
            Console.WriteLine(MathOperations.Calculate(Operation.Subtract, 10, 5));
            Console.WriteLine(MathOperations.Calculate(Operation.Multiply, 5, 2));
            Console.WriteLine(MathOperations.Calculate(Operation.Divide, 10, 5));
        }
    }
}
