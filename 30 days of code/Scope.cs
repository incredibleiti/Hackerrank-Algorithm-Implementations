using System;
using System.Linq;

public class Solution
{
    static void Main(String[] args)
    {
        Convert.ToInt32(Console.ReadLine());
        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        Difference d = new Difference(a);
        d.computeDifference();
        Console.Write(d.maximumDifference);
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] a)
        {
            elements = a;
        }
        public void computeDifference()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i+1; j < elements.Length; j++)
                {
                    int diff = Math.Abs(elements[i] - elements[j]);

                    if(diff> maximumDifference)
                    {
                        maximumDifference = diff;
                    }
                }
            }
        }
    }
}


