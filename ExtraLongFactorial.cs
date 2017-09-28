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
        BigInteger  result = CalculateFactorial(n);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    private static BigInteger CalculateFactorial(int n)
    {
        if (n >= 1)
            return n * CalculateFactorial(n - 1);
        else
            return 1;
    }
}
