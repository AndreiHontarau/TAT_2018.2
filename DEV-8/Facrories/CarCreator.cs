using DEV_5.Products;

namespace DEV_5.Facrories
{
    /// <summary>
    /// Factory for Car class objects
    /// </summary>
    class CarCreator : VehicleCreator
    {
        /// <summary>
        /// Creates an object of Car class
        /// </summary>
        /// <returns>Created Car object</returns>
        public override void Create(out Vehicle vehicle, string[] args)
        {
            vehicle = new Car(args[0], args[1], System.Single.Parse(args[2]), int.Parse(args[3]));
        }
    }
}