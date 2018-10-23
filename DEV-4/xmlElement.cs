using System.Collections.Generic;

namespace DEV_4
{
    class xmlElement
    {
        private string name { get; }
        private string body { get; }
        private List<xmlAttribute> attributes;
        private List<xmlElement> childElements;
    }
}