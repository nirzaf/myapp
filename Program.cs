using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word to palindrome or not?");
            string word = Console.ReadLine();
            string reversed = IsPalindrome(word);
            if (word == reversed)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        // Write a program in C# Sharp to check whether a string is a palindrome or not.

        public static string IsPalindrome(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    result += str[i];
                }
            }
            return result;
        }
    }





}
