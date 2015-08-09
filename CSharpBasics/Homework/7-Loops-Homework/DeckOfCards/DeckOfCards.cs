// 04.Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
// The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

using System;

class DeckOfCards
{
    static void Main()
    {
        char heart = '\u2665';
        char spade = '\u2660';
        char diamond = '\u2666';
        char club = '\u2663';

        char[] faceCard = new char[4] {'\u0041', '\u004B', '\u0051', '\u004A'};

        for (int i = 2; i <= 14; i++)
        {
            for (int y = 0; y < 4; y++)
            {
                if (i < 11)
                {
                    switch (y)
                    {
                        case 0: Console.Write("{0}{1} ", i, club);
                            break;
                        case 1: Console.Write("{0}{1} ", i, diamond);
                            break;
                        case 2: Console.Write("{0}{1} ", i, heart);
                            break;
                        case 3: Console.Write("{0}{1} ", i, spade);
                            break;
                    }
                }
                else
                {
                    switch (y)
                    {
                        case 0: Console.Write("{0}{1} ", faceCard[i - 11], club);
                            break;
                        case 1: Console.Write("{0}{1} ", faceCard[i - 11], diamond);
                            break;
                        case 2: Console.Write("{0}{1} ", faceCard[i - 11], heart);
                            break;
                        case 3: Console.Write("{0}{1} ", faceCard[i - 11], spade);
                            break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
