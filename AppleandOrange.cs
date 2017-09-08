using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

        int appcnt = 0;
        int ornagcnt = 0;
        for (int i = 0; i < m; i++)
        {
            if(((a + apple[i])>=s) && ((a + apple[i])<=t))
            {
                appcnt++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (((b + orange[i]) >= s) && ((b + orange[i]) <= t))
            {
                ornagcnt++;
            }
        }

        Console.WriteLine(appcnt);
        Console.WriteLine(ornagcnt);
        Console.ReadKey();
    }
}
