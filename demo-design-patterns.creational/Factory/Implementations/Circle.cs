using demo_design_patterns.creational.Factory.Interface;

namespace demo_design_patterns.creational.Factory.Implementations
{
    internal class Circle : IShape
    {
        public void CalculateArea() => Console.WriteLine($"Calculate the {GetType().Name} area.");
    }
}
