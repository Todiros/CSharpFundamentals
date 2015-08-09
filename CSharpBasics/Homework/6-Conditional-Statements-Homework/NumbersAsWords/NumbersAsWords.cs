// 11. Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

using System;

class NumbersAsWords
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string[] numbers = new string[21] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
                                           "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"};

        string[] tents = new string[9] {"Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eightyty", "Ninety"};

        int firstDigit = 0;
        int secondDigit = 0;
        int thirdDigit = 0;
        string number = "";

        if (num >= 0 && num <= 20)
        {
            Console.WriteLine(numbers[num]);
        }
        else if (num > 20 && num < 100)
        {
            secondDigit = num % 10;
            firstDigit = num / 10;

            if (secondDigit == 0)
            {
                number = tents[firstDigit - 1];
            }
            else
            {
                number = tents[firstDigit - 1] + " " + numbers[secondDigit];
            }

            Console.WriteLine(number);
        }
        else if (num >= 100 && num < 1000)
        {
            thirdDigit = num % 10;
            num = num / 10;
            secondDigit = num % 10;
            firstDigit = num / 10;

            if (thirdDigit == 0)
            {
                if (secondDigit == 0)
                {
                    number = numbers[firstDigit] + " Hundred";
                    Console.WriteLine(number);
                }
                else
	            {
                    number = numbers[firstDigit] + " Hundred and " + tents[secondDigit - 1];
                    Console.WriteLine(number);
	            }
            }
            else if (secondDigit == 0)
            {
                number = numbers[firstDigit] + " Hundred and " + numbers[thirdDigit];
                Console.WriteLine(number);
            }
            else
            {
                if (secondDigit == 1)
                {
                    int teens = (secondDigit * 10) + thirdDigit; 
                    number = numbers[firstDigit] + " Hundred and " + numbers[teens];
                }
                else
                {
                    number = numbers[firstDigit] + " Hundred and " + tents[secondDigit - 1] + " " + numbers[thirdDigit];
                }

                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Number should be between 0 and 999!");
        }
    }
}
