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
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp, Int32.Parse);

        int pair = Findpairs(A);
        Console.WriteLine(pair);
        Console.ReadKey();
    }

    private static int Findpairs(int[] a)
    {
        List<int> small = new List<int>();
        List<int> lst = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            for (int k = 0; k < a.Length; k++)
            {
                if(a[k] == a[i] && i!=k)
                {
                    lst.Add(a[i]);
                    small.Add(Math.Abs(k - i));
                }
            } 
        }       
        return small.Count() != 0 ? small.Min() : -1;
    }
}
