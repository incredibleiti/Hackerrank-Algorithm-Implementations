Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher shifts each letter by a number of letters. If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet. In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.

Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
Example


The alphabet is rotated by , matching the mapping above. The encrypted string is .

Note: The cipher only encrypts letters; symbols, such as -, remain unencrypted.

Function Description

Complete the caesarCipher function in the editor below.

caesarCipher has the following parameter(s):

string s: cleartext
int k: the alphabet rotation factor
Returns

string: the encrypted string
Input Format

The first line contains the integer, , the length of the unencrypted string.
The second line contains the unencrypted string, .
The third line contains , the number of letters to rotate the alphabet by.

Constraints



 is a valid ASCII string without any spaces.


#include <iostream>
#include <string>
#include <cctype> // for isupper, islower

char rotateChar(char ch, int shift) {
    if (std::islower(ch)) {
        return 'a' + (ch - 'a' + shift) % 26;
    } else if (std::isupper(ch)) {
        return 'A' + (ch - 'A' + shift) % 26;
    } else {
        return ch; // leave non-alphabetic characters unchanged
    }
}

std::string rotateString(const std::string& input, int shift) {
    std::string result;
    for (char ch : input) {
        result += rotateChar(ch, shift);
    }
    return result;
}

int main() {
    std::string input = "Hello, World!";
    int shift = 2;

    std::string output = rotateString(input, shift);
    std::cout << "Original: " << input << "\n";
    std::cout << "Rotated : " << output << "\n";

    return 0;
}
