using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string temp = Console.ReadLine();
        string[] int_temp = temp.Split(' ');

        int temp_0 = Convert.ToInt32(int_temp[0]);
        int temp_1 = Convert.ToInt32(int_temp[1]);
        int temp_2 = Convert.ToInt32(int_temp[2]);

        int cnt = 0;
        for (int i = temp_0; i < (temp_1 + 1); i++)
        {
            int reverse = CalculateReverse(i);
            if(Math.Abs(i - reverse) % temp_2 == 0)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);

    }

    private static int CalculateReverse(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
}
