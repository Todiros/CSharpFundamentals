//12. Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.
using System;

namespace NullValuesArithmetics
{
    class NullValuesArithmetics
    {
        static void Main()
        {
            int? intNullVar = null;
            double? doubleNullVar = 5;

            Console.WriteLine("Integer nullable variable: {0}\nDouble nullable variable: {1}\n", intNullVar, doubleNullVar);

            int? intNullVarSum = intNullVar + 15;
            double? doubleNullVarSum = doubleNullVar + 10.5;
            double? nullSum = doubleNullVarSum + intNullVarSum;

            Console.WriteLine("Integer nullable variable + 15: {0}\nDouble nullable variable + 10.5: {1}\nThe sum of both variables: {2}\n", intNullVarSum, doubleNullVarSum, nullSum);
        }
    }
}
