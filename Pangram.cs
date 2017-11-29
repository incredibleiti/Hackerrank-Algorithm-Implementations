using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        string s = Console.ReadLine().ToLower();
       
        int nlen = s.Length;
        bool result = true;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alphas = (alphabet.ToLower()).ToCharArray();

        if (nlen>=1 && nlen<=1000)
        {
            for (int i = 0; i < alphas.Length; i++)
            {
                if(!s.Contains(alphas[i]))
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
        }

        Console.WriteLine(result == true ? "pangram" : "not pangram");
    }
}
}
