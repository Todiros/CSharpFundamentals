// 12. We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
// Assume that repeating the same subset several times is not a problem. 

using System;

class ZeroSubsets
{
    static void Main()
    {
        Console.Write("Enter a line of 5 numbers: ");
        string[] line = Console.ReadLine().Split();
        int[] numbers = new int[5];
        bool flag = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(line[i]);
        }

        if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
            flag = true;
        }

        else
        {
            int sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0 + 1; y < numbers.Length; y++)
                {
                    if (numbers[i] + numbers[y] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[y]);
                        flag = true;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0 + 1; y < numbers.Length; y++)
                {
                    for (int m = 0 + 1; m < numbers.Length; m++)
                    {
                        if (numbers[i] + numbers[y] + numbers[m] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[y], numbers[m]);
                            flag = true;
                        }
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0 + 1; y < numbers.Length; y++)
                {
                    for (int m = 0 + 1; m < numbers.Length; m++)
                    {
                        for (int n = 0 + 1; n < numbers.Length; n++)
                        {
                            if (numbers[i] + numbers[y] + numbers[m] + numbers[n] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[y], numbers[m], numbers[n]);
                                flag = true;
                            }
                        }
                    }
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                flag = true;
            }
        }

        if (!flag)
        {
            Console.WriteLine("No zero subsets!");
        }
    }
}
