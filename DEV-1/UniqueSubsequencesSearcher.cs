namespace DEV_1
{
	class UniqueSubsequencesSearcher
	{
		/// <summary>
		/// Entry point
		/// </summary>
		static void Main(string[] args)
		{
			string Sequence;

			if (args.Length == 0) //Checking for the presence of arguments
			{
				System.Console.WriteLine("Enter a non-empty string.");
				return;
			}

			//Checking for multiple arguments and concatenate if needed
			ArgumentsConcatenation ArgumentsConcatenator = new ArgumentsConcatenation();
			Sequence = ArgumentsConcatenator.Concatenate(args);

			MaxLengthOfUniqueSubsequence EntryObject = new MaxLengthOfUniqueSubsequence();
			System.Console.WriteLine("Maximum sequence length: " + EntryObject.SearcMaxLength(Sequence));
		}
	}
}
