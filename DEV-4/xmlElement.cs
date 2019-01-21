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
        public string Name { get; }
        public string Body { get; set; }
        public List<xmlAttribute> Attributes { get; }
        public List<xmlElement> NestedElements { get; }

        /// <summary>
        /// Creates sa new instance of xmlElement class
        /// and inisialazes it with name
        /// </summary>
        /// <param name="elementName"></param>
        public xmlElement(string elementName)
        {
            Name = elementName;
            Body = "";
            Attributes = new List<xmlAttribute>();
            NestedElements = new List<xmlElement>();
        }

        /// <summary>
        /// Prints full path to each element body in XML-file, starting from root element
        /// </summary>
        public void PrintRoot()
        {
            foreach (xmlElement nestedElement in NestedElements)
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
            path.Append("<" + Name);
            foreach (xmlAttribute attribute in Attributes)
            {
                path.Append(" { ");
                path.Append(attribute.Name);
                path.Append("=\"");
                path.Append(attribute.Value);
                path.Append("\" } ");
            }
            path.Append(">"); 
            path.Append(" -> ");
            path.Append(Body);
            if (Body == String.Empty)
            {
                foreach (xmlElement nestedElement in NestedElements)
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