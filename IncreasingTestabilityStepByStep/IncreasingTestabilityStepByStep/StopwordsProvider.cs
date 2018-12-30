using System.IO;
using IncreasingTestabilityStepByStep.Interfaces;

namespace IncreasingTestabilityStepByStep
{
    /// <summary>
    /// Class to provide stopwords.
    /// </summary>
    public class StopwordsProvider : IStopwordsProvider
    {
        #region FIELDS

        private readonly string _Filename;

        #endregion

        #region CONSTRUCTOR

        public StopwordsProvider() : this("stopwords.txt") { }

        public StopwordsProvider(string filename)
        {
            this._Filename = filename;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// <see cref="IStopwordsProvider.Load()"/>
        /// </summary>
        /// <returns></returns>
        public string[] Load()
        {
            if (!File.Exists(this._Filename))
            {
                return new string[0];
            }
            string[] stopwords = File.ReadAllLines(this._Filename);

            return stopwords;
        }
        #endregion
    }
}
