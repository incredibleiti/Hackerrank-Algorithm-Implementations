using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse); 
        int maxcnt = arr.GroupBy(s => s)
                         .OrderByDescending(s => s.Count())
                         .First().Key;
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if(arr[i]!=maxcnt)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}
