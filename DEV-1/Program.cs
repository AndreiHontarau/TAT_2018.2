using System;
using System.Linq;

namespace DEV_1
{   /// <summary>
	/// Class MaxLengthOfUniqueSubsequence searches for maximum length
	/// of unique subsequence
	/// </summary>
	class MaxLengthOfUniqueSubsequence
	{
		static void Main(string[] args)
		{
				if (args.Length == 0) //Checking the presence of arguments
				{
					Console.WriteLine("Enter a non-empty string.");
					return;
				}
				if (args.Length > 1) //Checking for multiple input
				{
					Console.WriteLine("Wrong number of arguments.");
					return;
				}
			MaxLengthOfUniqueSubsequence Object = new MaxLengthOfUniqueSubsequence();
			Console.WriteLine("Maximum sequence length: " + Object.SearcMaxhLength(args[0]));
		}

		/// <summary>
		/// Method SearcMaxhLength searchs for maximum
		/// length of subsequence consisting of unique
		/// for this subsequence symbols
		/// </summary>
		/// <param name="Sequence">Sequence to search in</param>
		/// <returns></returns>
		int SearcMaxhLength(string Sequence)
		{
			string Subsequence = ""; //Temporal storage for subsequences
			int MaximumSubsequenceLength = 0;

			for (int i = 0; i < Sequence.Length; i++)
			{
				if (Subsequence.Contains(Sequence[i]))
				{
					i = i - (Subsequence.Length - Subsequence.LastIndexOf(Sequence[i]));
					Subsequence = "";
				}
				else
				{
					Subsequence = Subsequence + Sequence[i];
					if (MaximumSubsequenceLength < Subsequence.Length)
					{
						MaximumSubsequenceLength = Subsequence.Length;
					}
				}
			}

			return MaximumSubsequenceLength;
		}
	}
}
