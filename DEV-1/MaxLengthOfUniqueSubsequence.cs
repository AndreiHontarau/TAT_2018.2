using System.Text;
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
			StringBuilder Subsequence = new StringBuilder(""); //Temporal storage for subsequences
			int MaximumSubsequenceLength = 0;

			for (int i = 0; i < Sequence.Length; i++)
			{
				if (Subsequence.ToString().Contains(Sequence[i]))
				{
					i = i - (Subsequence.Length - Subsequence.ToString().LastIndexOf(Sequence[i]));
					Subsequence.Remove(0, Subsequence.Length);
				}
				else
				{
					Subsequence = Subsequence.Append(Sequence[i]);
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