using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
class Solution
{
    static int bonAppetit(int n, int k, int b, int[] ar)
    {
        // Complete this function
        int bill = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if(i!=k)
            {
                bill += ar[i];
            }
        }
        if(b > (bill/2))
        {
            bill = b - (bill/2);
        }
        else
        {
            bill = b;
        }
        return bill;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        int result = bonAppetit(n, k, b, ar);
        if(b==result)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(result);
        }
        Console.ReadKey();      
    }
}
