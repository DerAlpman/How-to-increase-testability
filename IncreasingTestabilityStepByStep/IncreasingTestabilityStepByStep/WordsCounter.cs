using System.Linq;
using IncreasingTestabilityStepByStep.Interfaces;

namespace IncreasingTestabilityStepByStep
{
    /// <summary>
    /// Class to count words.
    /// </summary>
    public class WordsCounter
    {
        #region FIELDS

        private readonly IStopwordsProvider _StopwordsProvider;

        #endregion

        #region Constructor

        public WordsCounter(IStopwordsProvider stopwordsProvider)
        {
            this._StopwordsProvider = stopwordsProvider;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Counts the intersection of given words and loaded stopwords.
        /// </summary>
        /// <param name="words">Words to count</param>
        /// <returns>Number of words not included in stopwords</returns>
        public int Count(string[] words)
        {
            var stopwords = this._StopwordsProvider.Load();
            words = words.Except(stopwords).ToArray();
            var n = words.Length;

            return n;
        }

        #endregion
    }
}
