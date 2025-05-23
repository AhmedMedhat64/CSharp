using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.VirtualAndProtected
{
    public abstract class Shape
    {
        protected string Name { get; set; }

        public abstract double CalculateArea();

        public virtual void PrintArea()
        {
            Console.WriteLine($"Area Is: {CalculateArea()}");
        }
    }
}
