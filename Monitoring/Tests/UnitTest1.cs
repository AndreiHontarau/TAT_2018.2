using System;
using NUnit.Framework;

namespace Monitoring_task1.Tests
{
    [TestFixture]
    public class MostFrequentSymbolsPairFinderTests
    {
        [TestCase("fgfg", "fg")]
        [TestCase("fgtntnzrtnfgtnfg", "tn")]
        [TestCase("fg", "fg")]
        public void SearchMostFrequentPairTests(string sequence, string expected)
        {
            MostFrequentSymbolsPairFinder finder = new MostFrequentSymbolsPairFinder(sequence);

            string actual = finder.SearchMostFrequentPair();

            Assert.AreEqual(expected, actual);
        }

        [TestCase("j")]
        [TestCase("")]
        public void SearchMostFrequentPairTests_ArgumentException(string sequence)
        {
            Assert.Throws<ArgumentException>(() => new MostFrequentSymbolsPairFinder(sequence));
        }
    }
}
