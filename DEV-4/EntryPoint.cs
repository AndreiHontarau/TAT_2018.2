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
                string xmlString = File.ReadAllText(@args[0]);
                xmlParser.RemoveComments(ref xmlString);
                Console.WriteLine(xmlString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
