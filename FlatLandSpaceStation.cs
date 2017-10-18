using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] spaceStationArr = Array.ConvertAll(c_temp, Int32.Parse);
        Array.Sort(spaceStationArr);
       
        int maxDistance = spaceStationArr[0];

        for (int i = 1; i < spaceStationArr.Length; i++)
        {

            int distance = (spaceStationArr[i] - spaceStationArr[i - 1]) / 2;

            if (distance > maxDistance)
                maxDistance = distance;
        }

        int lastSpaceStationDistance = n - 1 - spaceStationArr[m - 1];
        if (lastSpaceStationDistance > maxDistance)
        {
            maxDistance = lastSpaceStationDistance;
        }

        Console.WriteLine(maxDistance);
        Console.ReadKey();
    }
}
