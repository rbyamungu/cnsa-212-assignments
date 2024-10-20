using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = args.Length[0] > 0 ? args[0] : "userInput";
            if (userInput[0] == "R"){

                Console.WriteLine($"{reverse(userInput)}");
            }
            else {
                Console.WriteLine($"{userInput}")
            }
            
        }
    }
}
