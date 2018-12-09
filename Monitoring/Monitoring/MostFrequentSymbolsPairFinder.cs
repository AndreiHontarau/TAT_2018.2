using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitoring_task1
{
    /// <summary>
    /// Finds the most occurrent pair of symbols in a string
    /// </summary>
    public class MostFrequentSymbolsPairFinder
    {
        private string sequence;

        /// <summary>
        /// Validates string to find in and creates an instance of MostFrequentSymbolsPairFinder
        /// </summary>
        /// <param name="sequence"></param>
        public MostFrequentSymbolsPairFinder(string sequence)
        {
            if (sequence.Length < 2)
            {
                throw new ArgumentException("Sequence is short.");
            }
            this.sequence = sequence;
        }

        /// <summary>
        /// Finds the most occurrent pair of symbols in a string 
        /// </summary>
        /// <returns>The most occurrent pair of symbols in a string</returns>
        public string SearchMostFrequentPair()
        {
            StringBuilder ucheckedSubsequence = new StringBuilder(sequence);
            StringBuilder pair = new StringBuilder("");
            List<string> pairsList = new List<string>();

            while (ucheckedSubsequence.Length > 1)
            {
                pair.Append(ucheckedSubsequence[0]);
                pair.Append(ucheckedSubsequence[1]);

                pairsList.Add(pair.ToString());
                ucheckedSubsequence.Remove(0, 1);

                pair.Clear();
            }

            return pairsList.GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key, StringComparer.Ordinal)
                .First().Key;
        }
    }
}
