using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.creational.Prototype.Interface
{
    public interface IDocument
    {
        IDocument Clone();
        void Display();
    }
}
