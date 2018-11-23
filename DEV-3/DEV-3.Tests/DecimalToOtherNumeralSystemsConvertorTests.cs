using System;
using NUnit.Framework;

namespace DEV_3.Tests
{
    [TestFixture]
    public class DecimalToOtherNumeralSystemsConverterTests
    {
        [TestCase(int.MaxValue, 16, "7FFFFFFF")]
        [TestCase(int.MinValue + 1, 16, "-7FFFFFFF")]
        [TestCase(0, 15, "0")]
        [TestCase(32874, 2, "1000000001101010")]
        [TestCase(1535, 20, "3GF")]
        [TestCase(46875, 13, "1844A")]
        [TestCase(-41681, 7, "-232343")]
        public void ConvertDecimalNumberTest(int numberToConvert, int newBase, string expected)
        {

            DecimalToOtherNumeralSystemsConverter DecimalConverter = new DecimalToOtherNumeralSystemsConverter(numberToConvert);
            string actual = DecimalConverter.ConvertDecimalNumber(newBase);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(13583, 21)]
        [TestCase(369872, 0)]
        [TestCase(3694543, -7)]
        public void ConvertDecimalNumber_ArgumentOutOfRangeException(int numberToConvert, int newBase)
        {
            DecimalToOtherNumeralSystemsConverter DecimalConverter = new DecimalToOtherNumeralSystemsConverter(numberToConvert);
            
            Assert.Throws<ArgumentOutOfRangeException>(() =>  DecimalConverter.ConvertDecimalNumber(newBase));
        }

        public void CreatingInstanceOfDecimalToOtherNumeralSystemsConverter_OverflowException()
        {
            int numberToConvert = int.MinValue;

            Assert.Throws<OverflowException>(() => new DecimalToOtherNumeralSystemsConverter(numberToConvert));
        }
    }
}