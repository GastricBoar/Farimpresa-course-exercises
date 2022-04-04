using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;

            Console.Write("Please insert your string to check if it's a palindrome: ");
            inputString = Console.ReadLine();

            Console.WriteLine("\n===========================================================================\n");

            Console.WriteLine(IsPalindrome(inputString));

        }

        //public static bool IsPalindrome(string inputString)
        //{
        //    int length = inputString.Length / 2;
        //    for (int i = 0; i < length; i++) //cycle from index 0 to middle of the string
        //    {
        //        if (inputString[i] != inputString[length - i - 1]) //compare first letter of the string to the last, then second letter to the second last, then third letter to third last, and so on...
        //            return false;
        //    }
        //    return true;                                           //if all letters are equal to their counterpart until meeting to the center of the string, then string is a palindrome. 
        //}

        public static bool IsPalindrome(string inputString)
        {
            string reverseString = string.Empty;
                       
            for (int i = inputString.Length - 1; i >= 0; i--) //Cycle through the string in reverse order
            {                
                reverseString += inputString[i]; //take each character and form string in reverse order
            }

            return reverseString == inputString ? true : false; //if reverseString is equal to inputString then string is a palindrome.
        }
    }
}
