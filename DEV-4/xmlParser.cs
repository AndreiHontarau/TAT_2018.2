using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DEV_4
{
    class xmlParser
    {
        private static string openingTagPattern = @"<[^(/><.)]+>"; //Regular expression for opening tag

        /// <summary>
        /// Removes all comments from XML string and
        /// leading and trailing white-spaces
        /// </summary>
        /// <param name="xmlString">String to clear</param>
        public static void RemoveComments(ref string xmlString)
        {
            while (xmlString.Contains("<!--"))
            {
                xmlString = xmlString.Remove(xmlString.IndexOf("<!--"), xmlString.IndexOf("-->") + 3 - xmlString.IndexOf("<!--")).Trim();
            }
        }

        public static void RemoveXmlDeclaration(ref string xmlString)
        {
            while (xmlString.Contains("<?"))
            {
                xmlString = xmlString.Remove(xmlString.IndexOf("<?"), xmlString.IndexOf("?>") + 2 - xmlString.IndexOf("<?")).Trim();
            }
        }

        //private static string[] FindElement(string xmlSubstring)
        //{


        //        return tagNameAndContents;
        //    }
        //    else
        //    {
        //        tagNameAndContents[0] = String.Empty;
        //        tagNameAndContents[1] = xmlSubstring;

        //        return tagNameAndContents;
        //    }
        //}

        public static void ExtractElement(ref string xmlString)
        {
            StringBuilder tagName = new StringBuilder();
            StringBuilder elementClosingTag = new StringBuilder();
            StringBuilder elementOpeningTag = new StringBuilder();
            string xmlSubstring = "";

            Match element = Regex.Match(xmlString, openingTagPattern);

            tagName.Append(element.Value);
            elementOpeningTag.Append(tagName.ToString());
            tagName.Replace("<", String.Empty);
            tagName.Replace(">", String.Empty);
            if (tagName.ToString().Contains(" ")) //Remove attributes from opening tag
            {
                tagName.Remove(tagName.ToString().IndexOf(" "),
                    tagName.ToString().LastIndexOf("\"") - tagName.ToString().IndexOf(" ") + 1);
            }

            elementClosingTag.Append(xmlString.Substring(xmlString.IndexOf("</" + tagName.ToString()), tagName.Length + 3)); //Append closing tag

            Console.WriteLine(elementOpeningTag + elementClosingTag.ToString());
            xmlSubstring = xmlString.Substring(xmlString.IndexOf(element.Value),
                xmlString.IndexOf(elementClosingTag.ToString()) - xmlString.IndexOf(element.Value));
            Console.WriteLine(xmlSubstring);
        }
    }
}