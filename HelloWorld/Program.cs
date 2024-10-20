using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string User = args.Length > 0 ? args[0] : "user";

            Console.WriteLine($"Hi from CNSA 212, {User}!");
        }
    }
}

