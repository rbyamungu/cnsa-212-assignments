using System;

namespace MyApp
{
    internal class Program 
    {
        static void Main(string[] userInput)
        {
            Console.WriteLine("Greetings Professor Falken. Do you want to play a game? Let's find palindromes.");
            Console.WriteLine("Enter a potential palindrome and press enter.");
            Console.WriteLine("A palindrome is a string that is the same forward and backward (whitespace excluded): \"A man a plan a canal Panama\" is a palindrome.");

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                // Remove all whitespace
                string noWhitespace = input.Replace(" ", "").Replace("\t", "");

                // Reverse the string
                char[] charArray = noWhitespace.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);

                // Check if the reversed string matches the original (without whitespace)
                if (noWhitespace.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Palindrome unlocked");
                }
                else
                {
                    Console.WriteLine("Whomp, whomp.");
                }
            }
        }
    }
}
