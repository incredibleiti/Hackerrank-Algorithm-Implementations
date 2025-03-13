Given a string find the index of a character which can be removed to make the string palindrome.

int palindromeIndex(string s) {
    int left = 0, right = s.length() - 1;

    while (left < right) {
        if (s[left] != s[right]) {
            // Check if removing left character makes it a palindrome
            int l1 = left + 1, r1 = right;
            bool isPalindrome1 = true;
            while (l1 < r1) {
                if (s[l1] != s[r1]) {
                    isPalindrome1 = false;
                    break;
                }
                l1++;
                r1--;
            }

            if (isPalindrome1) return left;

            // Check if removing right character makes it a palindrome
            int l2 = left, r2 = right - 1;
            bool isPalindrome2 = true;
            while (l2 < r2) {
                if (s[l2] != s[r2]) {
                    isPalindrome2 = false;
                    break;
                }
                l2++;
                r2--;
            }

            if (isPalindrome2) return right;

            return -1; // If neither removal fixes the palindrome
        }
        left++;
        right--;
    }

    return -1; // Already a palindrome
}
