using IncreasingTestabilityStepByStep.Interfaces;

namespace IncreasingTestabilityStepByStep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IStopwordsProvider stopwordsProvider = new StopwordsProvider();
            string[] stopwords = stopwordsProvider.Load();

            string text = UI.AskForText();
            int n = CountWords(text, stopwords);
            UI.DisplayWordCount(n);
        }

        public static int CountWords(string text, string[] stopwords)
        {
            string[] words = Parser.SplitByWhitespace(text);

            WordsCounter wordsCounter = new WordsCounter(stopwords);
            int n = wordsCounter.Count(words);

            return n;
        }
    }
}
