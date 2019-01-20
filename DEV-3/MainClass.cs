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
                DecimalToOtherNumeralSystemsConvertor Converter = new DecimalToOtherNumeralSystemsConvertor(int.Parse(args[0]));
                Console.WriteLine(Converter.ConvertDecimalNumber(int.Parse(args[1])));
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
