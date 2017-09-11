using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class BetweenTwoSets
    {
        static int getTotalX(int[] a, int[] b)
        {
            // Complete this function
            int getx = 0;
            int max = a.Max();
            int min = b.Min();

            for (int i = max; i <= min; i++)
            {
                if (TakeAll_A_Element(a, i) && TakeAll_B_Element(b, i))
                {
                    getx++;
                }
            }
            return getx;
        }

        private static bool TakeAll_A_Element(int[] a, int i)
        {
            bool result = true;

            for (int j = 0; j < a.Length; j++)
            {
                if (i % a[j] != 0)
                {
                    result = false;
                }
            }
            return result;
        }

        private static bool TakeAll_B_Element(int[] b, int i)
        {
            bool result = true;

            for (int k = 0; k < b.Length; k++)
            {
                if (b[k] % i != 0)
                {
                    result = false;
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
