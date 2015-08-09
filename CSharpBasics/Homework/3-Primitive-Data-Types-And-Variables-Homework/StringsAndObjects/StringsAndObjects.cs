//06. Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables.
//Declare a third string variable and initialize it with the value of the object variable
using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string helloVar = "Hello";
            string worldVar = "World!";

            object helloWorldObject = helloVar + " " + worldVar;

            string helloWorldString = (string)helloWorldObject;

            Console.WriteLine(helloWorldString);
        }
    }
}
