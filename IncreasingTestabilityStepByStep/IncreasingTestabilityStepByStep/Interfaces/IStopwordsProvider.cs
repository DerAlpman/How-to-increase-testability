namespace IncreasingTestabilityStepByStep.Interfaces
{
    /// <summary>
    /// <para>An interface for providing stopwords</para>
    /// </summary>
    public interface IStopwordsProvider
    {
        /// <summary>
        /// <para>Loads the stopwords.</para>
        /// </summary>
        /// <returns></returns>
        string[] Load();
    }
}