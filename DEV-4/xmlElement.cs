using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_4
{
    /// <summary>
    /// Represents an XML-Element
    /// </summary>
    class xmlElement
    {
        public string name { get; }
        public string body { get; set; }
        public List<xmlAttribute> attributes { get; }
        public List<xmlElement> nestedElements { get; }

        /// <summary>
        /// Creates sa new instance of xmlElement class
        /// and inisialazes it with name
        /// </summary>
        /// <param name="elementName"></param>
        public xmlElement(string elementName)
        {
            name = elementName;
            body = "";
            attributes = new List<xmlAttribute>();
            nestedElements = new List<xmlElement>();
        }

        /// <summary>
        /// Prints full path to each element body in XML-file, starting from root element
        /// </summary>
        public void PrintRoot()
        {
            foreach (xmlElement nestedElement in nestedElements)
            {
                nestedElement.Print(new StringBuilder());
            }
        }

        /// <summary>
        /// Prints full path to an element body, starting from root element
        /// </summary>
        /// <param name="path">Path, accumulated from root element</param>
        public void Print(StringBuilder path)
        {
            path.Append("<" + name);
            foreach (xmlAttribute attribute in attributes)
            {
                path.Append(" { ");
                path.Append(attribute.name);
                path.Append("=\"");
                path.Append(attribute.value);
                path.Append("\" } ");
            }
            path.Append(">"); 
            path.Append(" -> ");
            path.Append(body);
            if (body == String.Empty)
            {
                foreach (xmlElement nestedElement in nestedElements)
                {
                    StringBuilder deeperPath = new StringBuilder(path.ToString());
                    nestedElement.Print(deeperPath);
                }
            }
            else
            {
                Console.WriteLine(path);
                return;
            }
        }
    }
}