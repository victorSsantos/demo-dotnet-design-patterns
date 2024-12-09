using demo_design_patterns.creational.Builder.concretes;
using demo_design_patterns.creational.Builder.DirectorBuilder;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Creational
{
    public class BuilderPattern : IPattern
    {
        public void ExecutePattern()
        {
            var builderProductA = new ProductBuilder(new ProductABuilder());
            builderProductA.BuildProduct();
            Console.WriteLine(builderProductA.GetProduct());

            var builderProductB = new ProductBuilder(new ProductBBuilder());
            builderProductB.BuildProduct();
            Console.WriteLine(builderProductB.GetProduct());
        }
    }
}
