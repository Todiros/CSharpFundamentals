// 06. Write a program that finds the biggest of five numbers by using only five if statements.  

using System;
class BiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        // I hope there is a better solution than this
        // Realised it has to be ">=" in order to get the first of two equal biggest numbers
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= c && b >= d && b >= e && b >= a)
        {
            Console.WriteLine(b);
        }
        else if (c >= d && c >= e && c >= a && c >= b)
        {
            Console.WriteLine(c);
        }
        else if (d >= e && d >= a && d >= b && d >= c)
        {
            Console.WriteLine(d);
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e);
        }
    }
}

