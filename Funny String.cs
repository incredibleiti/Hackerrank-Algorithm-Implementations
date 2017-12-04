using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string funnyString(string s)
    {
        string result = string.Empty;
        string r = ReverseString(s);
       
        for (int i = 0; i < s.Length-1; i++)
        {
            if(Math.Abs(s[i+1] - s[i]) == Math.Abs(r[i+1] - r[i]))
            {
                result = "Funny";
            }
            else
            {
                result = "Not Funny";
                break;
            }
        }

        return result;
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
        Console.ReadKey();
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
