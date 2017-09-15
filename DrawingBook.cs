using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
class Solution
{
    static int solve(int n, int p)
    {
        int min = 0;
        int front = p / 2;
        int back = (n / 2 - p / 2);
        if (front < back) min = front;
        else min = back;
        return min;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
