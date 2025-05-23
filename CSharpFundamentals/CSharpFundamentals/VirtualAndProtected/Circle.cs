using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.VirtualAndProtected
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Name = "Circle";
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void PrintArea()
        {
            Console.WriteLine($"Area of Shape {Name} with Radius {Radius} Is {CalculateArea()}");
        }
    }
}
