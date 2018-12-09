using System;
using NUnit.Framework;

namespace Monitoring_task2.Tests
{
    [TestFixture]
    public class WebLinkExtractorTests
    {
        [TestCase("xrtjmvymhttps://github.comsgereiHontarau/TAT_2018.2/blob/Monitoring_task-1/Monitoring/Tests/UnitTest1.cs", "https://github.comsgereiHontarau/TAT_2018.2/blob/Monitoring_task-1/Monitoring/Tests/UnitTest1.cs")]
        public void ExtractLinkTest(string text, string expected)
        {
            Assert.AreEqual(expected, WebLinkExtractor.ExtractLink(text));
        }
    }
}