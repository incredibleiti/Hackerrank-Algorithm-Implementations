using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        long cnt = 0;
        if (s.Length == 1)
        {
            if (s == "a")
            {
                cnt = n;
            }
        }
        else
        {
            if (s.Length <= 100)
            {
                if (s.Length >= n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (s[i] == 'a')
                        {
                            cnt++;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == 'a')
                        {
                            cnt++;
                        }
                    }
                    long diff = n / s.Length;

                    cnt = cnt * diff;

                    long rem = n % s.Length;
                    for (int i = 0; i < rem; i++)
                    {
                        if (s[i] == 'a')
                        {
                            cnt++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(cnt);
        Console.ReadLine();
    }
}
