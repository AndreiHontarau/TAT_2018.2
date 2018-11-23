using System;

namespace DEV_3
{
    /// <summary>
    /// Class MainClass provides basic functionality of the program
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">The command-line arguments. First argument is a number to convert, second is a new numeral sysrem base.</param>
        static void Main(string[] args)
        {
            try
            {
                int numberForConversion = int.Parse(args[0]);
                int newBase = int.Parse(args[1]);
                //Checking for the correctness of inputed base
                if (newBase < (int) DecimalToOtherNumeralSystemsConverter.newBaseRange.minBase ||
                    newBase > (int) DecimalToOtherNumeralSystemsConverter.newBaseRange.maxBase)
                {
                    throw new ArgumentOutOfRangeException("",
                        "Base of a new numeral system should lay in bwtween 2 and 20 inclusively.");
                }

                DecimalToOtherNumeralSystemsConverter DecimalConverter =
                    new DecimalToOtherNumeralSystemsConverter(numberForConversion);
                Console.WriteLine(DecimalConverter.ConvertDecimalNumber(newBase));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: arguments shold contain only decimal integer numbers.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Converter must take two arguments.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Entered number was either too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
