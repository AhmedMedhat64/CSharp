using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Inheritance.Abstract
{
    public class App
    {
        public static void Run(string[] arges)
        {
            Shape r = new Rectangle { Length = 50, Width = 20 };
            r.PrintArea();

            Shape c = new Circle { Radius = 50 };
            c.PrintArea();
        }
    }
}
