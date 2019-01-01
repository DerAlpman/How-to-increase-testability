using IncreasingTestabilityStepByStep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncreasingTestabilityStepByStepTests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// <para>Acceptance test</para>
        /// </summary>
        [TestMethod]
        public void TestDomainLogic()
        {
            var result = Program.CountWords("Mary had a little lamb");
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// <para>Acceptance test</para>
        /// </summary>
        [TestMethod]
        public void TestDomainLogicWithMultipleWhitespaces()
        {
            var result = Program.CountWords(" Mary had  a little  lamb ");
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestWordcountWithStopwordsFound()
        {
            WordsCounter wordCounter = new WordsCounter(new[] { "bc" });

            int result = wordCounter.Count(new[] { "a", "bc", "def" });

            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestWordcountWithStopwordsNotFound()
        {
            WordsCounter wordCounter = new WordsCounter(new[] { "xy" });

            int result = wordCounter.Count(new[] { "a", "bc", "def" });

            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestWordcountWithoutStopwords()
        {
            WordsCounter wordCounter = new WordsCounter(new string[0]);

            int result = wordCounter.Count(new[] { "a", "bc", "def" });

            Assert.AreEqual(3, result);
        }
    }
}
