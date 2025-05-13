using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Command_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validcommands = new HashSet<string>
            {
                "list", "info", "mkdir", "md", "print", "write", "add", "remove", "exit", "create", "cd", "help", "clear"
            };

            while (true)
            {
                Console.WriteLine();
                Console.Write($"{Directory.GetCurrentDirectory()}> ");
                var input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                int WhiteSpaceIndex = input.IndexOf(' ');

                string command, Path;

                if (WhiteSpaceIndex == -1)
                {
                    command = input.ToLower();
                    Path = ""; // or null, depending on how you want to handle it
                }
                else
                {
                    command = input.Substring(0, WhiteSpaceIndex).ToLower();
                    Path = input.Substring(WhiteSpaceIndex + 1).Trim();
                }
                if (!validcommands.Contains(command))
                {
                    Console.WriteLine("Invalid command. Type 'help' if you need a list of available commands.");
                    continue;
                }

                if (command == "cd")
                {
                    if (Directory.Exists(Path))
                    {
                        Directory.SetCurrentDirectory(Path);
                    }
                    else
                    {
                        Console.WriteLine("The system cannot find the path specified.");
                    }
                }
                else if (command == "list")
                {
                    foreach (var Dir in Directory.GetDirectories(Path))
                        Console.WriteLine($"[Dir]: {Dir}");
                    foreach (var File in Directory.GetFiles(Path))
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
                    if (Directory.Exists(Path))
                    {
                        var DirInfo = new DirectoryInfo(Path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine($"Creation Time: {DirInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {DirInfo.LastWriteTimeUtc}");
                    }
                    else if (File.Exists(Path))
                    {
                        var FileInfo = new FileInfo(Path);
                        Console.WriteLine("Type: File");
                        Console.WriteLine($"Creation Time: {FileInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At: {FileInfo.LastWriteTimeUtc}");
                        Console.WriteLine($"File Size: {FileInfo.Length}");
                    }
                }
                else if (command == "mkdir" || command == "md")
                {
                    Directory.CreateDirectory(Path);
                    Console.WriteLine($"Directory created: {Path}");
                }
                else if (command == "print")
                {
                    if (File.Exists(Path))
                    {
                        var content = File.ReadAllText(Path);
                        Console.WriteLine(content);
                    }
                }
                else if (command == "write")
                {
                    if (File.Exists(Path))
                    {
                        Console.WriteLine("Enter Text: ");
                        var content = Console.ReadLine();
                        File.WriteAllText(Path, content);
                        Console.WriteLine($"File Modified: {Path}");
                    }
                }
                else if (command == "clear")
                {
                    Console.Clear();
                }
                else if (command == "add")
                {
                    if (File.Exists(Path))
                    {
                        Console.WriteLine("Enter Text: ");
                        var content = Console.ReadLine();
                        File.AppendAllText(Path, content);
                        Console.WriteLine($"File Modified: {Path}");
                    }
                }
                else if (command == "create")
                {
                    if (!File.Exists(Path))
                    {
                        File.Create(Path).Close(); // Create and close to release the file handle
                        Console.WriteLine($"File created: {Path}");
                    }
                    else
                    {
                        Console.WriteLine("File already exists.");
                    }
                }
                else if (command == "remove")
                {
                    // if (Directory.Exists(Path))
                    // Directory.Delete(Path, true); // delete dir and its subfolders
                    if (Directory.Exists(Path))
                    {
                        Directory.Delete(Path); // delete an empty directory
                        Console.WriteLine($"Directory removed: {Path}");
                    }
                    else if (File.Exists(Path))
                    {
                        File.Delete(Path);
                        Console.WriteLine($"File removed: {Path}");
                    }
                }
                else if (command == "exit")
                {
                    break;
                }
            }

        }
    }
}
