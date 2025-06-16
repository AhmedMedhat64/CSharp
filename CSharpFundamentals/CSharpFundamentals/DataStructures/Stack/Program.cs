using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.DataStructures.Stack
{
    internal class Program
    {
        // LIFO
        public static void Run()
        {
            StackExeuteExample();
        }
        public static void StackExeuteExample()
        {
            var commandStack = new Stack<AppendTextCommand>();
            var commandStackRedo = new Stack<AppendTextCommand>();
            string originalText = "";

            while (true)
            {
                string input = "";
                Console.Write("Please text to append: ('exit to Exit' , 'undo to Undo' , 'redo to Redo') ");
                input = Console.ReadLine().Trim();
                
                // exit
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
                // undo
                else if (input.Equals("undo", StringComparison.OrdinalIgnoreCase))
                {
                    if (commandStack.Count > 0)
                    {
                        var command = commandStack.Pop();
                        commandStackRedo.Push(command);
                        originalText = command.Undo();
                    }
                    else
                        Console.WriteLine("nothing to undo");
                }
                // redo
                else if (input.Equals("redo", StringComparison.OrdinalIgnoreCase))
                {
                    if (commandStackRedo.Count > 0)
                    {
                        var command = commandStackRedo.Pop();
                        commandStack.Push(command);
                        originalText = command.Execute();
                    }
                    else
                        Console.WriteLine("nothing to redo");
                }
                // Append
                else
                {
                    var command = new AppendTextCommand(originalText, input);
                    originalText = command.Execute();
                    commandStack.Push(command);                }
            }

        }

    }

    class AppendTextCommand
    {
        private string _originalText;
        private readonly string _textToAppend;

        public AppendTextCommand(string originalText, string textToAppend)
        {
            this._originalText = originalText;
            this._textToAppend = textToAppend;
        }

        public string Execute()
        {
            _originalText += $"{_textToAppend} ";
            Console.WriteLine(_originalText);
            return _originalText;
        }

        public string Undo()
        {
            _originalText = _originalText.Substring(0, _originalText.Length - _textToAppend.Length);
            Console.WriteLine(_originalText);
            return _originalText;
        }
    }
}
