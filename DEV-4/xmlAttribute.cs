namespace DEV_4
{
    /// <summary>
    /// Represents an attribute of an XML-Element
    /// </summary>
    class xmlAttribute
    {
        public string Name { get; }
        public string Value { get; }

        public xmlAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}