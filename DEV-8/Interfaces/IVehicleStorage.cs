using DEV_5.Products;

namespace DEV_5.Interfaces
{
    interface IVehicleStorage
    {
        void CountBrands();
        void CountAllVehicles();
        void CountAveragePrice();
        void CountAveragePriceFotBrand(string brand);
    }
}
