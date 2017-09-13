using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int migratoryBirds(int n, int[] ar)
    {
        // Complete this function
        int ID = 0;
        int cnt = 0;
        for (int i = 1; i < 6; i++)
        {
            var maxcnt = ar.Count(y => y == i);
            if(cnt<maxcnt)
            {
                cnt = maxcnt;
                ID = i;
            }
        }

        return ID;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
