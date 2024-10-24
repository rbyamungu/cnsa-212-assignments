using System;

namespace MyApp
{
    internal class Program 
    {
        static void Main(string[] userInput)
        {
            Console.WriteLine("Greetings Professor Falken. Do you want to play a game? Let's find palindromes. Enter a potential palindrome and press enter");
            
            string Test = Console.ReadLine();
            string NoSpace = Test.Trim();

            if ( NoSpace == Array.Reverse(NoSpace)){
                Console.WriteLine("Palindrome unlocked");
            }
            else{
                Console.WriteLine("Whomp, whomp.");
            }
            
        }
    }
}
