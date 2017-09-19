using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = Console.ReadLine().Split(' ');
        int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = Console.ReadLine().Split(' ');
        int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
        // your code goes here

        int[] ranks = buildRanks(scores);
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(solve(scores, ranks, alice[i]));
        }
    }
    static int[] buildRanks(int[] scores)
    {
        int[] ranks = new int[scores.Length];
        int rank = 1;
        for (int i = 0; i < ranks.Length; i++)
        {
            if (i > 0 && scores[i] != scores[i - 1])
            {
                rank++;
            }
            ranks[i] = rank;
        }
        return ranks;
    }

    static int solve(int[] scores, int[] ranks, int alice)
    {
        int lower = 0;
        int upper = scores.Length - 1;
        int aliceRank = 1;
        while (lower <= upper)
        {
            int middle = (lower + upper) / 2;
            if (alice == scores[middle])
            {
                aliceRank = ranks[middle];
                break;
            }
            else if (alice < scores[middle])
            {
                aliceRank = ranks[middle] + 1;
                lower = middle + 1;
            }
            else
            {
                upper = middle - 1;
            }
        }
        return aliceRank;
    }
}
