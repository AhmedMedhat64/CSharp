using System.CodeDom.Compiler;
using System.Text;

namespace Csharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "CSharp Fundamentals"; // Title 
            /* lec_1 & 2
            Console.ForegroundColor = ConsoleColor.Blue; // Colors the all coming text 
            Console.Write("Hello, World!\n");
            Console.BackgroundColor = ConsoleColor.Magenta; // background color for all the program
            Console.Write("Hello, World!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey(); // waits for the user input 
            */

            /* lec_3
            // string static // (not valid) // static is key word 
            string @static = "Hello, World!"; // (valid) // static is varible not a key word  
            Console.WriteLine(@static);
            */

            /* lec_4
            Boolean isAlive = true; // Boolean (valid)
            bool isDead = !isAlive; // bool (valid)
            //Console.Write("is Alive = ");
            //Console.WriteLine(isAlive);
            //Console.Write("is Alive = ");
            //Console.WriteLine(isDead);
            //// must iterate on all the members
            //bool result1 = isAlive & isDead;
            //// stops with the first false member => better performance
            //bool result2 = isAlive && isDead;
            bool result = isAlive ^ isDead; // XOR Gate
            // true , true => false
            // true , false => true
            // false , false => false
            // false , true => true
            */

            /* lec_5
             * console.Read (بتقرأ حرف حرف)
             * console.ReadLine (بتقرأ النص كله) (All the string)
            // A-> 65 , (A)BC-> 65
            int c = Console.Read();
            Console.WriteLine(c);
            char a = 'A';
            // typecasting
            Console.WriteLine((int)a);
            int r = 1;
            for (char i = 'A', j = 'a' ; i <= 'Z' ; i++, j++, r++)
            {
                Console.Write("#" + r + "  ");
                if (r < 10)
                {
                    Console.Write(" ");
                }
                Console.Write("ASCII " + i + " = ");
                Console.Write((int)i);
                Console.Write("     ");
                Console.Write("ASCII " + j + " = ");
                Console.WriteLine((int)j);
                if (i == 'Z')
                {
                    for ( int a = 0; a < 10; a++)
                    {
                        Console.WriteLine(a);
                    }
                }
            } */

            // char built in methods 
            // #1 (IsDigit)
            /* Indicates whether the specified Unicode character is categorized as a decimal digit.
            char ch = '8';
            Console.WriteLine(Char.IsDigit(ch));            // Output: "True"
            // Indicates whether the character at the specified position in a specified string is categorized as a decimal digit.
            for (int i = 0; i < 13; i++)
            {
                bool x = Char.IsDigit("sample 5tring", i); // output 7 (5)tring
                if (x == true) { 
                    Console.WriteLine(i);
                }
            }
            // #1, 2, 3, 4, 5, 6, 7, 8
            1- IsDigit , 2- IsLetter , 3- IsLetterOrDigit , 4- IsWhiteSpace , 5- IsUpper , 6- IsLower , 7- IsPunctuation , 8- toUpper , 9- toLower 
            */ /*
            string Text = Console.ReadLine();
            string[] Methods = { "IsDigit", "IsLetter", "IsLetterOrDigit", "IsWhiteSpace", "IsUpper", "IsLower", "IsPunctuation" };
            int[] counts = new int[Methods.Length];
            for (int i = 0; i < Text.Length; i++)
            {
                if (char.IsDigit(Text[i]))
                {
                    counts[0]++;
                }
                if (char.IsLetter(Text[i]))
                {
                    counts[1]++;
                }
                if (char.IsLetterOrDigit(Text[i]))
                {
                    counts[2]++;
                }
                if (char.IsWhiteSpace(Text[i]))
                {
                    counts[3]++;
                }
                if (char.IsUpper(Text[i]))
                {
                    counts[4]++;
                    // string is immutable => (can't be changed)
                    // هنا خزنت الحرف في متغير عشان اعرف اطبع الحرف بعد لما يتغير
                    //char temp = char.ToLower(Text[i]);
                    //Console.Write(temp + " ");


                    // دي بالظبط نفس الناتج بس طريقة مختلفة
                    Console.Write(char.ToLower(Text[i]) + " ");

                    // output: a H M E D m E D H A T g M A I L C O M
                }
                if (char.IsLower(Text[i]))
                {
                    counts[5]++;
                    // string is immutable => (unchangeble)
                    // هنا خزنت الحرف في متغير عشان اعرف اطبع الحرف بعد لما يتغير
                    //char temp = char.ToUpper(Text[i]);
                    //Console.Write(temp + " ");

                    // دي بالظبط نفس الناتج بس طريقة مختلفة
                    Console.Write(char.ToUpper(Text[i]) + " ");

                    // output: a H M E D m E D H A T g M A I L C O M
                }
                if (char.IsPunctuation(Text[i]))
                {
                    counts[6]++;
                }

            }
            Console.WriteLine("\n" + Text);
            for (int i = 0; i < counts.Length; i++) { 
                Console.WriteLine($"{Methods[i]}count: {counts[i]}");
            } */

            /* lec_6
            Console.WriteLine("Hallo,\tWorld!");  // output: Hallo,  World! 
            Console.WriteLine("Hallo,\\tWorld!"); // output: Hallo,\tWorld! (\ => skip character)
            string hallo = "Hallo"; 
            string world = " world";
            Console.WriteLine(hallo + world); // output: Hallo World => concatination 
            Console.WriteLine("Hallo" + "World"); // output: Hallo World => concatination 
            Console.WriteLine("Hallo" + 5); // output: Hallo World => concatination (valid)
            // Console.WriteLine("Hallo" - 5); // output: Hallo World => concatination (Not valid)
            // multiple line string (@)
            Console.WriteLine(@"Ahmed  
                                medhat
                                mostafa");
            // templates
            string name = "Ahmed ";
            Console.WriteLine($"Welcome {name} to out C# course"); */

            /* lec_7
            string name = "Ahmed ";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.StartsWith("AH")); // output: False
            Console.WriteLine(name.StartsWith("AH", StringComparison.OrdinalIgnoreCase)); // output: True
            Console.WriteLine(name.EndsWith("ed")); // output: True
            Console.WriteLine(name.EndsWith("ED", StringComparison.OrdinalIgnoreCase)); // output: True
            Console.WriteLine(name.Contains("ED")); // output: False
            Console.WriteLine(name.Contains("ED", StringComparison.OrdinalIgnoreCase)); // output: True
            Console.WriteLine(name.IndexOf("A")); // output: 0 ((A)hmed)
            Console.WriteLine(name.IndexOf("X")); // output: -1
            string name1 = " Mohammed";
            Console.WriteLine(name1.LastIndexOf("M")); // output: 0 (M)ohammed
            Console.WriteLine(name1.LastIndexOf("M", StringComparison.OrdinalIgnoreCase)); // output: 5 Moham(m)ed
            Console.WriteLine(name1.LastIndexOf("X")); // output: -1
            string name2 = name + name1; // Ahmed Mohammed
            Console.WriteLine(name2.Replace(name1, name)); // output: Ahmed Ahmed
            name2 = Console.ReadLine(); // input Ahmed Mohamed
            // output: Ahmed Medhat
            Console.WriteLine(name2.Replace("mohamed", "Medhat", StringComparison.OrdinalIgnoreCase)); 
            * StringComparison.OrdinalIgnoreCase)
            * (ToLower, Length, ToUpper) فيهم كلهم ما عدا  
            */

            /* practice 
            Console.Write("Enter the original Name: ");
            string OriginalName =  Console.ReadLine();
            Console.Write("Enter the name You want to replace: ");
            string ReplacedName =  Console.ReadLine();
            Console.Write("Enter a to replace with: ");
            string ReplacingName = Console.ReadLine();
            Console.WriteLine(OriginalName.Replace(ReplacedName, ReplacingName, StringComparison.OrdinalIgnoreCase));
            */

            /* lec_8 
            Console.WriteLine($"short memory size: {sizeof(short)}");       // output: short memory size: 2
            Console.WriteLine($"short MinValue: {short.MinValue}");         // output: short Min memory size: -32768
            Console.WriteLine($"short MaxValue: {short.MaxValue}");         // output: short Max memory size: 32767
            Console.WriteLine("-------------------");
            Console.WriteLine($"ushort memory size: {sizeof(ushort)}");     // output: ushort memory size: 2
            Console.WriteLine($"ushort MinValue: {ushort.MinValue}");       // output: ushort MinValue: 0
            Console.WriteLine($"ushort MaxValue: {ushort.MaxValue}");       // output:  ushort MaxValue: 65535
            Console.WriteLine("-------------------");
            Console.WriteLine($"long memory size: {sizeof(long)}");         // output: long memory size: 8
            Console.WriteLine($"long MinValue: {long.MinValue}");           // output: long MinValue: -9223372036854775808
            Console.WriteLine($"long MaxValue: {long.MaxValue}");           // output: long MaxValue: 9223372036854775807
            Console.WriteLine("-------------------");
            Console.WriteLine($"ulong memory size: {sizeof(ulong)}");       // output: ulong memory size: 8
            Console.WriteLine($"ulong MinValue: {ulong.MinValue}");         // output: ulong MinValue: 0   
            Console.WriteLine($"ulong MaxValue: {ulong.MaxValue}");         // output: ulong MaxValue: 18446744073709551615   
            Console.WriteLine("-------------------");
            Console.WriteLine($"uint memory size: {sizeof(uint)}");         // output: uint memory size: 4 
            Console.WriteLine($"uint MinValue: {uint.MinValue}");           // output: uint MinValue: 0
            Console.WriteLine($"uint MaxValue: {uint.MaxValue}");           // output: uint MaxValue: 4294967295
            Console.WriteLine("-------------------");
            Console.WriteLine($"int memory size: {sizeof(int)}");           // output: int memory size: 4
            Console.WriteLine($"int MinValue: {int.MinValue}");             // output: int MinValue: -2147483648
            Console.WriteLine($"int MaxValue: {int.MaxValue}");             // output: int MaxValue: 2147483647
            Console.WriteLine("-------------------");
            Console.WriteLine($"float memory size: {sizeof(float)}");       // output: float memory size: 4 
            Console.WriteLine($"float MinValue: {float.MinValue}");         // output: float MinValue: -3.4028235E+38 
            Console.WriteLine($"float MaxValue: {float.MaxValue}");         // output: float MaxValue: 3.4028235E+38
            Console.WriteLine("-------------------");
            Console.WriteLine($"double memory size: {sizeof(double)}");     // output: double memory size: 8
            Console.WriteLine($"double MinValue: {double.MinValue}");       // output: double MinValue: -1.7976931348623157E+308 
            Console.WriteLine($"double MaxValue: {double.MaxValue}");       // output: double MaxValue: 1.7976931348623157E+308
            */

            /* lec_9 -> arithmatic operations 
            int x = 25; 
            int y = 10;
            double s = 5;
            var z = x / y; // z -> int  // input بيحدد نوع المتغير علي حسب ال
            var z1 = y / s; // z1 -> double  
            */

            /* lec_10 Operator Precedence 
             * () (* / %) (+ -) 
             */

            /* lec_11&12  Assignment Operators & Increment & Decrement
             * int x = 5
             * x = x + 5; -> 10
             * x += 5 , x -> 10 
             * x++ Console.WriteLine(x++) -> 5 , x = 6
             * x-- Console.WriteLine(x--) -> 5 , x = 4
             * ++x Console.WriteLine(x++) -> 6 , x = 6
             * --x Console.WriteLine(x--) -> 4 , x = 4
             */

            /* lec_13 Comparison Operators 
             * (==, !=, >=, <=, >, <) 
             */

            /* lec_14 string conversion تحويل النص 
            // (DataType.Parse) 
            string year = Console.ReadLine(); // input: 2005 
            Console.WriteLine(year + 100); // output: 2005 + 100 -> 2005100
            int ModifiedYear = int.Parse( year );
            Console.WriteLine(ModifiedYear + 100); // output: 2005 + 100 -> 2105
            */

            /* lec_15 if statement */

            /* lec_16 Debugger 
             * Breakpoints (F9, clk right -> Breakpoint -> Insert Breakpoint)
             * Step over (F10, Debug -> Strp Over)
             * Locals Window (Ctl+alt+v, l // Debug -> Windows -> Locals)
             * Watches (Clk left on any variable -> Add Watch, from Watch Window -> Add item to watch (vari name) )
             * Watches Con.. ( Debug -> window -> Watch (Watch1, Watch2, ....etr) 
             
            Console.Write("Enter a numebr: "); 
            string number = Console.ReadLine();
            int ParsedNumber = int.Parse(number);
            int remainder = ParsedNumber % 2;

            if (remainder == 1)
            {
                Console.WriteLine($"{number} is odd"); 
            }
            else if (ParsedNumber == 0)
            {
                Console.WriteLine($"{number} is Neitheer odd Nor even");
            }
            else
            {
                Console.WriteLine($"{number} is even");
            } */

            /*
            int[] Numbers = new int[10] ;
            
            // Display a message about reading and printing elements of an array
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");  // Prompt user to input 10 elements

            // Loop to read 10 elements from the user and store them in the array
            for (int i = 0; i < 10; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());  // Read user input and convert it to an integer, then store in the array
            }

            int[] SortedNumbers = new int[10];
            //SortedNumbers = int.Parse(Numbers);

            Array.Copy(Numbers, SortedNumbers, Numbers.Length);
            Array.Sort(SortedNumbers);

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"unSortedArray:# {i + 1}: { Numbers[i] }\t\tSortedArray:# {i + 1}: {SortedNumbers[i]}");
            }

            Console.Write("\nElements in array are: ");  // Display message before printing array elements

            // Loop to print the elements of the array
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", SortedNumbers[i]);  // Print each element of the array
            } */


            /* lec_29 
            Console.Write("Enter ArraySize: ");
            int ArrSize = int.Parse(Console.ReadLine());
            int[] numbers = new int[ArrSize];
            int Max = int.MinValue, Min = int.MaxValue;

            for (int i = 0; i < ArrSize; i++)
            {
                Console.Write("Enter number - {{0}}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());  
            }

            for (int i = 0; i < ArrSize; i++)
            {
                
                if (Max < numbers[i])
                {
                    Max = numbers[i]; 
                }

                if (Min > numbers[i])
                {
                    Min = numbers[i];
                }
            }

            Console.WriteLine("Max Numbers in the array is: " + Max);
            Console.WriteLine("Min Numbers in the array is: " + Min);
            */

            /* palindrome word lec_30 

            
            while (true) {
                // string.Empty to create a string without intionlization
                
                // 1st solution stringComparison (bad Performance -> can lead to Memory leak)
                    string word , Rev_Word = string.Empty;
                    Console.Write("Enter a word to check: ");
                    word = Console.ReadLine();

                    // to input an Empty string and then use .Equals() method
                    for (int i = 0; i < word.Length ; i++)
                    {
                     // (bad Performance -> can lead to Memory leak)
                        Rev_Word += word[word.Length - i - 1];
                    }
                    bool IsEqual = Rev_Word.Equals(word, StringComparison.OrdinalIgnoreCase);

                    //Multi_Line ternary statement               
                    string statement;
                    statement = IsEqual ? $"{word} is a palindrome word" : $"{word} is not a palindrome word";
                    Console.WriteLine(statement);
                    // Singil_Line ternary statement  
                    Console.WriteLine(IsEqual ? $"{word} is a palindrome word" : $"{word} is not a palindrome word");
                

                    2nd solution
                    string word;
                    Console.Write("Enter a word to check: ");
                    word = Console.ReadLine();
                    string Rev_Word = word.ToLower();
                    bool IsPalindrome = false;
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if ((Rev_Word[i] != Rev_Word[word.Length - i - 1]))
                        {
                            IsPalindrome = false; break;
                        }
                    }
                    Console.WriteLine(!IsPalindrome ? $"{word} is a palindrome word" : $"{word} is not a palindrome word");
                
                    3rd solution 
                    string word; 
                    Console.Write("Enter a word to check: ");
                    word = Console.ReadLine();
                    string Rev_Word = word.ToLower();
                    bool IsPalindrome = true;
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if ((Rev_Word[i] != Rev_Word[word.Length - i - 1]))
                        {
                            IsPalindrome = false;
                            break;
                        }
                    }

                    Console.WriteLine(IsPalindrome ? $"{word} is a palindrome word" : $"{word} is not a palindrome word");
                

            } */
            /* lec_31 stack -> value / refrence -> heab */

            /* lec_32 typecasting / ToString to convert to string */

            /* lec_33 string formating
             *  Basic Formating {0}, {1}, {2} -> Placeholders
             *  control spacing  {0, 15} , {1, 12}
             *  Format Arguments (0.00, N2, C2, X2)
             *  0.00
             *  N2 -> N10 
             *  C2 -> C10
             *  X2 -> X10 Hexadecimal

            string str = "hello {0}, My name is {1}";
            Console.WriteLine(str);
            
            Console.WriteLine("---------------");

            str = "hello {0}, My name is {1} --- {0} ";
            str = string.Format(str, "Ahmed", "Mohamed");
            Console.WriteLine(str);
            
            Console.WriteLine("---------------");

            str = "hello, My name is {1} --- {0} ";
            str = string.Format(str, "Ahmed", "Mohamed");
            Console.WriteLine(str);

            Console.WriteLine("---------------");
            
            str = "hello, My name is {0} {0} ";
            str = string.Format(str, "Ahmed", "Mohamed");
            Console.WriteLine(str);
            
            Console.WriteLine("---------------");
            
            str = "hello, My name is {1} {1} ";
            str = string.Format(str, "Ahmed", "Mohamed");
            Console.WriteLine(str);

            Console.WriteLine("---------------");

            str = "hello, My name is {0, 15} {1, 12} "; // control spacing 
            str = string.Format(str, "Ahmed", "Mohamed");
            Console.WriteLine(str);

            double salary = 10000;

            string str1 = "your salary is {0: 0.00}"; // without (, & $) your salary is 10000.00
            str1 = string.Format(str1, salary); 
            Console.WriteLine(str1);

            string str2 = "your salary is {0:N2}"; // with (,) but without ($)  N -> Number // your salary is 10,000.00
            str2 = string.Format(str2, salary);
            Console.WriteLine(str2);

            string str3 = "your salary is {0:C2}"; // with (,) and ($) C -> Currency // your salary is $10,000.00
            str3 = string.Format(str3, salary);
            Console.WriteLine(str3); */


            /* lec_34  Split() , Join() 
            Console.Write("Enter Numebrs seperated with spaces: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");

            int sum = 0;
            foreach (string number in numbers)
            {
                sum += int.Parse(number); 
            }

            Console.WriteLine("Avarage: " + sum / numbers.Length);


            string output = string.Join(", ", numbers);

            Console.WriteLine(output); */

            /* lec_35 StringBuilder 

            StringBuilder sb = new StringBuilder();
            sb.Append("Ahmed ");
            sb.AppendLine("Medhat");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.MaxCapacity); */





            /* lec-36  Classes and objects 
             * to make a new class press (shift + F2)
             

            //Student[] stds = new Student[10];
            //Student Ahmed = new Student("Ahmed");
            //Console.Write("Enter your Name: ");
            //Ahmed.Name = Console.ReadLine();
            //Console.Write("Enter your PhoneNumebr: ");
            //Ahmed.PhoneNumebr = Console.ReadLine();
            //Console.Write("Enter your Address: ");
            //Ahmed.Address = Console.ReadLine();

            //stds[0] = Ahmed;
            //Student name = new Student { Name = "Ahmed", PhoneNumebr = "0121024" };*/


            /* namespaces like #include"ClassName" in C++
             * it is the bast practice 
             * it is also the path of the project 
             */

            /* Access modifiers
             * public -> all 
             * internal -> the same project
             * private - > just in its class 
             */


            /*
             * const and read_only
             * constants are static by default
             * 1. const is unchangalbe while read_only is (only in the constructor)
             * 2. const is a compile time constant while read_only is runtime constant 
             * 3. const must be intialized in the same line with the declaration while read_only
             * (can be assigned in the same line like const and also infine times in the constructor)
             */


            /* static 
                // static Class and Static Method
                Class1.Ahmed();

                // Non_static Class and Static Method
                Class2 Ahmed2 = new Class2();
                Class2.Ahmed2();
            */


            /*
             * ref must be insitilized 
             * out must assign a value in every branch of code
             

            TestRef();
            TestOut();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            

            int num = 0;
            Console.Write("Enter any number: ");
            var result = int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"num: {num}");

            Console.WriteLine("\n\n================================\n");

            Console.Write("Enter any number: ");
            var IsSucsessful = float.TryParse(Console.ReadLine(), out float number);
            Console.WriteLine($"result: {IsSucsessful}");
            Console.WriteLine($"num: {number}");

            */




            //private static void TestRef()
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    // IsSuccessful must be insitilized (ref)
            //    // bool IsSuccessful;
            //    bool IsSuccessful =  true;
            //    var result = DivideRef(10, 0, ref IsSuccessful);
            //    Console.WriteLine($"IsSuccessful: {IsSuccessful}");
            //    Console.WriteLine($"result: {result}");
            //}

            //static double DivideRef(double number, double divisor, ref bool IsSuccessful)
            //{
            //    if (divisor == 0)
            //    {
            //        IsSuccessful = false;
            //        return 0;
            //    }

            //    IsSuccessful = true;
            //    return number / divisor;
            //}

            //private static void TestOut()
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    bool IsSuccessful = true;
            //    var result = DivideOut(10, 0, out IsSuccessful);
            //    Console.WriteLine($"IsSuccessful: {IsSuccessful}");
            //    Console.WriteLine($"result: {result}");
            //}


            //static double DivideOut(double number, double divisor, out bool IsSuccessful)
            //{
            //    if (divisor == 0)
            //    {
            //        // IsSuccessful (out must assign a value in every branch of code)
            //        // IsSuccessful;
            //        IsSuccessful = false;
            //        return 0;
            //    }

            //    // IsSuccessful (out must assign a value in every branch of code)
            //    // IsSuccessful;
            //    IsSuccessful = true;
            //    return number / divisor;
            //}


            /* try catch finally self_Exeption 

            Console.ForegroundColor = ConsoleColor.Yellow;

            try
            {
                Console.Write("Enter a five_character_string: ");
                var input = Console.ReadLine();

                if (input.Length != 5)
                    throw new Exception("You must enter a five_character string ");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            catch (Exception ex)
            {
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

            }

            */

            //Gender gender = Gender.Male;
            //Gender gender1 = Gender.Female;

            //Gender g1 = new Gender();
            //g1 = Gender.Male;

            //Gender g2 = new Gender();
            //g2 = Gender.Female;

            //foreach(var sex in Enum.GetNames(typeof(Gender)))
            //    Console.WriteLine($"{sex.ToString()}: {(int)Enum.Parse(typeof(Gender), sex)}");

            //while (true)
            //{
            //    Console.WriteLine("Choose one option");
            //    Console.WriteLine("[1] BackGroundColor \t [2] ForeGroundColor");
            //    string input = Console.ReadLine();


            //    foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
            //        Console.WriteLine(color);
            //    Console.WriteLine("Choose a color");

            //    string ChosenColor = Console.ReadLine();

            //    ConsoleColor ConvertColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ChosenColor, true);

            //    if (input == "1")
            //        Console.BackgroundColor = ConvertColor;
            //    else if (input == "2")
            //        Console.ForegroundColor = ConvertColor;
            //}

            /* Flags enums
             * (| or 
             *  & and 
             *  ~ apart from 
             *  ^ toggle -> if exist then remove, if not exist then add)
            
            

            WeekDays w = new WeekDays();
            w = WeekDays.Friday;
            WeekDays w1 = WeekDays.Monday;
            
            WeekDays w2 = WeekDays.Monday | WeekDays.Thesday | WeekDays.Sunday | WeekDays.Friday;
            WeekDays w3 = WeekDays.Monday | WeekDays.Wednesday | WeekDays.Saturday ;
            Console.WriteLine("---------------------------");
            Console.WriteLine(w);  // Friday
            Console.WriteLine("---------------------------");
            Console.WriteLine(w1); // Monday 
            Console.WriteLine("---------------------------");
            Console.WriteLine(w2); // Sunday, Monday, Thesday, Friday
            Console.WriteLine("---------------------------");
            Console.WriteLine(w2 | w3); // Saturday, Sunday, Monday, Thesday, Wednesday, Friday
            Console.WriteLine("---------------------------");
            Console.WriteLine(w2 & w3); // Monday
            Console.WriteLine("---------------------------");

            bool IsFriday = WeekDays.Friday == (w2 & WeekDays.Friday); // True
            Console.WriteLine(IsFriday);
            Console.WriteLine("---------------------------");
            bool IsSunday = (w3 & WeekDays.Sunday) == WeekDays.Sunday; // False 
            Console.WriteLine(IsSunday);
            Console.WriteLine("---------------------------");
            Console.WriteLine(w3 & WeekDays.Sunday); // None 
            Console.WriteLine("---------------------------");

            // Wasnot kept in memory 
            // W2 wasnot changed
            Console.WriteLine(w2 & ~WeekDays.Sunday); // Monday, Thesday, Friday
            Console.WriteLine("---------------------------");

            Console.WriteLine(w2); // Sunday, Monday, Thesday, Friday
            Console.WriteLine("---------------------------");
            var w4 = w2 ^ WeekDays.Sunday;
            Console.WriteLine(w4); // Monday, Thesday, Friday
            Console.WriteLine("---------------------------");
            var w5 = w4 ^ WeekDays.Sunday;
            Console.WriteLine(w5); // Sunday, Monday, Thesday, Friday  
            */

            Console.ForegroundColor = ConsoleColor.Yellow;

            while (true)
            {
                Console.WriteLine("please select an option: ");
                Console.WriteLine("[1] GeneratedRandomNumber\t [2] GenerateRandomString");
                string selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    Console.WriteLine("Enter the Boundaries (Min, Max)");
                    int Min = int.Parse(Console.ReadLine());
                    int Max = int.Parse(Console.ReadLine());
                    GeneratedRandomNumber(Min, Max);
                }
                else if (selectedOption == "2")
                {
                    Console.WriteLine("Enter the Buffer Size");
                    GenerateRandomString(int.Parse(Console.ReadLine()));
                }
            }
        }

        static void GeneratedRandomNumber(int Min, int Max)
        {
            var rnd = new Random();
            int value = rnd.Next(Min, Max);

            Console.WriteLine($"Dandom value: {value}");
        }

        static void GenerateRandomString(int length)
        {
            var CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var SmallLetters =  "abcdefghijklmnopqrstuvwxyz";
            var Numbers = "0123456789";
            var Symbols = "~!@#$%^&*()_{}|?";

            Console.WriteLine("Choose What you want to include: ");
            Console.WriteLine("[1] CapitalLetters\t [2] SmallLetters");
            Console.WriteLine("[3] Numbers\t [4] Symbols");

            string Included = Console.ReadLine();
            if (Included == null)
                Included = "1234";

            var ConcatinatedString = new StringBuilder();

            if (Included.Contains('1')) ConcatinatedString.Append(CapitalLetters);
            if (Included.Contains('2')) ConcatinatedString.Append(SmallLetters);
            if (Included.Contains('3')) ConcatinatedString.Append(Numbers);
            if (Included.Contains('4')) ConcatinatedString.Append(Symbols);

            if (ConcatinatedString.Length == 0)
            {
                throw new Exception($"Invalid option: {Included}");
            }


            var sb = new StringBuilder();
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                var randomIndex = rnd.Next(0, ConcatinatedString.Length);
                sb.Append(ConcatinatedString[randomIndex]);
            }

            Console.WriteLine($"Random String: {sb}");
        }


        //[Flags]
        //public enum WeekDays
        //{
        //    //None =      0b_0000_0000,
        //    //Saturday =  0b_0000_0001,
        //    //Sunday =    0b_0000_0010,
        //    //Monday =    0b_0000_0100,
        //    //Thesday =   0b_0000_1000,
        //    //Wednesday = 0b_0001_0000,
        //    //Thursday =  0b_0010_0000,
        //    //Friday =    0b_0100_0000

        //    None = 0,
        //    Saturday = 1,
        //    Sunday = 2,
        //    Monday = 4,
        //    Thesday = 8,
        //    Wednesday = 16,
        //    Thursday = 32,
        //    Friday = 64
        //}

        //public enum Gender
        //{
        //    Male,
        //    Female,
        //}
    }
}


