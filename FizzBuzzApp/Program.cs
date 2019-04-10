using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzzApp Started");
            Console.WriteLine();
            for (uint i = 1; i <= 100; ++i)
            {
                Console.WriteLine(FizzBuzzKata.FizzBuzz.Print(i));
            }
            Console.WriteLine();
            Console.WriteLine("FizzBuzzApp Ended");
            
        }
    }
}
