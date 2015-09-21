using System;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] firstLegoBlock = new int[n][];

        for (int i = 0; i < n; i++)
        {
            firstLegoBlock[i] = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        
        int[][] secondLegoBlock = new int[n][];

        for (int i = 0; i < n; i++)
        {
            secondLegoBlock[i] = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
