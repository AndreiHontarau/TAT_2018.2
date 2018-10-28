using System;
using System.IO;

namespace DEV_4
{
    /// <summary>
    /// Provides basic functionality of the program
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                string xmlString = File.ReadAllText(@args[0]);
                xmlParser.RemoveComments(ref xmlString);
                xmlParser.RemoveXmlDeclaration(ref xmlString);
                xmlElement rootElement = new xmlElement("root");
                xmlParser.ExtractElement(xmlString, rootElement);
                rootElement.PrintRoot();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}