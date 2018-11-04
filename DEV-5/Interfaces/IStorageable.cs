namespace DEV_5
{
    interface IStorageable
    {
        void AddProduct(Product newItem);
        void CountBrands();
        void CountAllProducts();
        void CountAveragePrice();
        void CountAveragePriceFotBrand(string brand);
    }
}