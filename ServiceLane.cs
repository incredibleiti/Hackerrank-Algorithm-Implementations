using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp, Int32.Parse);
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);

            int min = FindMinimuminRange(i, j, width);
            Console.WriteLine(min);
        }
        Console.ReadKey();
    }

    private static int FindMinimuminRange(int i, int j, int[] width)
    {
        int min = width[i];
        for (int s = i + 1; s <= j; s++)
        {
            if(width[s]<min)
            {
                min = width[s];
            }
        }
        return min;
    }   
}
