namespace DEV_4
{
    /// <summary>
    /// Represents an attribute of an XML-Element
    /// </summary>
    class xmlAttribute
    {
        public string name { get; }
        public string value { get; }

        public xmlAttribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}