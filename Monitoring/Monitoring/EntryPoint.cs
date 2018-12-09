using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring_task1
{
    /// <summary>
    /// Provides an entry point for the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">CL arguments</param>
        static void Main(string[] args)
        {
            MostFrequentSymbolsPairFinder fidner = new MostFrequentSymbolsPairFinder(args[0]);
            Console.WriteLine(fidner.SearchMostFrequentPair());
        }
    }
}
