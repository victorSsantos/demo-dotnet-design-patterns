using demo_design_patterns.creational.Factory.Interface;

namespace demo_design_patterns.creational.Factory.Implementations
{
    public class Square : IShape
    {
        public void CalculateArea() => Console.WriteLine($"Calculate the {GetType().Name} area.");
    }
}
