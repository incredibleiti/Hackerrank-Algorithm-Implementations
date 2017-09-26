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
        int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        if (temp.Length == n_)
        {

            for (int i = 1; i < temp.Length + 1; i++)
            {
                int x = Array.IndexOf<int>(temp, i) + 1;
                Console.WriteLine(Array.IndexOf<int>(temp, x) + 1);
            }
            Console.ReadKey();
        }
    }
  
}
