namespace Lab_2
{
    /// <summary>
    /// 
    /// </summary>
    class Car
    {
        private string Brand { get; }
        private string Model { get; }
        private string Color { get; }

        /// <summary>
        /// Creates new object Car and initialazes it's
        /// fields with entered values
        /// </summary>
        /// <param name="brand">Brand of a car</param>
        /// <param name="model">Model af a car</param>
        /// <param name="color">Color of a car</param>
        public Car(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
    }
}