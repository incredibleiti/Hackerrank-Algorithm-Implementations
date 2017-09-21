using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        string word = Console.ReadLine();
        char[] a = word.ToArray();
        int finalheight = 1;
        int area = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int index = (int)a[i] % 32;
            int height = h[index-1];
            area = area + 1;
            if(finalheight<height)
            {
                finalheight = height;
            }         
        }

        Console.WriteLine(area * finalheight);
        Console.ReadKey();
    }

   
}
