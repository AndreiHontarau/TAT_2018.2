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
			string Sequence;

			if (args.Length == 0) //Checking for the presence of arguments
			{
				Console.WriteLine("Enter a non-empty string.");
				return;
			}

			//Checking for multiple input and concatenate if needed
			ArgumentsConcatenation Concatenator = new ArgumentsConcatenation();
			Sequence = Concatenator.Concatenate(args);

			MaxLengthOfUniqueSubsequence Object = new MaxLengthOfUniqueSubsequence();
			Console.WriteLine("Maximum sequence length: " + Object.SearcMaxhLength(Sequence));
		}

		/// <summary>
		/// Method SearcMaxhLength searchs for maximum
		/// length of subsequence consisting of unique
		/// for this subsequence symbols
		/// </summary>
		/// <param name="Sequence">Sequence to search in</param>
		/// <returns>Maximum length of subsequence consisting of unique symbols</returns>
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

	/// <summary>
	/// Class ArgumentsConcatenation concatenates array of strings into single string
	/// </summary>
	/// <param name="arguments">Array of arguments to concatenate</param>
	/// <returns>Concatenated arguments</returns>
	class ArgumentsConcatenation
	{
		public string Concatenate(string[] arguments)
		{
			string argument = "";

			if (arguments.Length == 1)
			{
				argument = arguments[0];
			}

			for (int i=0; i < arguments.Length; i++)
			{
				argument = argument + " " + arguments[i];
			}

			return argument;
		}
	}
}
