// 11. Perform a research and provide a short list with information about the most popular programming languages. How similar are they to C#? How do they differ from C#? 
// Sorry if there are unknown meterial, I've tried my best to explain the new stuff
using System;

namespace ProgrammingLanguages
{
    class ProgrammingLanguages
    {
        static void Main()
        {
            string[] ProgramLang = new string[5] {"Assembler", "C++", "Java", "PHP", "JavaScript"}; // standart string array of five elements
            byte index = 0;
            byte flag = 0;

            for (byte i = 0; i < ProgramLang.Length; i++) // standart loop that starts from 0 to the length of the array - 1 (in this case 4) 
            {
                Console.WriteLine("{0} language is {1}", i + 1, ProgramLang[i]); // the loop automatically writes string elements, from the array, containing the languages names
                index = i;
            }                                           // it uses its own counter to number the languages, starting from 1, without getting "out-of-boundaries" exception

            Console.WriteLine("{0} EXIT!", index + 2); 

            Console.WriteLine("\nThese are some of the most used programmming languages out there!\nAlthough, there are others like C, Objective-C, Basic, Delphi, Perl, etc.");

            do // do{}while() loop to ensure the program works until stopped
            {
                Console.WriteLine();

                Console.Write("Choose language (number 1-5): ");
                index = byte.Parse(Console.ReadLine()); // parsing the string that Console.ReadLine() function returns, to byte

                Console.WriteLine();

                switch(index) // switch multi-choice statement
                {
                    case 1: Console.WriteLine("Assembler is the lowest level language.\nIt's closer to machine code than any other programming language.");
                            Console.WriteLine("This makes it the hardest, but in the same time the fastest,\nlanguage to program in.");
                            Console.WriteLine("While C# is one of the languages with the highest level of abstraction,\nAssembler is being the one with the lowest!\n");
                        break;
                    case 2: Console.WriteLine("C++ is a compiled general purpose programming language.");
                            Console.WriteLine("It has imperative, object-oriented and generic programming features,");
                            Console.WriteLine("while also providing the facilities for low level memory manipulation.");
                            Console.WriteLine("Ït influenced both Java and C#.\n");
                        break;
                    case 3: Console.WriteLine("Java is a class-based object-oriented language.\nIt's syntax is based on C++, but instead being compiled directly,");
                            Console.WriteLine("it is compiled to bytecode and then interpred by JVM or compiled by JIT.");
                            Console.WriteLine("This allows application programs to be build that could be run on any platform.\nJava is the closest language to C#.");
                            Console.WriteLine("They both are class-based or \"pure\" OOP languages.\nThey both have built-in garbage collection and\nboth are said to be type-safe languages.");
                            Console.WriteLine("The difference between them, is that while Java is multi-platform language,\nC# is generally suitable for Windows.");
                        break;
                    case 4: Console.WriteLine("PHP is interpreted, but pre-compiled scripting language used in web development\nand generally in building web servers.");
                            Console.WriteLine("It can be used as general-purpose programming language,\nbut it isn't widely preffered.\nIt is influenced by C++ and Java,");
                            Console.WriteLine("so it shares common syntax and some OOP elements with them and respectively C#.");
                        break;
                    case 5: Console.WriteLine("JavaScript is a slow interpreted dynamic language used mostly in web browsers.");
                            Console.WriteLine("It is a multi-paradigm language, supporting object-oriented,\nimperative, and functional programming styles.");
                            Console.WriteLine("Its syntax was influenced by C, and copies some names\nand naming conventions from Java,");
                            Console.WriteLine("but the are different in any other aspect.");
                        break;
                    case 6: flag = 1;
                            Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter value between 1-6!"); // precautions if the input is outside the range (1-7)
                        break;
                }
            }
            while(flag == 0); // ends the loop if flag != 0
        }
    }
}
