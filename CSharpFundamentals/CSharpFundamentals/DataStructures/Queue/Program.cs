using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.DataStructures.Queue
{
    internal class Program
    {
        // FIFO
        public static void Run (string[] args)
        {

        }

        public static void QueueExecuteExample()
        {
            var queue = new Queue<string>();
            Console.WriteLine("Please enter a document (print to Print)");
            string input = Console.ReadLine();

            while (true)
            {
                if (input.Equals("print", StringComparison.OrdinalIgnoreCase))
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine($"Print document: '{queue.Dequeue()}' ....");
                    }
                }
                else 
                    queue.Enqueue(input);
            }
        }
    }
}
