using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Abstract
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
