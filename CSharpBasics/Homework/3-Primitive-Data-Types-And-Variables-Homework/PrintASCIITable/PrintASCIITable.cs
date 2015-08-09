using System;

namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            char asciiSymbol = ' ';

            for (int i = 0; i < 255; i++)
            {
                asciiSymbol = (char)i;
                Console.Write(asciiSymbol.ToString().PadRight(5));
            }

            Console.WriteLine("\n");
        }
    }
}
