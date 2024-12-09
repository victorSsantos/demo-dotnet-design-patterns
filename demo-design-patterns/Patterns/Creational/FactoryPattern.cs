using demo_design_patterns.creational.Factory;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Creational
{
    public class FactoryPattern : IPattern
    {
        public void ExecutePattern()
        {
            var circle = ShapeFactory.CreateShape(ShapeType.Circle);
            var square = ShapeFactory.CreateShape(ShapeType.Square);
            var rectangle = ShapeFactory.CreateShape(ShapeType.Rectangle);

            circle.CalculateArea();
            square.CalculateArea();
            rectangle.CalculateArea();
        }
    }
}
