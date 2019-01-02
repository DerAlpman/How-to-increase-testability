using System;

namespace IncreasingTestabilityStepByStep
{
    internal static class UI
    {
        internal static void DisplayWordCount(int n)
        {
            Console.WriteLine($"Number of words: {n}");
        }

        internal static string AskForText()
        {
            Console.Write($"Enter text:");
            string text = Console.ReadLine();
            return text;
        }
    }
}
