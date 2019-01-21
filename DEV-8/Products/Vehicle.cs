namespace DEV_5.Products
{
    class Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public int Amount { get; }
        public float UnitPrice { get; }

        /// <summary>
        /// Creates new object Vehicle and initialazes it's
        /// fields with entered values
        /// </summary>
        /// <param name="brand">Brand of a vehicle</param>
        /// <param name="model">Model af a vehicle</param>
        /// <param name="unitPrice">Price of one vehicle</param>
        /// <param name="amount">Amount of specified vehicles</param>
        public Vehicle(string brand, string model, float unitPrice, int amount)
        {
            Brand = brand;
            Model = model;
            Amount = amount;
            UnitPrice = unitPrice;
        }
    }
}
