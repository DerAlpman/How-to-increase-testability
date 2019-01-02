using System;

namespace IncreasingTestabilityStepByStep
{
    internal static class Parser
    {
        internal static string[] SplitByWhitespace(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
