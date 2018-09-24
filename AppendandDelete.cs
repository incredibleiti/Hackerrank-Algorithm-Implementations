using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectforCodingProblems
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int commonLength = 0;
            int min = Math.Min(s.Length, t.Length);

            for (int i = 0; i < min; i++)
            {
                if (s[i] == t[i])
                    commonLength++;
                else
                    break;
            }
            //CASE A
            if ((s.Length + t.Length - 2 * commonLength) > k)
            {
               return "No";
            }
            //CASE B
            else if ((s.Length + t.Length - 2 * commonLength) % 2 == k % 2)
            {
                return "Yes";
            }
            //CASE C
            else if ((s.Length + t.Length - k) < 0)
            {
                return "Yes";
            }
            //CASE D
            else
            {
                return "No";
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
