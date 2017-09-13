using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{  

    static string solve(int year)
    {
        // Complete this function
        
        int day = 256;
        int month = 1;
        while (true)
        {
            int daysInMonth = computeDaysInMonth(year, month);

            if (day <= daysInMonth)
            {
                break;
            }

            day -= daysInMonth;
            month++;
        }
        return (day+"."+ month+"."+ year);        
    }

    static int computeDaysInMonth(int year, int month)
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            return 31;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            return 30;
        }
        else if (year == 1918)
        {
            return 15;
        }
        else if (isLeapYear(year))
        {
            return 29;
        }
        else
        {
            return 28;
        }
    }
    static bool isLeapYear(int year)
    {
        return (year <= 1917 && year % 4 == 0)
                || (year >= 1919 && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)));
    }

    static void Main(String[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
