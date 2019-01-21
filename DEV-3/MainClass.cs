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
                DecimalToOtherNumeralSystemsConverter DecimalConverter =
                    new DecimalToOtherNumeralSystemsConverter(int.Parse(args[0]));
                Console.WriteLine(DecimalConverter.ConvertDecimalNumber(int.Parse(args[1])));
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
