using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Inheritance.VirtualAndProtected
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
