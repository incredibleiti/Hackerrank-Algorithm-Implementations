using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int saveThePrisoner(int n, int m, int s)
    {
        int cnt = (m + s - 1 - 1) % n + 1;
        return cnt;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int s = Convert.ToInt32(tokens_n[2]);
            int result = saveThePrisoner(n, m, s);
            Console.WriteLine(result);
        }
    }
}


///I am writing down the throught process I got when I was trying to create a pattern or equation....as sometimes a new programmer
/// struggles in understanding how come the solution is so crisp...how do we derive the equation right?
/// Let us see...how an mediocre programmer like me...was able to draw equation.....:)

=============================================See Below Now===================================================================

//let us find out the case so that we can make some equations
//I tried to make a case greater or smaller than prisoner, but then
//I realized that it can never go above Prisoner count right..we can only have start index less than prisoner count or
//equal to it...e.g with start with prisoner first or last prisoner, right?

//case when number of sweets will be less or greater than prisoner count right?
//but in that case when sweets are greater than prisoner(they will get sweets again, as circle repeats)
//but for us it easy, our counter resets when circle starts again
//means when sweets are 7 and prisoner are 5, basically after 5 prisoner, 1 and 2 get sweets again,
//so we can reset counter and count sweets as 2, this is what matters to us now...(5 sweets were distributed and doesn't help us in finding last person, right?)

//So now I will focus on real life handling, if I was about to do it in real life
//I will focus on start index and how many sweets I have to distribute
//pick start prisoner, start distributing sweets and check where we end

//------------------------------Case 1-----------------------

//prisoner = 5
//sweets = 2
//start index/prisoner = 2

//---------------------------
//  1  |  2  | 3  |  4 |  5 |
//---------------------------
//       1     1 <--count finished at 3rd


//-----------------------------Case 2---------------------------

//prisoner = 7
//sweets = 3
//start index/prisoner = 1

//------------------------------------
//  1  |  2  | 3  |  4 |  5 | 6 | 7 |
//------------------------------------
//  1 <--count finished at 1st


//----------------------------Case 3--------------------------------

//prisoner = 5
//sweets = 1
//start index/prisoner = 4

//---------------------------
//  1  |  2  | 3  |  4 |  5 |
//---------------------------
//                   1 <--count finished at 4th

//---------------------------Case 4---------------------------------
//prisoner = 5
//sweets = 4
//start index/prisoner = 4

//-------------------------------------------
//  1     |     2  |     3  |     4   |   5   |
//-------------------------------------------
//  1          1                  1       1
//          finshed            started

//-----------------------------Case 5---------------------------

//prisoner = 7
//sweets = 4
//start index/prisoner = 5

//--------------------------------------------------------------
//  1     |     2  |    3  |     4 |     5   |    6   |    7   |
//---------------------------------------------------------------
//  1                                    1        1        1
//finshed                             started


//Check the trend if I am adding sweets to start index and -1 as initial start prisoner also eats sweets we get a pattern
//Case 1: startindex + sweets - 1 = 2 + 2 - 1 = 3
//Case 2: startindex + sweets - 1 = 1 + 3 - 1 = 3
//Case 3: startindex + sweets - 1 = 4 + 1 - 1 = 4
//Case 4: startindex + sweets - 1 = 4 + 4 - 1 = 8-1 = 7 (7 is greater than prisoner count, means 5 in this case, lets reset count 7-5 = 2 (last one to get sweets)
//Case 5: startindex + sweets - 1 = 4 + 5 - 1 = 9-1 = 8 (8 is greater than prisoner count, means 7 in this case, lets reset count 8-7 = 1 (last one to get sweets)

==========================================================THERE..YOU HAVE...YOUR EQUATIONS========================================================================
==========================================================NOTHING IS HARD...IT REQUIRES THE CONFIDENCE THAT YOU WILL WORK IT OUT==================================
