using System;
using System.IO;

namespace DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                string xmlString = File.ReadAllText(@args[0]);
                xmlParser.RemoveComments(ref xmlString);
                xmlParser.RemoveXmlDeclaration(ref xmlString);
                xmlParser.ExtractElement(ref xmlString);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}