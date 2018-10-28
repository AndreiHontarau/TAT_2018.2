using System;
using System.Collections.Generic;

namespace DEV_4
{
    class xmlElement
    {
        public string name { get; }
        public string body { get; }
        public List<xmlAttribute> attributes;
        public List<xmlElement> childElements;

        public xmlElement(string elementName)
        {
            name = elementName;
        }

        public xmlElement(string elementName, string elementBody)
        {
            name = elementName;
            body = elementBody;
        }

        public void PrintElement()
        {
            Console.WriteLine(name);
            foreach (var element in childElements)
            {
                element.PrintElement();
            }
        }
    }
}