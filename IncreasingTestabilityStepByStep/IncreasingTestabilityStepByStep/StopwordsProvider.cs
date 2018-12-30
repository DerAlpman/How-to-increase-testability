using System.IO;

namespace IncreasingTestabilityStepByStep
{
    public class StopwordsProvider
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
