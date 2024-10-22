
using System;


namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double timesSt = 0;
            string input ;

            Console.WriteLine("Let's calculate badly: I hope you like adding because that's all we support. Enter the values to calculate on one line at a time. When you are done, enter the text end or press CTRL+Z on Windows or CTRL+D on linux.");
            
            while(true)
            {
                input = Console.ReadLine();
                

                if (input == "end" || input == null /*|| Console.ReadKey().Key == (ConsoleKey.CTRL | C)*/ )
                {
                    Console.WriteLine($"Total:" + timesSt);
                    break;
                }
                
                if (int.TryParse(input, out int num)){
                    timesSt +=  num;
                }
                else{
                    Console.WriteLine("I'm sorry, I couldn't understand that. Please enter a valid number.");
                }

                
            }
            
        }
    }
}
