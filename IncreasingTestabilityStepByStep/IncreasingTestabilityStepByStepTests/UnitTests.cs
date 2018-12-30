using System;
using System.IO;
using IncreasingTestabilityStepByStep;
using IncreasingTestabilityStepByStep.Interfaces;
using IncreasingTestabilityStepByStepTests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncreasingTestabilityStepByStepTests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// <para>Ugly acceptance test</para>
        /// </summary>
        [TestMethod]
        public void TestMain()
        {
            StringWriter output = new StringWriter();

            Console.SetOut(output);
            Console.SetIn(new StringReader("Mary had a little lamb"));

            Program.Main(null);

            Assert.AreEqual("Enter text:Number of words: 5\r\n", output.ToString());
        }

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
        public void TestSplittingOfText()
        {
            var expected = new[] { "Mary", "had", "a", "little", "lamb" };
            var result = Program.SplitByWhitespace(" Mary had  a little  lamb ");
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestCountingOfWords()
        {
            var expected = new[] { "Mary", "had", "a", "little", "lamb" };
            var result = Program.CountWords(new[] { "Mary", "had", "a", "little", "lamb" });
            Assert.AreEqual(expected.Length, result);
        }

        /// <summary>
        /// <para>Acceptance test</para>
        /// </summary>
        [TestMethod]
        public void TestCountingOfWordsWithStopwords()
        {
            var result = Program.CountWords(new[] { "hello", "the", "world", "off" });
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestLoadStopwords()
        {
            string[] expected = new[] { "the", "a", "on", "off" };

            StopwordsProvider stopwordsProvider = new StopwordsProvider("test_stopwords.txt");
            string[] stopwords = stopwordsProvider.Load();
            CollectionAssert.AreEqual(expected, stopwords);
        }

        /// <summary>
        /// <para>Scaffolding test</para>
        /// </summary>
        [TestMethod]
        public void TestWordcountWithStopwords()
        {
            IStopwordsProvider mockStopwordsProvider = new MockStopwordsProvider(new[] { "bc" });
            WordsCounter wordCounter = new WordsCounter(mockStopwordsProvider);

            int result = wordCounter.Count(new[] { "a", "bc", "def" });

            Assert.AreEqual(2, result);
        }
    }
}
