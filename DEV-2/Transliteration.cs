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

            if (args.Length == 0) //Checking for the presence of arguments
            {
                System.Console.WriteLine("Enter a non-empty string.");
                return;
            }

            //Transliteration
            AutoDecidingTransliteration Transliterator = new AutoDecidingTransliteration();
            Transliterator.Tranliterate(ref args[0]);
            System.Console.WriteLine(args[0]);
        }
    }
}
