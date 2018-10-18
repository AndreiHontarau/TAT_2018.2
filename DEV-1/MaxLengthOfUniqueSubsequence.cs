using System.Linq;

namespace DEV_1
{
	/// <summary>
	/// Class MaxLengthOfUniqueSubsequence searches for maximum length
	/// of unique subsequence
	/// </summary>
	class MaxLengthOfUniqueSubsequence
	{
		/// <summary>
		/// Method SearcMaxhLength searchs for maximum
		/// length of subsequence consisting of unique
		/// for this subsequence symbols
		/// </summary>
		/// <param name="Sequence">Sequence to search in</param>
		/// <returns>Maximum length of subsequence consisting of unique symbols</returns>
		public int SearcMaxLength(string Sequence)
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