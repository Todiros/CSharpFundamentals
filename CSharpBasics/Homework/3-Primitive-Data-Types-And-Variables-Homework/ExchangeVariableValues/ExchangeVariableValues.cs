//09. Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
//Print the variable values before and after the exchange.
//If you know a solution without third variable, please share it. :)
using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int firstVar = 5;
            int secondVar = 10;
            int tempVar = 0;

            Console.WriteLine("Before the exchange, the first variable is: {0}\nThe second variable is: {1}\n", firstVar, secondVar);

            tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;

            Console.WriteLine("After the exchange, the first variable is: {0}\nThe second variable is: {1}\n", firstVar, secondVar);
        }
    }
}
