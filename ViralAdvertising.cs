using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string n = Console.ReadLine();
        int n_ = Convert.ToInt32(n);
        int initial = 5;
        int cnt = 0;
        int finalcnt = 0;
        for (int i = 0; i < n_; i++)
        {   
            if(i==0)
            {
                initial = initial / 2; 
            }   
            else
            {                
                cnt = initial * 3;               
                initial = cnt / 2;
            }
            finalcnt += initial;
        }

        Console.WriteLine(finalcnt);
        Console.ReadKey();
    }
}
