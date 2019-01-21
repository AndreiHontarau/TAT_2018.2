using DEV_5.Products;

namespace DEV_5.Facrories
{
    /// <summary>
    /// Factory for Truck class objects
    /// </summary>
    class TruckCreator : VehicleCreator
    {
        /// <summary>
        /// Creates an object of Truck class
        /// </summary>
        /// <returns>Created Truck object</returns>
        public override void Create(out Vehicle vehicle, string[] args)
        {
            vehicle = new Truck(args[0], args[1], System.Single.Parse(args[2]), int.Parse(args[3]));
        }
    }
}
