//12. Perform a research and provide a short list with popular development environments (IDEs) like Visual Studio. 
// Write in a text file called at least five IDEs along with 2-3 sentences about each of them. Use English.
//13. Describe the difference between C# and .NET Framework in 2-3 sentences. Use English.
// If you have trouble understanding some methods, look at problem 11.
// The PDF files can be found in folder: 1-Intro-Programming-Homework\OpenFiles\bin\Debug
using System;

namespace OpenFiles
{
    class OpenFiles
    {
        static void Main()
        {
            int input;
            int flag = 0;

            do
            {
                Console.WriteLine("1. Open exercize 12.Compare Different IDEs.");
                Console.WriteLine("2. Open exercize 13.Compare C# and .NET Framework");
                Console.WriteLine("3. Exit");

                Console.Write("Enter the number coresponding to your choosen option: ");
                input = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        System.Diagnostics.Process.Start(@"12.IDEsComparison.pdf"); // .NET method that allows executing processes during runtime   
                        break;
                    case 2:
                        System.Diagnostics.Process.Start(@"13.CSharpDotNet.pdf");
                        break;
                    case 3:
                        flag = 1;
                        Environment.Exit(0); 
                        break;
                    default:
                        Console.WriteLine("\nEnter Integer value between 1 and 3!\n");
                        break;
                }
            } while (flag == 0); 

        }
    }
}
