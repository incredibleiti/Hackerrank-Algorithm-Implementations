using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        char[] hc = ("hackerrank").ToCharArray();
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();

            string result = CheckString(s,hc);
            Console.WriteLine(result);
            
        }
    }

    private static string CheckString(string s, char[] hc)
    {
        string result = string.Empty;
        if (s.Length < hc.Length)
        {
            result = "NO";
        }

        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (j < hc.Length && s[i] == hc[j])
            {
                j++;
            }
        }
        result = (j == hc.Length ? "YES" : "NO");
        return result;
    }
}
