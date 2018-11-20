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
        /// <param name="args">The command-line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                int numberForConversion = int.Parse(args[0]);
                int newBase = int.Parse(args[1]);
                if (newBase < (int)DecimalToOtherNumeralSystemsConvertor.newBaseRange.minBase || 
                    newBase > (int)DecimalToOtherNumeralSystemsConvertor.newBaseRange.maxBase) //Checking for the correctness of inputed base
                {
                    throw new ArgumentOutOfRangeException("Base", "Base of a new numeral system should lay in bwtween 2 and 20.");
                }

                DecimalToOtherNumeralSystemsConvertor Converter = new DecimalToOtherNumeralSystemsConvertor(numberForConversion);
                Console.WriteLine(Converter.DecimalNumeralSystemConversion(newBase));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: arguments shold contain only decimal integer numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
