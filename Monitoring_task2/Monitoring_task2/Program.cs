using System;

namespace Monitoring_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WebLinkExtractor.ExtractLink(args[0]));
            Console.WriteLine();
        }
    }
}
