using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    public static void Main(string[] args)
    {
        int Q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < Q; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string b = Console.ReadLine();
            Console.WriteLine(isHappy(b) ? "YES" : "NO");
            Console.ReadKey();

        }
    }

    public static bool isHappy(String s)
    {
        if (hasUnique(s))
        {
            return false;
        }

        if (alreadyHappy(s))
        {
            return true;
        }

        if (hasSpace(s))
        {
            return true;
        }

        return false;
    }

    public static bool hasUnique(String s)
    {
        int[] ascii = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '_')
            {
                ascii[(int)s[i] - 65]++;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (ascii[i] == 1)
            {
                return true;
            }
        }

        return false;
    }

    public static bool alreadyHappy(String s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (i == 0 && s[i] != s[i + 1])
            {
                return false;
            }
            else if (s[i] != s[i + 1] && s[i] != s[i-1])
            {
                return false;
            }
        }

        return true;
    }

    public static bool hasSpace(String s)
    {
        for (int i = 0; i < s.Length ; i++)
        {
            if (s[i] == '_')
            {
                return true;
            }
        }

        return false;
    }
}

