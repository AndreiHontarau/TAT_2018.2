using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DEV_4
{
    /// <summary>
    /// Probides methods to parse XML-Documents
    /// </summary>
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

        /// <summary>
        /// Removes all declarations from XML string
        /// </summary>
        /// <param name="xmlString">String to clear</param>
        public static void RemoveXmlDeclaration(ref string xmlString)
        {
            while (xmlString.Contains("<?"))
            {
                xmlString = xmlString.Remove(xmlString.IndexOf("<?"), xmlString.IndexOf("?>") + 2 - xmlString.IndexOf("<?")).Trim();
            }
        }

        /// <summary>
        /// Extracts element name from opening tag
        /// </summary>
        /// <param name="openingTag">Opening tag</param>
        /// <returns>Element name</returns>
        private static string GetElementName(string openingTag)
        {
            StringBuilder elementName = new StringBuilder();
            elementName.Append(openingTag);
            elementName.Replace("<", String.Empty);
            elementName.Replace(">", String.Empty);
            if (elementName.ToString().Contains(" ")) //Remove attributes from element name
            {
                elementName.Remove(elementName.ToString().IndexOf(" "),
                    elementName.ToString().LastIndexOf("\"") - elementName.ToString().IndexOf(" ") + 1);
            }

            return elementName.ToString();
        }

        private static void AddAttributesToElement(StringBuilder openingTag, xmlElement element)
        {
            string attributes = "";

            attributes = openingTag.ToString().Substring(openingTag.ToString().IndexOf(" "),
                element.name.LastIndexOf("\"") - element.name.IndexOf(" ") + 1);

            while (Regex.IsMatch(openingTag.ToString(), "="))
            {
                int endOfAttributeValue = openingTag.ToString().IndexOf("\"") + 1;
                while (!openingTag[endOfAttributeValue].Equals('"'))
                {
                    endOfAttributeValue++;
                }

                string attributeName = openingTag.ToString().Substring(openingTag.ToString().IndexOf(" ") + 1,
                    openingTag.ToString().IndexOf("\"") - openingTag.ToString().IndexOf(" ") - 2);

                string attributeValue = openingTag.ToString().Substring(openingTag.ToString().IndexOf("\"") + 1,
                    endOfAttributeValue - openingTag.ToString().IndexOf("\"") - 1);

                xmlAttribute attribute = new xmlAttribute(attributeName, attributeValue);

                element.attributes.Add(attribute);

                openingTag.Replace(" " + attributeName + "=\"" + attributeValue + "\"", String.Empty);
            }
        }

        /// <summary>
        /// Reccurently builds a tree of XML-Elements found in XML-string
        /// where each element have list of references to it's
        /// nested elements
        /// </summary>
        /// <param name="xmlString">XML-string ot parse</param>
        /// <param name="rootElement">Element to add found nested elements to</param>
        public static void ExtractElement(string xmlString, xmlElement rootElement)
        {
            while (Regex.IsMatch(xmlString, openingTagPattern))
            {
                StringBuilder elementName = new StringBuilder();
                StringBuilder elementClosingTag = new StringBuilder();
                StringBuilder tagContents = new StringBuilder();
                StringBuilder openingTag = new StringBuilder();

                Match element = Regex.Match(xmlString, openingTagPattern);

                openingTag.Append(element.Value);
                elementName.Append(GetElementName(element.Value));

                elementClosingTag.Append(xmlString.Substring(xmlString.IndexOf("</" + elementName.ToString()),
                    elementName.Length + 3));

                tagContents.Append(xmlString.Substring(xmlString.IndexOf(element.Value) + element.Value.Length,
                    xmlString.IndexOf(elementClosingTag.ToString()) - xmlString.IndexOf(element.Value)).Trim());

                xmlElement newElement = new xmlElement(elementName.ToString());

                if (Regex.IsMatch(element.Value, "="))
                {
                    AddAttributesToElement(openingTag, newElement);
                }

                // If there is nested tag inside current tag call ExtractElement for it,
                // else extract current tag's body
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

                rootElement.nestedElements.Add(newElement);
            }
        }
    }
}