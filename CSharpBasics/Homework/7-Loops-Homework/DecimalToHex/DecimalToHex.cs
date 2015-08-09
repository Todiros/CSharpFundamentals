// 16. Using loops write a program that converts an integer number to its hexadecimal representation. 
// The input is entered as long. The output should be a variable of type string. 
// Do not use the built-in .NET functionality. 
using System;

class DecimalToHex
{
    static void Main()
    {
        long x = long.Parse(Console.ReadLine());
        int highestPower = 0;
        string hexNum = "";
        byte num = 0;

        for (int i = 0; Math.Pow(16, i) < x; i++)
        {
            highestPower = i;
        }

        for (int i = highestPower; i >= 0; i--)
        {
            long power = (long)Math.Pow(16, i);

            num = (byte)(x / power);
            x = x - (num * power);

            switch (num)
            {
                case 10: hexNum = hexNum + "A";
                    break;
                case 11: hexNum = hexNum + "B";
                    break;
                case 12: hexNum = hexNum + "C";
                    break;
                case 13: hexNum = hexNum + "D";
                    break;
                case 14: hexNum = hexNum + "E";
                    break;
                case 15: hexNum = hexNum + "F";
                    break;
                default: hexNum = hexNum + num;
                    break;
            }
        }

        Console.WriteLine(hexNum);
    }
}
