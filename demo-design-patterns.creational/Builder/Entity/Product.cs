using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.creational.Builder.FinalObject
{
    public class Product
    {
        public ProductType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public string Location { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{{Product: {{\"Type\": \"{Type}\", \"Name\": \"{Name}\", \"Description\": \"{Description}\", \"Price\": {Price:F2}, \"Location\": \"{Location}\"}}}}";
        }
    }

    public enum ProductType
    {
        A = 0, B = 1
    }
}