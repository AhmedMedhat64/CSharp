using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;

namespace Command_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validcommands = new HashSet<string>
            {
                "list", "info", "mkdir", "md", "print", "write", "append", "rmdir", "exit", "create", "cd", "help", "clear","del", "erase"
            };

            Console.WriteLine();
            Directory.SetCurrentDirectory(@"C:\Users\Ahmood");
            Console.Write(Directory.GetCurrentDirectory() + "> ");

            while (true)
            {
                
                var input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                int WhiteSpaceIndex = input.IndexOf(' ');

                string path, command;

                if (WhiteSpaceIndex == -1)
                {
                    command = input.ToLower();
                    path = ""; // or null, depending on how you want to handle it
                }
                else
                {
                    command = input.Substring(0, WhiteSpaceIndex).ToLower();
                    path = input.Substring(WhiteSpaceIndex + 1).Trim();
                }
                //if (!validcommands.Contains(command))
                //{
                //    Console.WriteLine("Invalid command. Type 'help' if you need a list of available commands.");
                //    continue;
                //}

                if (command == "cd")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.SetCurrentDirectory(path);
                    }
                    else
                    {
                        Console.WriteLine("The system cannot find the path specified.");
                    }
                }
                else if (command == "list")
                {
                    foreach (var Dir in Directory.GetDirectories(path))
                        Console.WriteLine($"[Dir]: {Dir}");
                    foreach (var File in Directory.GetFiles(path))
                        Console.WriteLine($"[File]: {File}");

                }
                else if (command == "help")
                {
                    Console.Write("Commands: ");
                    foreach (var cmd in validcommands)
                    {
                        Console.Write($"{cmd}, ");
                    }
                    Console.WriteLine();
                }
                else if (command == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var DirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine($"Creation Time: {DirInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {DirInfo.LastWriteTimeUtc}");
                    }
                    else if (File.Exists(path))
                    {
                        var FileInfo = new FileInfo(path);
                        Console.WriteLine("Type: File");
                        Console.WriteLine($"Creation Time: {FileInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {FileInfo.LastWriteTimeUtc}");
                        Console.WriteLine($"File Size: {FileInfo.Length}");
                    }
                }
                else if (command == "mkdir" || command == "md")
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Directory created: {path}");
                }
                else if (command == "print")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                }
                else if (command == "write")
                {
                    if (File.Exists(path))
                    {
                        Console.WriteLine("Enter Text: ");
                        var content = Console.ReadLine();
                        File.WriteAllText(path, content);
                        Console.WriteLine($"File Modified: {path}");
                    }
                }
                else if (command == "clear")
                {
                    Console.Clear();
                }
                else if (command == "append")
                {
                    if (File.Exists(path))
                    {
                        Console.WriteLine("Enter Text: ");
                        var content = Console.ReadLine();
                        File.AppendAllText(path, content);
                        Console.WriteLine($"File Modified: {path}");
                    }
                }
                else if (command == "create")
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path).Close(); // Create and close to release the file handle
                        Console.WriteLine($"File created: {path}");
                    }
                    else
                    {
                        Console.WriteLine("File already exists.");
                    }
                }
                else if (command == "rmdir")
                {
                    // if (Directory.Exists(path))
                    // Directory.Delete(path, true); // delete dir and its subfolders
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path); // delete an empty directory
                        Console.WriteLine($"Directory removed: {path}");
                    }
                    else
                    {
                        Console.WriteLine("Directory was not found");
                    }
                }
                else if (command == "del" || command == "erase")
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                        Console.WriteLine($"File removed: {path}");
                    }
                    else
                    {
                        Console.WriteLine("File was not found");
                    }
                }
                else if (command == "sloc")
                {
                    Console.Write("Enter Directory Location: ");
                    var temp = Console.ReadLine();
                    if (Directory.Exists(temp))
                    {
                        path = temp;
                    }
                    Directory.SetCurrentDirectory(path);
                }
                else if (command == "exit")
                {
                    break;
                }

                Console.WriteLine();
                Console.Write(Directory.GetCurrentDirectory() + "> ");
            }

        }
    }
}
