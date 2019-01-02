using System;
using IncreasingTestabilityStepByStep.Interfaces;

namespace IncreasingTestabilityStepByStep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IStopwordsProvider stopwordsProvider = new StopwordsProvider();
            string[] stopwords = stopwordsProvider.Load();

            string text = AskForText();
            int n = CountWords(text, stopwords);
            DisplayWordCount(n);
        }

        public static int CountWords(string text, string[] stopwords)
        {
            string[] words = Parser.SplitByWhitespace(text);
            return CountWords(words, stopwords);
        }

        public static int CountWords(string[] words, string[] stopwords)
        {
            WordsCounter wordsCounter = new WordsCounter(stopwords);
            int n = wordsCounter.Count(words);
            return n;
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
