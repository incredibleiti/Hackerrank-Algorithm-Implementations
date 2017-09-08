using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class BreakingTheRecords
    {
        static int[] getRecord(int[] s)
        {
            // Complete this function
            int[] ar = new int[] { 0, 0 };
            int l = 0;
            int h = 0;
            if (s.Length != 0 && s != null)
            {
                int low = s[0];
                int high = s[0];
                for (int i = 0; i < s.Length; i++)
                {
                    if (low > s[i])
                    {
                        low = s[i];
                        l++;
                    }
                    if (high < s[i])
                    {
                        high = s[i];
                        h++;
                    }
                }
            }
            ar[0] = h;
            ar[1] = l;
            return ar;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
