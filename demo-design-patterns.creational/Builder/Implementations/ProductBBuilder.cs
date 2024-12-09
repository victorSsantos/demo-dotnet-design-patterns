using demo_design_patterns.creational.Builder.FinalObject;
using demo_design_patterns.creational.Builder.@interface;

namespace demo_design_patterns.creational.Builder.concretes
{
    public class ProductBBuilder : IProductBuilder
    {
        private Product _productB = new();

        public Product GetProduct() => _productB;

        public void ClearProduct() => _productB = new Product();

        public void SetProductType() => _productB.Type = ProductType.B;

        public void SetProductName() => _productB.Name = "Product B";

        public void SetProductDescription() => _productB.Description = "Description of Product B";

        public void SetProductPrice() => _productB.Price = 15.0;

        public void SetProductLocation() => _productB.Location = "USA";

        
    }
}
