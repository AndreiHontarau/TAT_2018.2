using System.Text;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Class NumeralSystemConvertor converts a decimal number
    /// to other numeral systems. New numeral system base shold
    /// lay in between 2 and 20.
    /// </summary>
    class DecimalToOtherNumeralSystemsConvertor
    {
        private int numberToConvert;
        private bool numberToConvertIsNegative;
        static Dictionary<int, char> DecimalNmbersToLettersDictionary = new Dictionary<int, char>
        {
            [0] = '0',
            [1] = '1',
            [2] = '2',
            [3] = '3',
            [4] = '4',
            [5] = '5',
            [6] = '6',
            [7] = '7',
            [8] = '8',
            [9] = '9',
            [10] = 'A',
            [11] = 'B',
            [12] = 'C',
            [13] = 'D',
            [14] = 'E',
            [15] = 'F',
            [16] = 'G',
            [17] = 'H',
            [18] = 'I',
            [19] = 'J',
        };

        public enum newBaseRange
        {
            minBase = 2,
            maxBase = 20
        }

        /// <summary>
        /// Initializes a new instance of the DecimalToOtherNumeralSystemsConvertor
        /// with specified decimal number and numeral system base
        /// </summary>
        /// <param name="numberForConversion">Number to convert</param>
        /// <param name="newBase">Base of a new numeral system</param>
        public DecimalToOtherNumeralSystemsConvertor(int numberForConversion)
        {
            if (numberForConversion < 0)
            {
                numberToConvert = -numberForConversion;
                numberToConvertIsNegative = true;
            }
            else
            {
                numberToConvert = numberForConversion;
                numberToConvertIsNegative = false;
            }
        }

        /// <summary>
        /// Method DecimalNumeralSystemConversion converts decimal number
        /// to another numeral system
        /// </summary>
        /// <returns>Converted number</returns>
        public string DecimalNumeralSystemConversion(int newBase)
        {
            StringBuilder resultOfConvertion = new StringBuilder("");

            do
            {
                resultOfConvertion.Append(DecimalNmbersToLettersDictionary[numberToConvert % newBase]);
                numberToConvert /= newBase;
            } while (numberToConvert != 0);

            return SignOutput(ReverseString(resultOfConvertion.ToString()));
        }

        /// <summary>
        /// Method ReverseString reverses order of characters
        /// in a string
        /// </summary>
        /// <param name="stringToReverse">String to reverse</param>
        /// <returns>Reversed string</returns>
        private string ReverseString(string stringToReverse)
        {
            char[] charArray = stringToReverse.ToCharArray();
            System.Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Adds sign to result of conversion if needed
        /// </summary>
        /// <param name="conversionResult">Result of conversion</param>
        /// <returns>Signed result of conversion</returns>
        private string SignOutput(string conversionResult)
        {
            if (numberToConvertIsNegative)
            {
                return conversionResult.Insert(0, "-");
            }

            return conversionResult;
        }
    }
}