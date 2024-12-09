using demo_design_patterns.creational.Builder.FinalObject;
using demo_design_patterns.creational.Builder.@interface;

namespace demo_design_patterns.creational.Builder.concretes
{
    public class ProductABuilder : IProductBuilder
    {
        private Product _productA = new();

        public Product GetProduct() => _productA;

        public void ClearProduct() => _productA = new Product();

        public void SetProductType() => _productA.Type = ProductType.A;

        public void SetProductName() => _productA.Name = "Product A";

        public void SetProductDescription() => _productA.Description = "Description of Product A";

        public void SetProductPrice() => _productA.Price = 10.0;

        public void SetProductLocation() => _productA.Location = "Brazil";     
    }
}
