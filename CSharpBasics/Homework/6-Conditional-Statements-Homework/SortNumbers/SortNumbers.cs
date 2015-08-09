// 07. Write a program that enters 3 real numbers and prints them sorted in descending order.
using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("{0} {0} {0}", a);
        }
        else
        {
            if (a >= b && a >= c) // A
            {
                Console.Write("{0} ", a);

                if (b >= c)
                {
                    Console.Write("{0} {1}", b, c); // a, b, c                
                }
                else
                {
                    Console.Write("{0} {1}", c, b); // a, c, b
                }
            }
            if (b >= c && b >= a) // B
            {
                Console.Write("{0} ", b);

                if (c >= a)
                {
                    Console.Write("{0} {1}", c, a); // b, c, a
                }
                else
                {
                    Console.Write("{0} {1}", a, c); // b, a, c  
                }
            }
            if (c >= a && c >= b) // C
            {
                Console.Write("{0} ", c);

                if (a >= b)
                {
                    Console.Write("{0} {1}", a, b); // c, a, b
                }
                else
                {
                    Console.Write("{0} {1}", b, a); // c, b, a
                }
            }
        }

        Console.WriteLine("\n");
    }
}
