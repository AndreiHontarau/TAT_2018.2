using System;
using System.Linq;

namespace DEV_2
{
    class AutoDecidingTransliteration
    {
        public void Tranliterate(ref string argument)
        {
            string check = String.Copy(argument);
            String.Concat(check.OrderBy(c => c));
            Console.WriteLine(check);
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
                System.Environment.Exit(0);
            }
        }
    }
}