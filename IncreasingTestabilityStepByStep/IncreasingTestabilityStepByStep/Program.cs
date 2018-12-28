using System;

namespace IncreasingTestabilityStepByStep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = AskForText();
            string[] words = text.Split(' ');
            int n = words.Length;
            DisplayWordCount(n);
        }

        public static void DisplayWordCount(int n)
        {
            Console.WriteLine($"Number of words: {n}");
        }

        public static string AskForText()
        {
            Console.Write($"Enter text:");
            string text = Console.ReadLine();
            return text;
        }
    }
}
