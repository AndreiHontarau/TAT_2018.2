using System.Text;

namespace DEV_2
{
    /// <summary>
    /// Class ArrayOfStringsConcatenation concatenates array of strings into single string
    /// and converts result to lower case
    /// </summary>
    class ArrayOfStringsConcatenation
    {
        /// <summary>
        /// Method Concatenate concatenates array of strings into single string
        /// and converts result to lower case
        /// </summary>
        /// <param name="arguments">Array of arguments to concatenate</param>
        /// <returns>Concatenated arguments in lower case</returns>
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
                    argument.Append(arguments[i]).Append(" ");
                }
            }

            argument.Remove(argument.Length - 1, 1); // Delete last space bar
            argument.ToString().ToLower();
            return argument.ToString();
        }
    }
}