using System.Linq;

namespace IncreasingTestabilityStepByStep
{
    /// <summary>
    /// Class to count words.
    /// </summary>
    public class WordsCounter
    {
        #region FIELDS

        private readonly string[] _Stopwords;

        #endregion

        #region Constructor

        public WordsCounter(string[] stopwords)
        {
            this._Stopwords = stopwords;
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
            words = words.Except(this._Stopwords).ToArray();
            var n = words.Length;

            return n;
        }

        #endregion
    }
}
