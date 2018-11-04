using System.Collections.Generic;

namespace DEV_5
{
    class CarsHouse
    {
        private List<Car> CarsList;

        public CarsHouse()
        {
            CarsList = new List<Car>();
        }

    public void AddCar()
        {
            CarCreator creator = new CarCreator();

            CarsList.Add((Car)creator.Create());
        }

        public void CountBrands()
        {
            int brandsCounter = 0;
            List<string> brands = new List<string>();

            foreach (Car car in CarsList)
            {
                if (!brands.Contains(car.Brand))
                {
                    brands.Add(car.Brand);
                    brandsCounter++;
                }
            }

            System.Console.WriteLine(brandsCounter);
        }
    }
}