using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_4
{
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

        public void PrintRoot()
        {
            foreach (xmlElement child in childElements)
            {
                child.Print(new StringBuilder());
            }
        }

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