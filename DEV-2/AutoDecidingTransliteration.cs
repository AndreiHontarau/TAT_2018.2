using System;
using System.Linq;

namespace DEV_2
{   /// <summary>
    ///Class AutoDecidingTransliteration detects set of characters (cyrrilic or latin)
    ///used in a string and calls appropriate method for transliteration
    ///</summary>
    class AutoDecidingTransliteration
    {
        /// <summary>
        ///Method Tranliterate detects set of characters (cyrillic or latin)
        ///used in a string and calls appropriate method of
        ///CyrillicLatinTranslitaretion class for transliteration
        /// </summary>
        /// <param name="argument">String to transliterate</param>
        public void Tranliterate(ref string argument)
        {
            string check = String.Copy(argument);
            check = check.Replace(" ", string.Empty);
            check = String.Concat(check.OrderBy(c => c));
            CyrillicLatinTranslitaretion Transliterator = new CyrillicLatinTranslitaretion();

            if (Enumerable.Range(1072, 1103).Contains(check[0]) && Enumerable.Range(1072, 1103).Contains(check[check.Length - 1]))
            {
                Transliterator.CyrillicToLatinTranslitaretion(ref argument);
            }
            else if (Enumerable.Range(97, 122).Contains(check[0]) && Enumerable.Range(97, 122).Contains(check[check.Length - 1]))
            {
                Transliterator.LatinToCyrillicTranslitaration(ref argument);
            }
            else
            {
                Console.WriteLine("Wrong input.");
                Environment.Exit(0);
            }
        }
    }
}