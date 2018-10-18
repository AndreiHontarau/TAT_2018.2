namespace DEV_1
{
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