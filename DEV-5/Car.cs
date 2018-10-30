namespace DEV_5
{
    /// <summary>
    /// Represents a car
    /// </summary>
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Amount { get; }
        public float Price { get; }

        /// <summary>
        /// Creates new object Car and initialazes it's
        /// fields with entered values
        /// </summary>
        /// <param name="brand">Brand of a car</param>
        /// <param name="model">Model af a car</param>
        /// <param name="price">Price of a car</param>
        /// <param name="amount">Amount of specified cars</param>
        public Car(string brand, string model, float price, int amount)
        {
            Brand = brand;
            Model = model;
            Amount = amount;
            Price = Price;
        }
    }
}