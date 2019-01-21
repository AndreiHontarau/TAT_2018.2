using DEV_5.Products;

namespace DEV_5.Facrories
{
    abstract class VehicleCreator
    {
        public abstract void Create(out Vehicle vehicle, string[] args);
    }
}
