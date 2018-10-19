namespace DEV_2
{
    class Transliteration
    {   
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Sentence;

            if (args.Length == 0) //Checking for the presence of arguments
            {
                System.Console.WriteLine("Enter a non-empty string.");
                return;
            }

            //Checking for multiple arguments and concatenate if needed
            ArrayOfStringsConcatenation ArgumentsConcatenator = new ArrayOfStringsConcatenation();
            Sentence = ArgumentsConcatenator.Concatenate(args);

            //Transliteration
            AutoDecidingTransliteration Transliterator = new AutoDecidingTransliteration();
            Transliterator.Tranliterate(ref Sentence);
            System.Console.WriteLine(Sentence);
        }
    }
}
