//07. Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings. 
//Print the variables to ensure that their value was correctly defined.
using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string withQuotation = "The \"use\" of quotations causes difficulties.";
            string withoutQuotation = @"The use of quotations causes difficulties.";

            Console.WriteLine("With quotation:\n{0}", withQuotation);
            Console.WriteLine("Without quotation:\n{0}", withoutQuotation);

            Console.WriteLine();
        }
    }
}
