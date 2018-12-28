using System;
using System.IO;
using IncreasingTestabilityStepByStep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncreasingTestabilityStepByStepTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMain()
        {
            StringWriter output = new StringWriter();

            Console.SetOut(output);
            Console.SetIn(new StringReader("Mary had a little lamb"));

            Program.Main(null);

            Assert.AreEqual("Enter text:Number of words: 5\r\n", output.ToString());
        }

        [TestMethod]
        public void TestDomainLogic()
        {
            var result = Program.CountWords("Mary had a little lamb");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestDomainLogicWithMultipleWhitespaces()
        {
            var result = Program.CountWords(" Mary had  a little  lamb ");
            Assert.AreEqual(5, result);
        }
    }
}
