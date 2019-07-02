using System;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "Deleveled", "Neuquen", "C sharp" };

            foreach (string value in values) {
                Console.WriteLine(String.Format("{0} is {1}a palindrome.", value, Palindrome.IsPalindrome(value)? String.Empty : "not "));
            }
        }
    }
}
