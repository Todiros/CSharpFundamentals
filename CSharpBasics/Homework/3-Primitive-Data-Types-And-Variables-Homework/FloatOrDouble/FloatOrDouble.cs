// 02. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
// 34.567839023, 12.345, 8923.1234857, 3456.091?
using System;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            float firstFloatNum = 12.345f;
            float secondFloatNum = 3456.091f;
            double firstDoubleNum = 34.567839023;
            double secondDoubleNum = 8923.1234857;

            Console.WriteLine("Float numbers are {0} and {1}", firstFloatNum, secondFloatNum);
            Console.WriteLine("Double numbers are {0} and {1}", firstDoubleNum, secondDoubleNum);
        } 
    }
}
