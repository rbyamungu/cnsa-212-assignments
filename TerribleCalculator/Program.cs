
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0){
                for (int i = 0; i < args.Length; i++){
                    Console.WriteLine($"Hello, {args[i]}!");
                    Console.ReadLine($"Goodbye, {args[i]}!");
                }
            }
        }
    }
}
