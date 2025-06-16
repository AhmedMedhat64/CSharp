using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.DataStructures.Arraylist
{
    internal class Program
    {
        public static void Run(string[] aregs)
        {
            ArrayList list = new ArrayList();

            list.AddRange(new char[] { 'A', 'h', 'm', 'e', 'd' });

            list.Add("Ahmed");

            list.Remove("Ahmed");

            list.RemoveRange(0, 3);

            list.RemoveAt(0);

            list.Reverse();

            list.Clear();

            list.Insert(2, 5);

            list.InsertRange(2, new char[] { 'A', 'h', '5', 'e', 'd' });
        }
    }
}
