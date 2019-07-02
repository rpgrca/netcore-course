using System;

namespace Palindrome {
    public static class Palindrome {
        public static bool IsPalindrome(string word) {
            bool result = false;

            if (! String.IsNullOrEmpty(word)) {
                char [] letters = word.ToCharArray();
                Array.Reverse(letters);
                result = (String.Compare(new String(letters), word, true) == 0);
            }

            return result;
        }
    }
}