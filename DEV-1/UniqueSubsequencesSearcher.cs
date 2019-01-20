namespace DEV_1
{
	class UniqueSubsequencesSearcher
	{
		/// <summary>
		/// Entry point
		/// </summary>
		static void Main(string[] args)
		{
		    try
		    {
		        if (args.Length == 0) //Checking for the presence of arguments
		        {
		            System.Console.WriteLine("Enter a non-empty string.");
		            return;
		        }

		        MaxLengthOfUniqueSubsequence EntryObject = new MaxLengthOfUniqueSubsequence();
		        System.Console.WriteLine("Maximum sequence length: " + EntryObject.SearcMaxLength(args[0]));
		    }
		    catch (System.Exception ex)
		    {
		        System.Console.WriteLine("Error: " + ex);
            }
		}
	}
}
