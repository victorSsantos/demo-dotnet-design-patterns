using demo_design_patterns.creational.Factory.Implementations;
using demo_design_patterns.creational.Factory.Interface;

namespace demo_design_patterns.creational.Factory
{
    public class ShapeFactory
    {
        public static IShape CreateShape(ShapeType type)
        {
            return type switch
            {
                ShapeType.Square => new Square(),
                ShapeType.Circle => new Circle(),
                ShapeType.Rectangle => new Rectangle(),
                _ => throw new ArgumentException("Invalid Shape Type"),
            };
        }
    }

    public enum ShapeType 
    { 
        Square = 0,
        Circle = 1,
        Rectangle = 2
    }
}
