// 15. Using loops write a program that converts a hexadecimal integer number to its decimal form. 
// The input is entered as string. The output should be a variable of type long. 
// Do not use the built-in .NET functionality.
using System;

class HexToDecimal
{
    static void Main()
    {

        string hexLine = Console.ReadLine();
        char[] hexArr = hexLine.ToCharArray();
        long decimalNum = 0;
        byte digits = (byte)hexArr.Length;

        for (int i = 0; i < digits; i++)
        {
            switch (hexArr[digits - i - 1])
            {
                case 'A': decimalNum = decimalNum + (10 * (long)Math.Pow(16, i));
                    break;
                case 'B': decimalNum = decimalNum + (11 * (long)Math.Pow(16, i));
                    break;
                case 'C': decimalNum = decimalNum + (12 * (long)Math.Pow(16, i));
                    break;
                case 'D': decimalNum = decimalNum + (13 * (long)Math.Pow(16, i));
                    break;
                case 'E': decimalNum = decimalNum + (14 * (long)Math.Pow(16, i));
                    break;
                case 'F': decimalNum = decimalNum + (15 * (long)Math.Pow(16, i));
                    break;
                default: 
                    byte hexDigit = byte.Parse(hexArr[digits - i - 1].ToString());
                    decimalNum = decimalNum + (hexDigit * (long)Math.Pow(16, i));
                    break;
            }
        }

        Console.WriteLine(decimalNum);
    }
}
