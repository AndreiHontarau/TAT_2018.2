namespace DEV_5.Products
{
    class Truck : Vehicle
    {
        /// <summary>
        /// Creates new object Truck and initialazes it's
        /// fields with entered values
        /// </summary>
        /// <param name="brand">Brand of a truck</param>
        /// <param name="model">Model af a truck</param>
        /// <param name="unitPrice">Price of one truck</param>
        /// <param name="amount">Amount of specified trucks</param>
        public Truck(string brand, string model, float unitPrice, int amount) : base(brand, model, unitPrice, amount)
        {

        }
    }
}
