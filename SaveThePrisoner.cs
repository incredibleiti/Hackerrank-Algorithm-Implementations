using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int saveThePrisoner(int n, int m, int s)
    {
        int cnt = (m + s - 1 - 1) % n + 1;
        return cnt;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int s = Convert.ToInt32(tokens_n[2]);
            int result = saveThePrisoner(n, m, s);
            Console.WriteLine(result);
        }
    }
}
