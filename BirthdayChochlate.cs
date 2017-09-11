using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int solve(int n, int[] s, int d, int m)
    {
        // Complete this function
        //d is total
        //m is set
        int sol = 0;
        for (int i = 0; i < n; i++)
        {
            int index = i;
            int t = 0;
            for(int j=0;j<m;j++)
            {
                if (index < s.Length)
                {
                    t += s[index];
                    index++;
                }
            }
            if(t==d)
            {
                sol++;
            }
        }
        return sol;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
