using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int result = GetAllIntegers(n, a);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    private static int GetAllIntegers(int n, int[] a)
    {
        int final = 0;    
        int index = 0;
        while (index < a.Length)
        {
            int cnt = 0;
            List<int> temp = new List<int>();
            temp.Add(a[index]);
            for (int i = 0; i < a.Length; i++)
            {
                if (index != i)
                {
                    if (Math.Abs(a[index] - a[i]) <= 1)
                    {
                        temp.Add(a[i]);
                        cnt++;
                    }
                }
            }
            List<int> r = new List<int>();
            for (int i = 0; i < temp.Count; i++)
            {                
                for (int j = 0; j < temp.Count; j++)
                {
                    if(i!=j)
                    {
                        if(temp[i]-temp[j] <=1)
                        {

                        }
                        else
                        {
                            r.Add(temp[i]);
                            break;
                        }
                    }
                }
            }

            foreach (var item in r)
            {
                temp.Remove(item);
            }
            if(final<=temp.Count)
            {
                final = temp.Count;
            }
            index++;
        }
        return final;
    }
}
