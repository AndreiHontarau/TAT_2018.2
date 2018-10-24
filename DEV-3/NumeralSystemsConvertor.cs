using System.Text;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Class NumeralSystemConvertor converts a number
    /// between numeral systems
    /// </summary>
    class DecimalToOtherNumeralSystemsConvertor
    {
        Dictionary<int, string> DecimalNmbersToLettersDictionary = new Dictionary<int, string>
        {
            [0] = "0",
            [1] = "1",
            [2] = "2",
            [3] = "3",
            [4] = "4",
            [5] = "5",
            [6] = "6",
            [7] = "7",
            [8] = "8",
            [9] = "9",
            [10] = "A",
            [11] = "B",
            [12] = "C",
            [13] = "D",
            [14] = "E",
            [15] = "F",
            [16] = "G",
            [17] = "H",
            [18] = "I",
            [19] = "J",
            [20] = "K",
        };

        /// <summary>
        /// Method DecimalNumeralSystemConversion converts decimal number
        /// to another numeral system
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <param name="newBase">Base of a new numeral system</param>
        /// <returns>Converted number</returns>
        public string DecimalNumeralSystemConversion(int number, int newBase)
        {
            StringBuilder resultOfConvertion = new StringBuilder("");

            do
            {
                resultOfConvertion.Append(DecimalNmbersToLettersDictionary[number % newBase]);
                number /= newBase;
            } while (number != 0);

            return ReverseString(resultOfConvertion.ToString());
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
    }
}