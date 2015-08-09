// 15. Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            int day = 0;
            int month = 0;
            int year = 0;

            Console.Write("Enter the day you were born: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter the month you were born: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year you were born: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine();

            DateTime birthDay = new DateTime(year, month, day);
            DateTime todaysDate = DateTime.Now;
            DateTime futureDate = todaysDate.AddYears(10);

            int myAge = futureDate.Year - birthDay.Year;

            if (todaysDate.Month <= birthDay.Month)
            {
                if (todaysDate.Day < birthDay.Day)
                {
                    myAge--;
                }
            }

            Console.WriteLine("In ten years you will be {0}\n", myAge);
        }
    }
}
