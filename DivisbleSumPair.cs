using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class DivisbleSumPair
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            // Complete this function
            int cnt = 0;
            ar = ar.OrderBy(i => i).ToArray();
            if (n >= 2 && n <= 100)
            {
                if (k >= 1 && k <= 100)
                {
                    for (int i = 0; i < ar.Length; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i < j)
                            {
                                if ((ar[i] + ar[j]) % k == 0)
                                {
                                    cnt++;
                                }
                            }
                        }
                    }
                }
            }
            return cnt;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}
