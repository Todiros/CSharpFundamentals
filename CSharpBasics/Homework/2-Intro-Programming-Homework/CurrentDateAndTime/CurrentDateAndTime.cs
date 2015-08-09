// 14. Create a console application that prints the current date and time. 
using System;

namespace CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The current date is {0}\n", date);
        }
    }
}
