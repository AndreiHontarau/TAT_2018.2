namespace DEV_5.Products
{
    /// <summary>
    /// Represents a car
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// Creates new object Car and initialazes it's
        /// fields with entered values
        /// </summary>
        /// <param name="brand">Brand of a car</param>
        /// <param name="model">Model af a car</param>
        /// <param name="unitPrice">Price of one car</param>
        /// <param name="amount">Amount of specified cars</param>
        public Car(string brand, string model, float unitPrice, int amount) : base(brand, model, unitPrice, amount)
        {

        }
    }
}