using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.structural.LookAtTable
{
    public class MathOperations
    {
        public static double Calculate(Operation operation, double x, double y)
        {
            var calculator = new Dictionary<Operation, Func<double, double, double>>()
            {
                {Operation.Add, (x, y) => x + y} ,
                {Operation.Subtract, (x, y) => x - y},
                {Operation.Multiply, (x, y) => x * y},
                {Operation.Divide, (x, y) => x / y}
            };

            return calculator[operation](x,y);
        }
    }

    public enum Operation
    {
        Add,
        Subtract, 
        Multiply, 
        Divide
    }
}
