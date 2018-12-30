using IncreasingTestabilityStepByStep.Interfaces;

namespace IncreasingTestabilityStepByStepTests.Mocks
{
    internal class MockStopwordsProvider : IStopwordsProvider
    {
        #region FIELDS

        private readonly string[] _Stopwords;

        #endregion

        #region CONSTRUCTOR

        public MockStopwordsProvider(string[] stopwords)
        {
            this._Stopwords = stopwords;
        }

        #endregion

        #region IStopwordsProvider

        public string[] Load()
        {
            return this._Stopwords;
        }

        #endregion
    }
}
