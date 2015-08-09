// 11. A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
// (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
// and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed.

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        string inputTime = Console.ReadLine();
        DateTime time = new DateTime();
        int hours = 0;

        try // it tries the statement and checks whether it will throw exception
        {
            //time = DateTime.ParseExact(inputTime, "hh:mm tt", CultureInfo.InvariantCulture);
            time = DateTime.Parse(inputTime);

        }
        catch (FormatException) // if the exception in the brackets is thrown, it will "handle" it and execute the statements in the curly brackets
        {
            Console.WriteLine("invalid time");
            Environment.Exit(0);
        }

        hours = time.Hour;

        if (hours < 3 || hours >= 13)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}
