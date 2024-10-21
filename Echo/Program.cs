using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] userInput)
        {
            if (userInput.Length > 0){

            
            
                 if (userInput[0] == "R"){

                     Array.Reverse(userInput);
                    for (int i = 0; i < userInput.Length - 1; i++){
                       
                        string r = userInput[i];
                        Console.Write(r + " " );
                        
                    }
                   
                    
                }
                else 
                {   
                    for (int i = 0; i < userInput.Length; i++){
                    string r = userInput[i];
                    Console.Write(r + " ");
                    }
                }
            }
            else
            {
                Console.Write("Missing userInput");
            }
        }
    }
}
