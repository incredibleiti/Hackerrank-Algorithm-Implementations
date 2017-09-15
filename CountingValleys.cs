using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string ar_temp = Console.ReadLine();
        char[] charray = ar_temp.ToCharArray();
        int result = CalculateValley(n, charray);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    private static int CalculateValley(int n, char[] ar)
    {
        int cnt = 0;
        int level = 0;
        for (int i = 0; i < n; i++)
        {            
            if (ar[i] == 'U')
            {
                level++;
            }
            else
            {
                level--;
            }

            if(level ==-1 && ar[i] =='D')
            {
                cnt++;
            }
        }

        return cnt;
    }
}
