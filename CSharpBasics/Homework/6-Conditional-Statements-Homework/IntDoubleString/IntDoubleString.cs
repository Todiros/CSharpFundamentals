// 09. Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
// If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
// Print the result at the console.

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("choice: ");
        byte choice = byte.Parse(Console.ReadLine());

        int intVar = 0;
        double doubleVar = 0;
        string stringVar = "";

        switch (choice)
        {
            case 1: 
                Console.Write("Please, enter an integer: ");
                intVar = int.Parse(Console.ReadLine());

                intVar++;

                Console.WriteLine(intVar);
                break;
            case 2: 
                Console.Write("Please, enter a double: ");
                doubleVar = double.Parse(Console.ReadLine());

                doubleVar++;

                Console.WriteLine(doubleVar);
                break;
            case 3: 
                Console.Write("Please, enter a string: ");
                stringVar = Console.ReadLine();

                stringVar = stringVar + "*";

                Console.WriteLine(stringVar);
                break;
        }
    }
}
