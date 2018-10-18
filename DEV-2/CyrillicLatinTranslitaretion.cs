using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_2
{
    class CyrillicLatinTranslitaretion
    {
        Dictionary<string, string> CyrillicToLatinTransliterationDictionary = new Dictionary<string, string>
        {
            ["а"] = "a",
            ["б"] = "b",
            ["в"] = "v",
            ["г"] = "g",
            ["д"] = "d",
            ["е"] = "e",
            ["ё"] = "yo",
            ["ж"] = "zh",
            ["з"] = "z",
            ["и"] = "i",
            ["й"] = "y",
            ["к"] = "k",
            ["л"] = "l",
            ["м"] = "m",
            ["н"] = "n",
            ["о"] = "o",
            ["п"] = "p",
            ["р"] = "r",
            ["с"] = "s",
            ["т"] = "t",
            ["у"] = "u",
            ["ф"] = "f",
            ["х"] = "kh",
            ["ц"] = "ts",
            ["ч"] = "ch",
            ["ш"] = "sh",
            ["щ"] = "sch",
            ["ъ"] = String.Empty,
            ["ы"] = "y",
            ["ь"] = String.Empty,
            ["э"] = "e",
            ["ю"] = "yu",
            ["я"] = "ya"
        };
        Dictionary<string, string> LatinToCyrillicTransliterationDictionary = new Dictionary<string, string>
        {
            ["sch"] = "щ",
            ["sh"] = "ш",
            ["yo"] = "ё",
            ["yu"] = "ю",
            ["ya"] = "я",
            ["zh"] = "ж",
            ["kh"] = "х",
            ["ts"] = "ц",
            ["ch"] = "ч",
            ["a"] = "а",
            ["b"] = "б",
            ["v"] = "в",
            ["g"] = "г",
            ["d"] = "д",
            ["e"] = "е",//
            ["z"] = "з",
            ["i"] = "и",
            ["y"] = "й",//
            ["k"] = "к",
            ["l"] = "л",
            ["m"] = "м",
            ["n"] = "н",
            ["o"] = "о",
            ["p"] = "п",
            ["r"] = "р",
            ["s"] = "с",
            ["t"] = "т",
            ["u"] = "у",
            ["f"] = "ф",
            ["y"] = "ы",//
            ["e"] = "э",//
        };

        public void CyrillicToLatinTranslitaretion(ref string argument)
        {
            StringBuilder sentence = new StringBuilder("");
            sentence.Append(argument);

            foreach (string letter in CyrillicToLatinTransliterationDictionary.Keys)
            {
                sentence.Replace(letter, CyrillicToLatinTransliterationDictionary[letter]);
            }

            argument = sentence.ToString();
        }

        public void LatinToCyrillicTranslitaration(ref string argument)
        {
            StringBuilder sentence = new StringBuilder("");
            sentence.Append(argument);

            foreach (string letter in LatinToCyrillicTransliterationDictionary.Keys)
            {
                sentence.Replace(letter, LatinToCyrillicTransliterationDictionary[letter]);
            }
            argument = sentence.ToString();
        }
    }
}