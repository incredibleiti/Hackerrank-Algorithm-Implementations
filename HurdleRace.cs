using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);
        // your code goes here
        int result = MagicBevarage(k, height);
        Console.WriteLine(result);
        //Console.ReadKey();
    }
    
    private static int MagicBevarage(int k, int[] height)
    {
        int diff = 0;

        for (int i = 0; i < height.Length; i++)
        {
            if(k<height[i])
            {
                if(diff<height[i]-k)
                diff = height[i] - k;
            }
        }

        return diff;
    }
}
