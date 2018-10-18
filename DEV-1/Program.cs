namespace DEV_1
{
	class Program 
	{
		static void Main(string[] args)
		{
			string Sequence;

			if (args.Length == 0) //Checking for the presence of arguments
			{
				System.Console.WriteLine("Enter a non-empty string.");
				return;
			}

			//Checking for multiple input and concatenate if needed
			ArgumentsConcatenation Concatenator = new ArgumentsConcatenation();
			Sequence = Concatenator.Concatenate(args);

			MaxLengthOfUniqueSubsequence MaxLengthCalculation = new MaxLengthOfUniqueSubsequence();
			System.Console.WriteLine("Maximum sequence length: " + MaxLengthCalculation.SearcMaxLength(Sequence));
		}
	}
}
