using demo_design_patterns.creational.Builder.FinalObject;
using demo_design_patterns.creational.Builder.@interface;

namespace demo_design_patterns.creational.Builder.DirectorBuilder
{
    public class ProductBuilder(IProductBuilder builder)
    {
        private readonly IProductBuilder _builder = builder;

        public void BuildProduct()
        {
            _builder.SetProductType();
            _builder.SetProductName();
            _builder.SetProductDescription();
            _builder.SetProductPrice();
            _builder.SetProductLocation();
        }

        public Product GetProduct() => _builder.GetProduct();
    }
}