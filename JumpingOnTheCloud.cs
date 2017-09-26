using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        int E = 100;
        for (int i = 0; i < n; i+=k)
        {
            int v = i + k;
            if(v>=n)
            {
                v = n - v;
            }
            if(c[(i + k) % n] == 0)
            {
                E-= 1;
            }
            else if (c[(i + k) % n] != 0)
            {
                E -= 3;
            }
        }

        Console.WriteLine(E);
        Console.ReadKey();
    }
}
