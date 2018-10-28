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
        public List<xmlAttribute> attributes;
        public List<xmlElement> childElements;

        public xmlElement(string elementName)
        {
            name = elementName;
            body = "";
            attributes = new List<xmlAttribute>();
            childElements = new List<xmlElement>();
        }

        /// <summary>
        /// Prints full path to each element body in XML-file, starting from root element
        /// </summary>
        public void PrintRoot()
        {
            foreach (xmlElement child in childElements)
            {
                child.Print(new StringBuilder());
            }
        }

        /// <summary>
        /// Prints full path to an element body, starting from root element
        /// </summary>
        /// <param name="path">Path, accumulated from root element</param>
        public void Print(StringBuilder path)
        {
            path.Append("<" + name + ">");
            path.Append(" -> ");
            path.Append(body);
            if (body == String.Empty)
            {
                foreach (xmlElement child in childElements)
                {
                    StringBuilder deeperPath = new StringBuilder(path.ToString());
                    child.Print(deeperPath);
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