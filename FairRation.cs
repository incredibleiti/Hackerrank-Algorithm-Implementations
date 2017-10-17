using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// The solution is defined over the fact that, if you have to make donation of bread that needs to be in 2, means you have to donate
// two breads everytime. If the sum of array is even, then adding even + even == even (so, there is a chance that we can make array
// even. But if sum is not even, means odd, then odd + even == odd (so, as we are bound to make even donation, we can never make it
// even. so check if sum of array is even --> go ahead and start with donation, else if it is odd, donot make an effort and say staright
// "NO".


class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] B_temp = Console.ReadLine().Split(' ');
        int[] B = Array.ConvertAll(B_temp, Int32.Parse);

        int sum = B.Sum();        

        int count = 0;
        if (sum % 2 == 1)
        {
            Console.WriteLine("NO");
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                if (B[i] % 2 != 0)
                {
                    B[i] = B[i] + 1;
                    B[i + 1] = B[i + 1] + 1;
                    count += 2;
                }
            }
            Console.WriteLine(count);
        }

    }
}
