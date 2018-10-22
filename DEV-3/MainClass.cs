namespace DEV_3
{
    /// <summary>
    /// Class MainClass provides basic functionality
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
                NumeralSystemsConvertor converter = new NumeralSystemsConvertor();
                System.Console.WriteLine(converter.DecimalNumeralSystemConversion(int.Parse(args[0]), int.Parse(args[1])));
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
