using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int cnt = 0;
            int n = Convert.ToInt32(Console.ReadLine());           
            int[] arr = Array.ConvertAll(n.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0 && n % arr[i] == 0 )
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            //Console.ReadKey();
        }
    }
}
