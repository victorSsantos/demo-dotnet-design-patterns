using demo_design_patterns.creational.Builder.FinalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.creational.Builder.@interface
{
    public interface IProductBuilder
    {
        Product GetProduct();
        void SetProductType();
        void SetProductName();
        void SetProductDescription();
        void SetProductPrice();
        void SetProductLocation();
        void ClearProduct();

    }
}
