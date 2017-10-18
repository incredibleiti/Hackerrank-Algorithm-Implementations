using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);  
                   
            int totalChoc = n / c;
            int totalWrappers = totalChoc;
            int freeChocs = 0;
            // check warappers            
            if (m <= totalChoc)
            {
                while (m <= totalWrappers)
                {
                    int wrapperTogive = totalWrappers - (totalWrappers % m);

                    freeChocs = totalWrappers / m;

                    totalWrappers = (totalWrappers - wrapperTogive) + freeChocs;

                    totalChoc = totalChoc + freeChocs;

                }

            }

            Console.WriteLine(totalChoc);
            Console.ReadKey();
        }
    }
}
