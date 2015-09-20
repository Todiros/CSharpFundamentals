using System;
using System.Linq;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        int targetSum = int.Parse(Console.ReadLine());
        int[] set = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        bool foundMatch = false;

        List<string> subsets = new List<string>();
        List<int> sums = new List<int>();

        for (int i = 1; i < set.Length; i++)
		{
            subsets.Add(set[i - 1].ToString());
            sums.Add(set[i - 1]);

            List<string> newSubsets = new List<string>();
            List<int> newSum = new List<int>(); 

            for (int y = 0; y < subsets.Count; y++)
            {
                string subset = string.Format("{0} + {1}", subsets[y], set[i]);
                newSubsets.Add(subset);

                int subsetSum = sums[y] + set[i];
                newSum.Add(subsetSum);
            }

            sums.AddRange(newSum);
            subsets.AddRange(newSubsets);
		}

        subsets.Add(set[set.Length - 1].ToString());
        sums.Add(set[set.Length - 1]);

        Console.WriteLine();

        for (int i = 0; i < subsets.Count; i++)
        {
            if (sums[i] != targetSum)
            {
                subsets.RemoveAt(i);
                sums.RemoveAt(i);
                i--;
            }
        }

        if (subsets.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            subsets.Sort((a, b) => a.Length.CompareTo(b.Length));

            foreach (var subset in subsets)
            {
                Console.WriteLine("{0} = {1}", subset, targetSum);
            }
        }
    }
}
