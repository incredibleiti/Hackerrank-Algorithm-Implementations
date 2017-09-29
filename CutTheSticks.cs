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

        int cnt = arr.Length;

        while (cnt > 0)
        {
            int result = arr.Count(i => i > 0);
            int min = arr.Where(x=>x > 0).Min();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - min;
            }
            cnt = arr.Count(i => i > 0);
            Console.WriteLine(result);
        }
        Console.ReadKey();
    }
}
