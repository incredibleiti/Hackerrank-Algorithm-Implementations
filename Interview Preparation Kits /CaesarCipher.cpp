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
