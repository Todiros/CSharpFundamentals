// 02. The gravitational field of the Moon is approximately 17% of that on the Earth. 
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double gravitationOnMoon = 17;
        double weightOnMoon = gravitationOnMoon / 100;

        Console.Write("Enter your weight: ");
        double mansWeight = double.Parse(Console.ReadLine());

        mansWeight = mansWeight * weightOnMoon;
          
        Console.WriteLine("Your weight on the moon is ~{0}kg.", mansWeight);
    }
}
