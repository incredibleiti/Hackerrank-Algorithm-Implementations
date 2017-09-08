using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class SockMerchanr
    {
        static int sockMerchant(int n, int[] ar)
        {
            int cnt = 0;
            int cnt_s = 0;
            // Complete this function
            if (n >= 1 && n <= 100)
            {
                List<int> l = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    cnt = 0;
                    if (!l.Contains(ar[i]))
                    {
                        if (ar[i] >= 1 && ar[i] <= 100)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (ar[i] == ar[j])
                                {
                                    cnt++;
                                }
                            }
                        }
                        l.Add(ar[i]);
                    }
                    cnt_s += cnt / 2;
                }
            }
            return cnt_s;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
