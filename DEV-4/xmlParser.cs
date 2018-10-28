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

        public static void ExtractElement(string xmlString, xmlElement rootElement)
        {
            while (Regex.IsMatch(xmlString, openingTagPattern))
            {
                StringBuilder elementName = new StringBuilder();
                StringBuilder elementClosingTag = new StringBuilder();
                StringBuilder elementOpeningTag = new StringBuilder();
                StringBuilder tagContents = new StringBuilder();
                string attributes = "";

                Match element = Regex.Match(xmlString, openingTagPattern);

                elementName.Append(element.Value);
                elementOpeningTag.Append(elementName.ToString());
                elementName.Replace("<", String.Empty);
                elementName.Replace(">", String.Empty);
                if (elementName.ToString().Contains(" ")) //Remove attributes from element name
                {
                    attributes = elementName.ToString().Substring(elementName.ToString().IndexOf(" "),
                        elementName.ToString().LastIndexOf("\"") - elementName.ToString().IndexOf(" ") + 1);

                    elementName.Remove(elementName.ToString().IndexOf(" "),
                        elementName.ToString().LastIndexOf("\"") - elementName.ToString().IndexOf(" ") + 1);
                }

                elementClosingTag.Append(xmlString.Substring(xmlString.IndexOf("</" + elementName.ToString()),
                    elementName.Length + 3)); //Append closing tag

                tagContents.Append(xmlString.Substring(xmlString.IndexOf(element.Value) + element.Value.Length,
                    xmlString.IndexOf(elementClosingTag.ToString()) - xmlString.IndexOf(element.Value)).Trim());

                xmlElement newElement = new xmlElement(elementName.ToString());

                if (Regex.IsMatch(tagContents.ToString(), openingTagPattern))
                {
                    ExtractElement(tagContents.ToString(), newElement);
                    xmlString = xmlString.Remove(xmlString.IndexOf(element.Value),
                        xmlString.IndexOf(elementClosingTag.ToString()) + elementClosingTag.ToString().Length).Trim();
                }
                else
                {
                    newElement.body = tagContents.Replace(elementClosingTag.ToString().TrimEnd('>'), String.Empty).ToString();
                    xmlString = xmlString.Remove(xmlString.IndexOf(element.Value),
                        xmlString.IndexOf(elementClosingTag.ToString()) + elementClosingTag.ToString().Length).Trim();
                }

                rootElement.childElements.Add(newElement);
            }
        }
    }
}