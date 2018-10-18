using System.Text;

namespace DEV_1
{
	/// <summary>
	/// Class ArgumentsConcatenation concatenates array of strings into single string
	/// </summary>
	class ArgumentsConcatenation
	{
		/// <summary>
		/// Method Concatenate concatenates array of strings into single string
		/// </summary>
		/// <param name="arguments">Array of arguments to concatenate</param>
		/// <returns>Concatenated arguments</returns>
		public string Concatenate(string[] arguments)
		{
			StringBuilder argument = new StringBuilder("");

			if (arguments.Length == 1)
			{
				argument.Append(arguments[0]);
			}
			else
			{
				for (int i = 0; i < arguments.Length; i++)
				{
					argument.Append(" ").Append(arguments[i]);
				}
			}

			return argument.ToString();
		}
	}
}