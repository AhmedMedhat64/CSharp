using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Inheritance.VirtualAndProtected
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Name = "Rectangle";
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void PrintArea()
        {
            base.PrintArea();
            Console.WriteLine($"Area of Length {Length}: and Width {Width} Is {CalculateArea()}");
        }
    }
}
