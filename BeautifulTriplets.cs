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
        string [] st = Console.ReadLine().Split(' ');    
           
        int n = Convert.ToInt32(st[0]);
        int d = Convert.ToInt32(st[1]);

        string[] arrayelements = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(arrayelements, Int32.Parse);
        int result = 0;
        for (int j = 0; j < n; j++)
        {
            int index = j + 1;
            int i = j;
            int occ = 0;
            while (index <= n-1)
            {
                if (Math.Abs(numbers[i] - numbers[index]) != d)
                {
                    index++;
                }
                else
                {
                    occ++;
                    i = index;
                    index++;
                }
                if(occ == 2)
                {
                    result++;
                    break;
                }
            }
        }
        
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
