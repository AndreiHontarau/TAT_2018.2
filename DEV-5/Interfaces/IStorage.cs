namespace DEV_5
{
    interface IStorage
    {
        void AddProduct(Product newItem);
        void CountBrands();
        void CountAllProducts();
        void CountAveragePrice();
        void CountAveragePriceFotBrand(string brand);
    }
}