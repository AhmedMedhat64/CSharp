using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Inheritance.Abstract
{
    public abstract class Shape
    {
        protected string Name { get; set; }

        public abstract double CalculateArea();

        public void PrintArea()
        {
            Console.WriteLine($"Area Is: {CalculateArea()}");
        }
    }
}
