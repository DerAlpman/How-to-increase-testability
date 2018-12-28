using System;
using System.IO;
using IncreasingTestabilityStepByStep;
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
            Assert.AreEqual(expected.Length, result.Length);
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
    }
}
