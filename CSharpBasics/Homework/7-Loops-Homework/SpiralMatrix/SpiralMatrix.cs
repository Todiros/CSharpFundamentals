// 19. Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers 
// from 1 to n*n in the form of square spiral like in the examples below:
//
// n = 5
// 1   2   3   4   5
// 16  17  18  19  6
// 15  24  25  20  7
// 14  23  22  21  8
// 13  12  11  10  9
// 
// n = 4
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7
using System;

class SpiralMatrix
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        short[,] matrix = new short[n,n]; // multidimentional array (matrix) with X(cols) = n, and Y(rows) = n
        byte stepsSets = 0; // counts the sets of steps, starting from the second one since the first breaks the pattern - 5, 4, 4, 3, 3, 2, 2, 1, 1 (n = 5) 
        byte directions = 1; // set the directions - right, down, left, up (starting from 1, since it skips the first direction/line)
        byte steps = (byte)(n - 1); // counts the actual steps in each direction
        byte turnsCounter = 1; // counts the changing of the directions through the whole matrix (2 * n - 1)
        byte lastPositionX = (byte)(n - 1); // the horizontal axis of the matrix (columns)
        byte lastPositionY = 0; // the vertical axis of the matrix (rows)
        short lastValue = (short)(n + 1); // the actual numbers for the matrix

        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = (short)(i + 1); // getting the first line which is always the same, from 1 To N. 
        }

        do
        {
            if (directions == 4)
            {
                directions = 0;
            }
            for (int i = 0; i < steps; i++)
            {
                if (stepsSets == 2)
                {
                    steps--;
                    stepsSets = 0;
                }

                switch (directions)
                {
                    case 0: lastPositionX++;
                            matrix[lastPositionY, lastPositionX] = lastValue;
                            lastValue++;
                        break;
                    case 1: lastPositionY++;
                            matrix[lastPositionY, lastPositionX] = lastValue;
                            lastValue++;
                        break;
                    case 2: lastPositionX--;
                            matrix[lastPositionY, lastPositionX] = lastValue;
                            lastValue++;
                        break;
                    case 3: lastPositionY--;
                            matrix[lastPositionY, lastPositionX] = lastValue;
                            lastValue++;
                        break;
                }
            }
            stepsSets++;
            directions++;
            turnsCounter++;
        }while(turnsCounter < (2 * n - 1));

        for (int i = 0; i < n; i++)
        {
            for (int y = 0; y < n; y++)
            {
                if (n >= 1 && n <= 3) // formats the output according to the digits in the end number so that it looks better 
                {
                    Console.Write("{0} ", matrix[i, y]);
                }
                else if (n >= 4 && n <= 9)
                {
                    Console.Write("{0,-2} ", matrix[i, y]);
                }
                else
                {
                    Console.Write("{0,-3} ", matrix[i, y]);
                }
            }
            Console.WriteLine();
        }
    }
}
