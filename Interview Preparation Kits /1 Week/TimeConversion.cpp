Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Example


Return '12:01:00'.


Return '00:01:00'.

Function Description

#include <bits/stdc++.h>

using namespace std;

/*
 * Complete the 'timeConversion' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts STRING s as parameter.
 */
==================================================================
==================================================================
==================================================================
  
string timeConversion(string s = "12:40:22AM") {
    int hour = stoi(s.substr(0,2));
    string remain = s.substr(3,5);
    string period = s.substr(8,2);
    string newhour="";
    if (period == "PM") {
        // Convert 12 PM - 11 PM normally
        newhour = (hour == 12) ? "12" : to_string(hour + 12);
    } else { // AM case
        // Convert 12 AM to "00", otherwise keep as is with leading zero
        newhour = (hour == 12) ? "00" : (hour < 10 ? "0" + to_string(hour) : to_string(hour));
    }

    return newhour+":"+remain;
}
==================================================================
==================================================================
==================================================================
  
int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string s;
    getline(cin, s);

    string result = timeConversion(s);

    fout << result << "\n";

    fout.close();

    return 0;
}
