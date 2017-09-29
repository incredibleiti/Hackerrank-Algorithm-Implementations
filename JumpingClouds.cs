using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        int i = 0;
        int curr = 0;
        while(i<c.Length-1)
        {
            if (i + 2 < c.Length)
            {
                if (c[i] == 0)
                {
                    if (c[i + 2] == 0)
                    {
                        i = i + 2;
                    }
                    else if (c[i + 1] == 0)
                    {
                        i = i + 1;
                    }
                    curr++;
                }
            }
            else if(i + 1 < c.Length)
            {
                if (c[i] == 0)
                {
                    if (c[i + 1] == 0)
                    {
                        i = i + 1;
                    }
                    curr++;
                }
            }
        }

        Console.WriteLine(curr);
        Console.ReadKey();
    }
}
