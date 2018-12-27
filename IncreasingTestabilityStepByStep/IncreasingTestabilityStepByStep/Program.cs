using System;

namespace IncreasingTestabilityStepByStep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write($"Enter text:");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int n = words.Length;
            Console.WriteLine($"Number of words: {n}");
        }
    }
}
